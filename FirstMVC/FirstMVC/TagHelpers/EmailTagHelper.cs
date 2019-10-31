using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace FirstMVC.TagHelpers
{
    // If you were to write the email tag self-closing(<email mail-to= "Rick" />), 
    // the final output would also be self-closing.To enable the ability to write 
    // the tag with only a start tag(<email mail-to= "Rick" >) 
    // you must decorate the class with the following:
    // [HtmlTargetElement("email", TagStructure = TagStructure.WithoutEndTag)]
    public class EmailTagHelper : TagHelper
    {
        #region Part 2

        private const string EmailDomain = "contoso.com";

        // Can be passed via <email mail-to="..." />. 
        // PascalCase gets translated into kebab-case.
        public string MailTo { get; set; }

        #endregion

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";    // Replaces <email> with <a> tag

            #region Part 2

            //var address = MailTo + "@" + EmailDomain;
            //output.Attributes.SetAttribute("href", "mailto:" + address);
            //output.Content.SetContent(address);

            #endregion
        }

        #region Part 3: ProcessAsync

        //private const string EmailDomain = "contoso.com";
        //public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        //{
        //    output.TagName = "a";       // Replaces <email> with <a> tag
        //    var content = await output.GetChildContentAsync();
        //    var target = content.GetContent() + "@" + EmailDomain;
        //    output.Attributes.SetAttribute("href", "mailto:" + target);
        //    output.Content.SetContent(target);
        //}

        #endregion
    }
}
