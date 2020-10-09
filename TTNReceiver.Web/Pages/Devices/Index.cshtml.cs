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
    public class IndexModel : PageModel
    {
        private readonly TTNReceiver.Data.TTNReceiverDataContext _context;

        public IndexModel(TTNReceiver.Data.TTNReceiverDataContext context)
        {
            _context = context;
        }

        public IList<Device> Device { get;set; }

        public async Task OnGetAsync()
        {
            Device = await _context.Devices
                .Include(d => d.DeviceType).ToListAsync();
        }
    }
}
