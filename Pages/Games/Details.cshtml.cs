﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly ASPNETCORE_TEST1.Data.ASPNETCORE_TEST1Context _context;

        public DetailsModel(ASPNETCORE_TEST1.Data.ASPNETCORE_TEST1Context context)
        {
            _context = context;
        }

        public Game Game { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game = await _context.Game.FirstOrDefaultAsync(m => m.ID == id);

            if (Game == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}