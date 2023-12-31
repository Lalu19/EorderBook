#pragma checksum "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6b9dba60dff5573c66379081faf72dc9536047e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_StoreNotification), @"mvc.1.0.view", @"/Views/Store/StoreNotification.cshtml")]
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
#line 1 "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6b9dba60dff5573c66379081faf72dc9536047e", @"/Views/Store/StoreNotification.cshtml")]
    #nullable restore
    public class Views_Store_StoreNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml"
  
    ViewBag.Title = "Store Notification";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Admin Consol</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Store Notification   </li>
    </ol>
</div>

<div class=""row"">
    <div class=""col-md-12 col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <div class=""card-title"">Store Notification</div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table id=""StoreNotification_Tb"" class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                        <thead>
                            <tr>
                                <th>Store Name</th>
                                <th>Date/Time</th>
                                <th>Status</th>
                                <th>Remark</th>
      ");
            WriteLiteral(@"                          <th>Store Image</th>
                                <th>Visited</th>
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
                WriteLiteral("\r\n    <script>\r\n        var storeId = ");
#nullable restore
#line 44 "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml"
                 Write(ViewBag.storeId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        loadStoreTransction()
        function loadStoreTransction() {
            var table = $('#StoreNotification_Tb').DataTable();
            table.destroy();
            table = $('#StoreNotification_Tb').dataTable({
                ""paginationType"": ""full_numbers"",
                ""dom"": 'Bfrtip',
                ""buttons"": ['copy', 'csv', 'excel', 'pdf', 'print'],
                ""searching"": true,
                ""paging"": true,
                ""sort"": true,
                ""info"": true,
                ""ajax"": {
                    ""url"": '");
#nullable restore
#line 58 "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/StoreNotification/GetStoreNotificationListStoreIdAndUserId/\' + storeId + \"/\" + ");
#nullable restore
#line 58 "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml"
                                                                                                                  Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 62 "E:\Pravat Project\EOrderBook\AdminClient\Views\Store\StoreNotification.cshtml"
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
                    { ""data"": ""storeName"", ""orderable"": true, ""visible"": true },
                    {
                        ""data"": ""createdOn"",
                        ""render"": function (data) {
                            if (data === null) return """";
                            var date = new Date(data);
                            var month = date.getMonth() + 1;
                            return (month.length > 1 ? month : ""0"" + month) + ""/"" + date.getDate() + ""/"" + date.getFullYear() + ""&nbsp;&nbsp;"" + (date.getHours() < 10 ? (""0""");
                WriteLiteral(@" + date.getHours()) : date.getHours()) + "":"" + (date.getMinutes() < 10 ? (""0"" + date.getMinutes()) : date.getMinutes());
                        }
                    },
                    {
                        ""render"": function (data, type, row) {

                            if (row.status === 'ShopClosed') {
                                return '<p class=""tag tag-red"">' + row.status + '</p>';
                            }
                            else if (row.status === 'NoOrder') {
                                return '<p class=""tag tag-lime"">' + row.status + '</p>';
                            }


                        }
                    },
                    { ""data"": ""remark"", ""orderable"": true, ""visible"": true },
                    {
                        ""render"": function (data, type, row) {
                            if (row.storeImage === '')
                                return '';
                            else
                                retu");
                WriteLiteral(@"rn '<img style=""max-width: 20%;"" src=""' + row.storeImage + '""/>' + '&nbsp&nbsp&nbsp&nbsp<a href=""' + row.storeImage + '"" target=""_blank""><i class=""fa fa-eye"" style=""color: black;""></i></a>'

                        }
                    },
                    { ""data"": ""agentName"", ""orderable"": true, ""visible"": true },
                ]
            });
        }
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
