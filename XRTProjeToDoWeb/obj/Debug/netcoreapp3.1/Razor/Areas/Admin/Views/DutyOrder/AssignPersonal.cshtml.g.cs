#pragma checksum "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f7a961def8112b7c0d7e48e70b7e979f4ac602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_DutyOrder_AssignPersonal), @"mvc.1.0.view", @"/Areas/Admin/Views/DutyOrder/AssignPersonal.cshtml")]
namespace AspNetCore
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
#line 2 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\_ViewImports.cshtml"
using YSKProje.ToDo.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\_ViewImports.cshtml"
using XRTProje.ToDo.DTO.DTOs.UrgencyDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\_ViewImports.cshtml"
using XRTProje.ToDo.DTO.DTOs.NotificationDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\_ViewImports.cshtml"
using XRTProje.ToDo.DTO.DTOs.DutyDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\_ViewImports.cshtml"
using XRTProje.ToDo.DTO.DTOs.AppUserDTOs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f7a961def8112b7c0d7e48e70b7e979f4ac602", @"/Areas/Admin/Views/DutyOrder/AssignPersonal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5813a2df8db54f68858f3892656701b1cdde289f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_DutyOrder_AssignPersonal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalAssignListDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:10rem!important"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AssignStaff", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::YSKProje.ToDo.Web.TagHelpers.DutyAppUserIdTagHelper __YSKProje_ToDo_Web_TagHelpers_DutyAppUserIdTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
  
    ViewData["Title"] = "AssignPersonal";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-2"">

    <div class=""col-md-4"">
        <div class=""card border-info shadow"">
            <div class=""card-header"">
                <h4 class=""text-center lead pt-2 "">Görev Bilgileri</h4>
            </div>

            <div class=""card-body"">
                <h5 class=""card-title"">");
#nullable restore
#line 17 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
                                  Write(Model.Duty.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
                                Write(Model.Duty.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\">\r\n                    <strong>Aciliyet Durumu:</strong><span class=\"badge badge-info\">");
#nullable restore
#line 20 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
                                                                               Write(Model.Duty.Urgency.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </p>
            </div>
        </div>
    </div>
    <div class=""col-md-8"">

        <div class=""card border-info mb-3"">
            <div class=""card-header"">
                <h5 class=""card-title"">Personel Bilgileri</h5>
            </div>

            <div class=""row no-gutters"">
                <div class=""col-md-4"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "94f7a961def8112b7c0d7e48e70b7e979f4ac6028534", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1126, "~/img/", 1126, 6, true);
#nullable restore
#line 34 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
AddHtmlAttributeValue("", 1132, Model.AppUser.Picture, 1132, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
AddHtmlAttributeValue("", 1210, Model.AppUser.Name, 1210, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-8\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 38 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
                                          Write(Model.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 38 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
                                                              Write(Model.AppUser.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("GetDutyAppUserId", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f7a961def8112b7c0d7e48e70b7e979f4ac60211634", async() => {
            }
            );
            __YSKProje_ToDo_Web_TagHelpers_DutyAppUserIdTagHelper = CreateTagHelper<global::YSKProje.ToDo.Web.TagHelpers.DutyAppUserIdTagHelper>();
            __tagHelperExecutionContext.Add(__YSKProje_ToDo_Web_TagHelpers_DutyAppUserIdTagHelper);
#nullable restore
#line 39 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
__YSKProje_ToDo_Web_TagHelpers_DutyAppUserIdTagHelper.AppUserId = Model.AppUser.Id;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("app-user-id", __YSKProje_ToDo_Web_TagHelpers_DutyAppUserIdTagHelper.AppUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                        <p class=\"card-text\">\r\n                            <small class=\"text-muted\">");
#nullable restore
#line 41 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
                                                 Write(Model.AppUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                        </p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f7a961def8112b7c0d7e48e70b7e979f4ac60213716", async() => {
                WriteLiteral("\r\n            <p class=\"lead text-center\">\r\n                Yukarıdaki Göreve İlgili Personel Atanacaktır. Bu İşlemi Gerçekleştirmek İstediğinizden Emin Misiniz?\r\n            </p>\r\n            <div class=\"form-group text-center\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f7a961def8112b7c0d7e48e70b7e979f4ac60214232", async() => {
                    WriteLiteral("<i class=\"fas fa-chevron-circle-left mr-2\"></i>Vazgeç");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
                                              WriteLiteral(Model.Duty.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"PersonalId\"");
                BeginWriteAttribute("value", " value=\"", 2344, "\"", 2369, 1);
#nullable restore
#line 55 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
WriteAttributeValue("", 2352, Model.AppUser.Id, 2352, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"DutyId\"");
                BeginWriteAttribute("value", " value=\"", 2425, "\"", 2447, 1);
#nullable restore
#line 56 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\DutyOrder\AssignPersonal.cshtml"
WriteAttributeValue("", 2433, Model.Duty.Id, 2433, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <button type=\"submit\" class=\" btn btn-info \"><i class=\"fas fa-check mr-2\"></i>Görevlendir</button>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalAssignListDto> Html { get; private set; }
    }
}
#pragma warning restore 1591