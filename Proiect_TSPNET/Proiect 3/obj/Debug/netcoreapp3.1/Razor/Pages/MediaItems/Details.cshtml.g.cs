#pragma checksum "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20429da0b1c755590348dc3f0b48c31646362dcd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Interfata_ASP.Pages.MediaItems.Pages_MediaItems_Details), @"mvc.1.0.razor-page", @"/Pages/MediaItems/Details.cshtml")]
namespace Interfata_ASP.Pages.MediaItems
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\_ViewImports.cshtml"
using Interfata_ASP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20429da0b1c755590348dc3f0b48c31646362dcd", @"/Pages/MediaItems/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"649af7ca6b1c8fc8c6d34c1bcbebe38512d065f0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MediaItems_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container row p-0 m-0\">\r\n    <div>\r\n        <h2 class=\"text-info\">Displaying details for ");
#nullable restore
#line 9 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                                Write(Model.item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
    </div>
</div>
<div class=""col-25 border p-3 mt-3"">

    <table>
        <tr>
            <td colspan=""2"">
                <p style=""font-size:16px"">Path :</p>
            </td>
            <td>
                <p style=""color:#0c7c23;font-size:16px"">");
#nullable restore
#line 20 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                                   Write(Model.item.Path);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <p style=\"font-size:16px\">Extension :</p>\r\n            </td>\r\n            <td>\r\n                <p style=\"color:#0c7c23;font-size:16px\">");
#nullable restore
#line 29 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                                   Write(Model.item.Extension);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <p style=\"font-size:16px\">Description :</p>\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 37 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                 if (string.IsNullOrEmpty(Model.item.Description))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"color:darkred;font-size:16px\"> No description</p>\r\n");
#nullable restore
#line 40 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"color:#0c7c23;font-size:16px\"> ");
#nullable restore
#line 43 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                                        Write(Model.item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 44 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <p style=\"font-size:16px\">Location :</p>\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 52 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                 if (string.IsNullOrEmpty(Model.item.Location))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"color:darkred;font-size:16px\"> No location</p>\r\n");
#nullable restore
#line 55 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"color: #0c7c23;font-size:16px\"> ");
#nullable restore
#line 58 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                                         Write(Model.item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 59 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\">\r\n                <p style=\"font-size:16px\">Event :</p>\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 67 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                 if (string.IsNullOrEmpty(Model.item.Event))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"color: darkred;font-size:16px\"> No event</p>\r\n");
#nullable restore
#line 70 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p style=\"color: #0c7c23;font-size:16px\"> ");
#nullable restore
#line 73 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                                         Write(Model.item.Event);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 74 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n\r\n");
#nullable restore
#line 81 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
 if (Model.item.IsPhoto)
{
    if (System.IO.File.Exists(Model.item.Path))
    {
        byte[] imgByteArray = System.IO.File.ReadAllBytes(Model.item.Path);
        var converted = Convert.ToBase64String(imgByteArray);
        var imgSrc = String.Format("data:image;base64,{0}", converted);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 2645, "\"", 2658, 1);
#nullable restore
#line 88 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
WriteAttributeValue("", 2651, imgSrc, 2651, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\" 500\" height=\"500\" />\r\n");
#nullable restore
#line 89 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container border row p-0 m-0\">\r\n            <div>\r\n                <h2 style=\"color:darkred\">Image path not found, cannot show preview</h2>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 97 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
    }

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container border row p-0 m-0\">\r\n        <div>\r\n            <h2 style=\"color:darkred\">This item is a video, no preview available</h2>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 107 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-20 border p-3 mt-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20429da0b1c755590348dc3f0b48c31646362dcd12320", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 111 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
         if (Model.item.persons.Length != 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div>\r\n                <h2 style=\"color:darkgreen\">Persons</h2>\r\n            </div>\r\n            <table class=\"table table-striped border\">\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20429da0b1c755590348dc3f0b48c31646362dcd13143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 119 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.item.persons[0].FirstName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20429da0b1c755590348dc3f0b48c31646362dcd14775", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 122 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.item.persons[0].LastName);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20429da0b1c755590348dc3f0b48c31646362dcd16406", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 125 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.item.persons[0].Group);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 128 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                 foreach (var person in Model.item.persons)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 132 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                       Write(Html.DisplayFor(i => person.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 135 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                       Write(Html.DisplayFor(i => person.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 138 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                       Write(Html.DisplayFor(i => person.Group));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 141 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 143 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h3 style=\"color:darkred\">");
#nullable restore
#line 146 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                 Write(Model.item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" has no persons Attached</h3>\r\n");
#nullable restore
#line 147 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"col-20 border p-3 mt-3\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20429da0b1c755590348dc3f0b48c31646362dcd21986", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 152 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
         if (Model.item.properties.Length != 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div>
                <h2 style=""color:darkgreen"">Dynamic Properties</h2>
            </div>
            <table class=""table table-striped border"">
                <tr class=""table-secondary"">
                    <th>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20429da0b1c755590348dc3f0b48c31646362dcd22808", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 160 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.item.properties[0].Name);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20429da0b1c755590348dc3f0b48c31646362dcd24438", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 163 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.item.properties[0].Value);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n");
#nullable restore
#line 166 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                 foreach (var property in Model.item.properties)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 170 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                       Write(Html.DisplayFor(i => property.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 173 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                       Write(Html.DisplayFor(i => property.Value));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </td>\r\n\r\n                    </tr>\r\n");
#nullable restore
#line 177 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n");
#nullable restore
#line 179 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <h3 style=\"color:darkred\">");
#nullable restore
#line 182 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
                                 Write(Model.item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral(" has no properties Attached</h3>\r\n");
#nullable restore
#line 183 "C:\Users\Claudiu\Desktop\An3_Sem2\TSP.NET\GIT\Proiect-TSP.NET\Proiect_TSPNET\Proiect 3\Pages\MediaItems\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Interfata_ASP.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Interfata_ASP.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Interfata_ASP.DetailsModel>)PageContext?.ViewData;
        public Interfata_ASP.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
