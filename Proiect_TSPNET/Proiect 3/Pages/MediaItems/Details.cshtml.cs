using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect_TSPNET;

namespace Interfata_ASP
{
    public class DetailsModel : PageModel
    {
        private readonly IService service;
        public MediaItemDTO item;

        public DetailsModel(IService service)
        {
            this.service = service;
        }
        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            else
            {
                this.item = await service.GetItemByIdAsync(id.Value);
            }
            if (item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}