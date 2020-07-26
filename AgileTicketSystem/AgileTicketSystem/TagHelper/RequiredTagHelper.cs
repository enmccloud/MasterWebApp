using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgileTicketSystem.TagHelper;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AgileTicketSystem.TagHelper
{
    [HtmlTargetElement ("input", Attributes = "my-required")]
    public class RequiredTagHelper : TagHelper
    {

        public override void Process (TagHelperContext context, TagHelperOutput output)
        {
            //add CSS Class to input
            output.Attributes.AppendCssClass("form-control");

            // Create <span> element
            TagBuilder span = new TagBuilder("span");
            span.Attributes.Add("class", "text-danger mr-2");
            span.InnerHtml.Append("*");

            //Add span after input
            output.PostElement.AppendHtml(span);
        }
    }
}
