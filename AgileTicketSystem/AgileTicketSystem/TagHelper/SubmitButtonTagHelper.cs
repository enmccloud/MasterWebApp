using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AgileTicketSystem.TagHelper
{
    [HtmlTargetElement("button", Attributes = "submit")]
    public class SubmitButtonTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            object style = output.Attributes.ContainsName("style") ? output.Attributes["style"].Value : null;
            output.Attributes.SetAttribute("style", style?.ToString());
        }
    }
}
