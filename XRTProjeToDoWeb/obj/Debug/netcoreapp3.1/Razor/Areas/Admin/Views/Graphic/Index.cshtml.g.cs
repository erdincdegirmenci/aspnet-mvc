#pragma checksum "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\Graphic\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28161c4e016498312557f903a477ab9cd19f2c89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Graphic_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Graphic/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28161c4e016498312557f903a477ab9cd19f2c89", @"/Areas/Admin/Views/Graphic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5813a2df8db54f68858f3892656701b1cdde289f", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Graphic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Erdinc\Desktop\ASP.NETCoreMvcApi\UdemyToDoPure\UdemyToDo\XRTProjeToDoWeb\Areas\Admin\Views\Graphic\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-6"">
        <div id=""piechart_3d"" style="" height: 500px;"" class=""w-100;""></div>

    </div>
    <div class=""col-md-6"">
        <div id=""piechart"" style="" height: 500px;"" class=""w-100""></div>
    </div>
</div>


");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script type=""text/javascript"">


        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            let enCokIsTamamlayan = [['Personel Adı', 'Görev Sayisi']];

            $.ajax({
                type: ""Get"",
                url: ""./Graphic/EnCokTamamlayan"",
                async: false,
                success: function (data) {
                    let gelenObje = jQuery.parseJSON(data);
                    $.each(gelenObje, (index, value) => {
                        enCokIsTamamlayan.push([value.Name, value.DutyNumber]);
                    });
                }
            })
            var data = google.visualization.arrayToDataTable(enCokIsTamamlayan);

            var options = {
                title: 'En Çok İş Tamamlayan 5 Personel',
                backgroundColor: '#272b30'");
                WriteLiteral(@",
                titleTextStyle: { color: '#FFF' },
                legendTextStyle: { color: '#FFF' },
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart'));

            chart.draw(data, options);
        }

        google.charts.load(""current"", { packages: [""corechart""] });
        google.charts.setOnLoadCallback(drawChart2);

        function drawChart2() {

            let EnCokisteCalisan = [['Personel Adı', 'Görev Sayisi']];

            $.ajax({
                type: ""Get"",
                url: ""./Graphic/EnCokCalisan"",
                async: false,
                success: function (data) {
                    let gelenObje2 = jQuery.parseJSON(data);
                    $.each(gelenObje2, (index, value) => {
                        EnCokisteCalisan.push([value.Name, value.DutyNumber]);
                    });
                }
            })
            var data = google.visualization.arrayToDataTable(EnCokisteCalis");
                WriteLiteral(@"an);

            var options = {
                title: 'Şuan Çalışan Personel Sayısı',
                is3D: true,
                backgroundColor: '#272b30',
                titleTextStyle: { color: '#FFF' },
                legendTextStyle: { color: '#FFF' },
            };

            var chart = new google.visualization.PieChart(document.getElementById('piechart_3d'));
            chart.draw(data, options);
        }
    </script>
");
            }
            );
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
