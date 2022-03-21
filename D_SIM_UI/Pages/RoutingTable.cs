using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using AntDesign.TableModels;
using System.Text.Json;
using AntDesign;
using System.Net.Http.Json;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Xml;
using System.Net.Http;
using System.Text;

namespace D_SIM_UI.Pages
{
    public partial class RoutingTable
    {
        [Inject]
        public HttpClient HttpClient { get; set; }

        [Parameter]
        public string SystemID { get; set; }

        RT_Row[] RTRows;
        ITable table;
    

        protected override async Task OnInitializedAsync()
        {
            await GetRTBySystemID();
        }

        private async Task GetRTBySystemID()
        {
            List<RT_Row> tempList = new List<RT_Row>();

            var response = await HttpClient.GetStringAsync(String.Format("/Systems/{0}/RoutingTable", SystemID));
            XDocument doc = (XDocument)JsonConvert.DeserializeXNode(response);

            foreach (XElement location in doc.Root.Element("Systems").Element("System").Elements("Location"))
            {
                RT_Row row = new RT_Row(location);
                tempList.Add(row);
            }


            RTRows = tempList.ToArray();
        }

        public async Task upDateDefaultDestinationAsync(string newDefDest, RT_Row rowToUpdate) 
        {
            //rowToUpdate.DefaultDestination = newDefDest;
            await PostBySystemID(rowToUpdate.LocationID, "DefaultDestination", newDefDest);
            await GetRTBySystemID();

        }

        public async Task upCheckEnabledAsync(string param, string currentValue, RT_Row rowToUpdate)
        {
            string newValue = "False";
            //rowToUpdate.DefaultDestination = newDefDest;
            if (currentValue.Equals("True"))
            {
                newValue = "False";
            } else if (currentValue.Equals("False")) 
            {
                newValue = "True";
            }
            await PostBySystemID(rowToUpdate.LocationID, param, newValue);
            await GetRTBySystemID();

        }

        private async Task PostBySystemID(string locationID, string field, string value)
        {
            XDocument xDoc = new XDocument(new XElement("Update"));
            xDoc.Root.Add(new XElement("System", SystemID));
            xDoc.Root.Element("System").Add(new XElement("Location", locationID));
            xDoc.Root.Element("System").Add(new XElement(field, value));
            string responseString = JsonConvert.SerializeXNode(xDoc);

            var data = new StringContent(responseString, Encoding.UTF8, "application/json");

            var response = await HttpClient.PostAsync(String.Format("/Systems/{0}/UpdateField", SystemID), data);
        }
    }



    public class RT_Row
    {
        public string LocationID;
        public string[] Destinations;
        public string DefaultDestination;
        public string Status;
        public string CurrentFulfilment;
        public string MaximumFulfilment;
        public string LaneCheckEnabled;
        public string ProfileCheckEnabled;
        

        public RT_Row(XElement Xrow)
        {
            this.LocationID = Xrow.Element("LocationID").Value;
            this.DefaultDestination = Xrow.Element("DefaultDestination").Value;
            this.Status = Xrow.Element("Status").Value;
            this.CurrentFulfilment = Xrow.Element("CurrentFulfilment").Value;
            this.MaximumFulfilment = Xrow.Element("MaximumFulfilment").Value;
            this.LaneCheckEnabled = Xrow.Element("LaneCheckEnabled").Value;
            this.ProfileCheckEnabled = Xrow.Element("ProfileCheckEnabled").Value;
            

            List<string> tempList = new List<string>();
            foreach (XElement destination in Xrow.Element("Destinations").Elements())
            {
                tempList.Add(destination.Value);
            }
            this.Destinations = tempList.ToArray();
        }

        public RT_Row()
        {
        }

    }
}
