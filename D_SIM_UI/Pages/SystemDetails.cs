using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace D_SIM_UI.Pages
{
    public partial class SystemDetails
    {
        [Parameter]
        public string SystemID { get; set; }

        protected override Task OnInitializedAsync()
        {
            
            return base.OnInitializedAsync();
        }
    }
}
