using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChristmasTE.TagHelpers
{
    public class EmojiTagHelper : TagHelper
    {
        private static readonly String[] Emojis = { "🎄", "🎅", "🤶" };
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            int index = new Random().Next(0, Emojis.Length);
            output.Content.SetContent(Emojis[index]);
        }
    }
}
