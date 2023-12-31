#pragma checksum "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d87a51e491ba32877dcbc6b2b54c9165969665bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Area_AreaList), @"mvc.1.0.view", @"/Views/Area/AreaList.cshtml")]
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
#line 1 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d87a51e491ba32877dcbc6b2b54c9165969665bb", @"/Views/Area/AreaList.cshtml")]
    #nullable restore
    public class Views_Area_AreaList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Area/CreateArea"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-icon btn-sm text-white mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
  
    ViewBag.Title = "Area";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Admin Consol</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Area List</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d87a51e491ba32877dcbc6b2b54c9165969665bb4331", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Area Create\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
</div>

<div class=""row"">
    <div class=""col-md-12 col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Area List</div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""Area_Tb"" class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                        <thead>
                            <tr>
                                <th>Agent Name</th>
                                <th>City/Town Name</th>
                                <th>Area Name</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        //List
        loadstate()
        async function loadstate() {
            var table = $('#Area_Tb').DataTable();
            table.destroy();
            table = $('#Area_Tb').dataTable({
                ""paginationType"": ""full_numbers"",
                ""dom"": 'Bfrtip',
                ""buttons"": [ 'excel', 'print'],
                ""searching"": true,
                ""paging"": true,
                ""sort"": true,
                ""info"": true,
                ""ajax"": {
                    ""url"": '");
#nullable restore
#line 64 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Area/GetAreaListByUserId/\' + ");
#nullable restore
#line 64 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
                                                                Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 68 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
                                            Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    ""error"": function (data) {
                        if (data.status == 401) {
                            window.location.replace('/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        }
                    }
                },
                ""order"": [],
                ""columns"": [
                    { ""data"": ""agentName"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""cityName"", ""orderable"": true, ""visible"": true },
                    { ""data"": ""areaName"", ""orderable"": true, ""visible"": true },
                    {
                        ""render"": function (data, type, row) {
                            return '<a class=""btn btn-sm btn-primary"" href=""../Area/AreaEdit?areaId=' + row.areaId + '""><i class=""fa fa-edit""></i></a>' + '&nbsp&nbsp<button class=""btn btn-sm btn-danger"" data-target=""#delete");
                WriteLiteral(@""" data-id=' + row.areaId + ' data-title=""Delete""><i class=""fa fa-trash""></i></button>';

                        }
                    }
                ]
            });
        }

        //Delete
        $('#Area_Tb tbody').on('click', 'button[data-target=""#delete""]', function () {
            var id = $(this).data('id');
            swal({
                html: true,
                title: ""Are you sure?"",
                text: ""You will not be able to recover this data!"",
                type: ""warning"",
                showCancelButton: true,
                confirmButtonColor: ""#DD6B55"",
                confirmButtonText: ""Yes, confirm it!"",
                closeOnConfirm: false
            }, function () {
                $.ajax({
                    type: ""GET"",
                    url: """);
#nullable restore
#line 108 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Area/DeleteArea/\" + id + \"/\" + ");
#nullable restore
#line 108 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
                                                                Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 111 "E:\Pravat Project\EOrderBook\AdminClient\Views\Area\AreaList.cshtml"
                                            Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        if (xhr.status == 200) {
                            $('#Area_Tb').DataTable().ajax.reload(null, false);
                            sweetAlert({
                                html: true,
                                title: ""Area"",
                                text: ""Successfully deleted!"",
                                type: ""success""
                            });
                        } else if (xhr.status == 202) {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else {
                            sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                        }
                    },
                    error: function (data) {
                        if (data.status == 401) {
                            window.location.replace('");
                WriteLiteral(@"/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        }
                    }
                });
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
