#pragma checksum "D:\Santosh\EOrderBook\AdminClient\Views\Country\CreateCountry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75c71b1b0f91fd03c441056e71cbb19d1036f793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Country_CreateCountry), @"mvc.1.0.view", @"/Views/Country/CreateCountry.cshtml")]
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
#line 1 "D:\Santosh\EOrderBook\AdminClient\Views\Country\CreateCountry.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Santosh\EOrderBook\AdminClient\Views\Country\CreateCountry.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75c71b1b0f91fd03c441056e71cbb19d1036f793", @"/Views/Country/CreateCountry.cshtml")]
    #nullable restore
    public class Views_Country_CreateCountry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Country/CountryList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\Santosh\EOrderBook\AdminClient\Views\Country\CreateCountry.cshtml"
  
    ViewBag.Title = "Country";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Admin Consol</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">country Create</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75c71b1b0f91fd03c441056e71cbb19d1036f7934381", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> View\r\n        ");
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
<!-- PAGE-HEADER END -->

<div class=""row"">
    <div class=""col-md"">
        <div class=""card overflow-hidden"">
            <div class=""card-header"">
                <h3 class=""card-title"">Country Create</h3>
            </div>
            <div class=""card-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label class=""form-label"">Country Code &nbsp;<span style=""color: red;""><b>*</b></span></label>
                                <input type=""text"" class=""form-control"" id=""countrycode"" placeholder=""Enter Country Code "" required>
                            </div>
                        </div>
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label class=""form-label"">Country Name &nbsp;<");
            WriteLiteral(@"span style=""color: red;""><b>*</b></span></label>
                                <input type=""text"" class=""form-control"" id=""countryName"" placeholder=""Enter CountryName"" required>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <button type=""button"" id=""btncreate"" class=""btn btn-radius btn-success"">Create</button>
                        </div>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        //Create
        $(function () {

            $(""#btncreate"").click(function (e) {

                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                }
                else {
                    var model = {
                        countryCode: $.trim($(""#countrycode"").val()),
                        countryName: $.trim($(""#countryName"").val()),
                        createdBy: ");
#nullable restore
#line 73 "D:\Santosh\EOrderBook\AdminClient\Views\Country\CreateCountry.cshtml"
                              Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    console.log(model)\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 78 "D:\Santosh\EOrderBook\AdminClient\Views\Country\CreateCountry.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Country/CountryCreate\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 82 "D:\Santosh\EOrderBook\AdminClient\Views\Country\CreateCountry.cshtml"
                                                Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            if (xhr.status === 200) {

                                sweetAlert({
                                    html: true,
                                    icon: ""success"",
                                    title: ""Country"",
                                    text: ""Successfully created!"",
                                    type: ""success""
                                });
                            } else if (data.status === ""duplicate"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else if (data.status === ""error"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warnin");
                WriteLiteral(@"g"");
                            }
                        },
                        error: function (data) {
                            if (data.status == 401) {
                                window.location.replace('/Message/TokenExpire');
                            } else if (data.status == 403) {
                                window.location.replace('/Message/Unauthorize');
                            } else if (data.status == 400) {
                                sweetAlert(""Validation Alert!"", ""Please check input data!"", ""warning"");
                            }
                        }
                    });
                }
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
