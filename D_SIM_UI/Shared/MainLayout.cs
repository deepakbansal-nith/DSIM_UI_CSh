using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Xml;

namespace D_SIM_UI.Shared
{
    public partial class MainLayout
    {
        [Inject]
        public HttpClient HttpClient { get; set; }

        List<string> systemList;

        protected override async Task OnInitializedAsync()
        {
            systemList = new List<string>();

            var response = await HttpClient.GetStringAsync("Systems/");
            XDocument doc = (XDocument)JsonConvert.DeserializeXNode(response);

            foreach (XElement systemName in doc.Root.Element("Systems").Elements("System"))
            {
                systemList.Add(systemName.Value);
            }

        }


    }
}
