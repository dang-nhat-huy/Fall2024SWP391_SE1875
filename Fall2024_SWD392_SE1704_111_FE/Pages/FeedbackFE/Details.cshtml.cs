﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BusinessObject.Model;

namespace Fall2024_SWD392_SE1704_111_FE.Pages.FeedbackFE
{
    public class DetailsModel : PageModel
    {
        private readonly BusinessObject.Model.HairSalonBookingContext _context;

        public DetailsModel(BusinessObject.Model.HairSalonBookingContext context)
        {
            _context = context;
        }

      public Feedback Feedback { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Feedbacks == null)
            {
                return NotFound();
            }

            var feedback = await _context.Feedbacks.FirstOrDefaultAsync(m => m.FeedbackId == id);
            if (feedback == null)
            {
                return NotFound();
            }
            else 
            {
                Feedback = feedback;
            }
            return Page();
        }
    }
}
