using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNETCORE_TEST1.Data;
using ASPNETCORE_TEST1.Models;

namespace ASPNETCORE_TEST1.Pages.Games
{
    public class IndexModel : PageModel
    {
        private readonly ASPNETCORE_TEST1.Data.ASPNETCORE_TEST1Context _context;

        public IndexModel(ASPNETCORE_TEST1.Data.ASPNETCORE_TEST1Context context)
        {
            _context = context;
        }

        public IList<Game> Game { get;set; }

        public async Task OnGetAsync()
        {
            Game = await _context.Game.ToListAsync();
        }
    }
}
