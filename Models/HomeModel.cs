using System;
using Microsoft.AspNetCore.Mvc;

namespace TranslatorAPI.Models
{
    public class Success
    {
        public int total { get; set; }
    }

    public class Contents
    {
        [BindProperty]
        public string translated { get; set; }
        public string text { get; set; }
        public string translation { get; set; }
    }

    public class RootObject
    {
        public Success success { get; set; }
        public Contents contents { get; set; }
    }
    
}