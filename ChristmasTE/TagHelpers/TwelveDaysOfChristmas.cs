using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasTE.TagHelpers
{
    public class TwelveDaysOfChristmas : TagHelper
    {
        public int Day { get; set; }
        public string Items { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "p";
            var itemList = Items.Split(",");
            string result = "On the " + Describe(Day) + " of Christmas, my true love gave to me<br/>";
            for (int i = Day; i > 1; i--)
            {
                result += i + " " + itemList[i - 1] + "<br/>";
            }
            if (Day > 1)
            {
                result += "and ";
            }
            result += itemList[0];
            output.Content.SetHtmlContent(result);
        }

        private string Describe(int number)
        {
            return number switch
            {
                1 => "1st",
                2 => "2nd",
                3 => "3rd",
                _ => number + "th",
            };
        }
    }
}
