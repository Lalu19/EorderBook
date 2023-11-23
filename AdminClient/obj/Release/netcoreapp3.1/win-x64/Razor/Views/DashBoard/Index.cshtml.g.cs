#pragma checksum "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecda71ee719d811edce9ad710d932507beec5da1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Index), @"mvc.1.0.view", @"/Views/DashBoard/Index.cshtml")]
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
#line 1 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecda71ee719d811edce9ad710d932507beec5da1", @"/Views/DashBoard/Index.cshtml")]
    #nullable restore
    public class Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
  
    ViewBag.Title = "Dashboard";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-home mr-1""></i> Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Dashboard</li>
    </ol>
    
</div>


<div class=""row"">
    <div class=""col-xl-3 col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-body d-flex"">
                <div class=""card-order"">
                    <h6 class=""mb-2"">Hospital Admin Users</h6>
                    <h2 class=""mb-1""><span class=""number-font counter"" id=""totalUser""></span></h2>
                    <p class=""text-muted fs-12 mb-0""></p>
                </div>
                <div class=""ml-auto"">
                    <span class=""bg-primary-transparent icon-service text-primary""><i class=""mdi mdi-account-multiple  fs-2""></i> </span>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-12"">
        <div class=""card"">
  ");
            WriteLiteral(@"          <div class=""card-body d-flex"">
                <div class=""card-order"">
                    <h6 class=""mb-2"">Active users</h6>
                    <h2 class=""mb-1""><span class=""number-font counter"" id=""activeUser""></span></h2>
                    <p class=""text-muted fs-12 mb-0""></p>
                </div>
                <div class=""ml-auto"">
                    <span class=""bg-primary-transparent icon-service text-primary""><i class=""mdi mdi-account-multiple  fs-2""></i> </span>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-body d-flex"">
                <div class=""card-order"">
                    <h6 class=""mb-2"">In-Active users</h6>
                    <h2 class=""mb-1""><span class=""number-font counter"" id=""inActiveUser""></span></h2>
                    <p class=""text-muted fs-12 mb-0""></p>
                </div>
                <div class=""ml-auto"">
     ");
            WriteLiteral(@"               <span class=""bg-primary-transparent icon-service text-primary""><i class=""mdi mdi-account-multiple  fs-2""></i> </span>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-lg-6 col-md-12"">
        <div class=""card"">
            <div class=""card-body d-flex"">
                <div class=""card-order"">
                    <h6 class=""mb-2"">Admin users</h6>
                    <h2 class=""mb-1""><span class=""number-font counter"" id=""adminUser""></span></h2>
                    <p class=""text-muted fs-12 mb-0""></p>
                </div>
                <div class=""ml-auto"">
                    <span class=""bg-primary-transparent icon-service text-primary""><i class=""mdi mdi-account-multiple  fs-2""></i> </span>
                </div>
            </div>
        </div>
    </div>
</div>
<section>
    <div class=""row"">

        <div class=""col-sm-12 col-md-12 col-lg-7 col-xl-8"">
            <div class=""card"">
                <div class=""card");
            WriteLiteral(@"-header"">
                    <div class=""card-title"">Date Wise Login</div>
                    <div class=""card-options"">
                        <a href=""#"" class=""card-options-collapse"" data-toggle=""card-collapse""><i class=""fe fe-chevron-up""></i></a>
                     
                    </div>
                </div>
                <div class=""card-body"">
                    <canvas id=""dateChart"" width=""400"" height=""400""></canvas>
                </div>
            </div>
        </div>

        <div class=""col-sm-12 col-md-12 col-lg-5 col-xl-4"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title"">User Statistics</div>
                    <div class=""card-options"">
                        <a href=""#"" class=""card-options-collapse"" data-toggle=""card-collapse""><i class=""fe fe-chevron-up""></i></a>
                     
                    </div>
                </div>
                <div class=""card-body"">
          ");
            WriteLiteral(@"          <canvas id=""pieChart"" width=""400"" height=""400""></canvas>
                </div>
            </div>
        </div>
      
    </div>
    <div class=""row"">

        <div class=""col-sm-12 col-md-12 col-lg-6 col-xl-6"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title"">Month Wise Login</div>
                    <div class=""card-options"">
                        <a href=""#"" class=""card-options-collapse"" data-toggle=""card-collapse""><i class=""fe fe-chevron-up""></i></a>
                     
                    </div>
                </div>
                <div class=""card-body"">
                    <canvas id=""monthChart"" width=""400"" height=""400""></canvas>
                </div>
            </div>
        </div>

        <div class=""col-sm-12 col-md-12 col-lg-6 col-xl-6"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title"">Year Wise Login</div>
      ");
            WriteLiteral(@"              <div class=""card-options"">
                        <a href=""#"" class=""card-options-collapse"" data-toggle=""card-collapse""><i class=""fe fe-chevron-up""></i></a>
                     
                    </div>
                </div>
                <div class=""card-body"">
                    <canvas id=""yearChart"" width=""400"" height=""400""></canvas>
                </div>
            </div>
        </div>
        
    </div>
</section>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var dateChartData = null, pieChartData = null, monthChartData = null, yearChartData=null;\r\n        $(function () {\r\n            if (\'");
#nullable restore
#line 150 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
            Write(Context.Session.GetString("RoleName"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'== 'Admin') {
                $('#userStatus').show();
                loadUserStatus();
            }
            loadDateChart();
            loadPieChart();
            loadMonthChart();
            loadYearChart();

            new Chart($('#dateChart'), {
                type: 'line',
                data: {
                    labels: dateChartData.map(x => x.date),
                    datasets: [
                        {
                            label: 'Date wise Login',
                            backgroundColor: '#25c574',
                            data: dateChartData.map(x => x.count)
                        }
                    ]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false
                }
            });

            new Chart($('#pieChart'), {
                type: 'pie',
                data: {
                    labels: pieChartData.map(x => x.roleName),
             ");
                WriteLiteral(@"       datasets: [
                        {                          
                            backgroundColor: '#25c574',
                            data: pieChartData.map(x => x.count)
                        }
                    ]
                },
                options: {
                    responsive: true,
                    maintainAspectRatio: false
                }
            });

            new Chart($('#monthChart'), {
                type: 'bar',
                data: {
                    labels: monthChartData.map(x => x.month),
                    datasets: [
                        {
                            label: 'Month wise Login',
                            backgroundColor: '#25c574',
                            data: monthChartData.map(x => x.count)
                        }
                    ]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
 ");
                WriteLiteral(@"                               beginAtZero: true
                            }
                        }]
                    }
                }
            });

            new Chart($('#yearChart'), {
                type: 'bar',
                data: {
                    labels: yearChartData.map(x => x.year),
                    datasets: [
                        {
                            label: 'Year wise Login',
                            backgroundColor: '#25c574',
                            data: yearChartData.map(x => x.count)
                        }
                    ]
                },
                options: {
                    scales: {
                        yAxes: [{
                            ticks: {
                                beginAtZero: true
                            }
                        }]
                    }
                }
            });
        });

        function loadDateChart() {
            $.ajax({
             ");
                WriteLiteral("   type: \"GET\",\r\n                url: \"");
#nullable restore
#line 244 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetLogInSummaryByDate/");
#nullable restore
#line 244 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                                         Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 247 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                async:false,
                success: function (data) {
                    //console.log(data)
                    dateChartData = data;
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }
        function loadPieChart() {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 267 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetRoleWiseUser\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 270 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                async:false,
                success: function (data) {
                    //console.log(data)
                    pieChartData = data;
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }
        function loadMonthChart() {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 290 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetLogInSummaryByMonth/");
#nullable restore
#line 290 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                                          Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 293 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                async:false,
                success: function (data) {
                    //console.log(data)
                    monthChartData = data;
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }
        function loadYearChart() {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 313 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/GetLogInSummaryByYear/");
#nullable restore
#line 313 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                                         Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 316 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                async:false,
                success: function (data) {
                    //console.log(data)
                    yearChartData = data;
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }

        function loadUserStatus() {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 337 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Users/UserStatus\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 340 "D:\Pravat Project\Yatri\Yatri\AdminConsole\AdminClient\Views\DashBoard\Index.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (data) {
                    if (data) {
                        $('#totalUser').text(data.totalUser);
                        $('#activeUser').text(data.activeUser);
                        $('#inActiveUser').text(data.inActiveUser);
                        $('#adminUser').text(data.adminUser);
                    } else {
                        sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                    }
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }
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
