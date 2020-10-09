using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TTNReceiver.Core;
using TTNReceiver.Data;

namespace TTNReceiver.Web.Pages.Devices
{
    public class CreateModel : PageModel
    {
        private readonly TTNReceiver.Data.TTNReceiverDataContext _context;

        public CreateModel(TTNReceiver.Data.TTNReceiverDataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["DeviceTypeId"] = new SelectList(_context.DeviceTypes, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Device Device { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Devices.Add(Device);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
