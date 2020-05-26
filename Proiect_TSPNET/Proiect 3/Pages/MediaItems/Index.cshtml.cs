using System;
using System.Threading.Tasks;
using Interfata_ASP.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_TSPNET;

namespace Interfata_ASP
{
    public class IndexModel : PageModel
    {
        public string[] filterValues = { "Title", "Extension", "Description", "Location", "Event", "Persons", "Properties" };
        private readonly ServiceClient service;
        public MediaItemDTO[] items;
        [BindProperty(SupportsGet = true)]
        public string searchString { get; set; }
        public SelectList filterType;
        [BindProperty(SupportsGet = true)]
        public string filterTypeValue { get; set; }
        public IndexModel()
        {
            filterType = new SelectList(this.filterValues);
            service = new ServiceClient();
        }
        public async Task OnGet()
        {
            if (!string.IsNullOrEmpty(this.filterTypeValue) && !string.IsNullOrEmpty(searchString))
            {
                this.items = Array.FindAll(await service.GetItemsAsync(false, false), i => ItemFilter.Filter(i, this.filterTypeValue, this.searchString));


            }
            else
            {
                this.items = await service.GetItemsAsync(false, false);

            }
        }
    }
}