using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasTE.TagHelpers
{

    public class Countdown : TagHelper
    {
        public DateTime Date { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            int days = (Date - DateTime.Now).Days;
            output.Content.SetContent(days.ToString()); 
        }
    }
}
