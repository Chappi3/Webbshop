﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Kladbutiken.Pages
{
    public class AboutUsModel : PageModel
    {
        private readonly ILogger<AboutUsModel> _logger;
        public User LoggedInAs { get; set; }

        public AboutUsModel(ILogger<AboutUsModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
