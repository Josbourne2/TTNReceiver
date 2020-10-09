using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TTNReceiver.Core;
using TTNReceiver.Data;

namespace TTNReceiver.Web.Pages.Devices
{
    public class DetailsModel : PageModel
    {
        private readonly TTNReceiver.Data.TTNReceiverDataContext _context;

        public DetailsModel(TTNReceiver.Data.TTNReceiverDataContext context)
        {
            _context = context;
        }

        public Device Device { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Device = await _context.Devices
                .Include(d => d.DeviceType).FirstOrDefaultAsync(m => m.Id == id);

            if (Device == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
