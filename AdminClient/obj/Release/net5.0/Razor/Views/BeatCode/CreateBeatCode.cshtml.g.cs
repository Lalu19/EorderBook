#pragma checksum "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e40fd847e9cf89e22e1edd3970e1824c23a71908"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BeatCode_CreateBeatCode), @"mvc.1.0.view", @"/Views/BeatCode/CreateBeatCode.cshtml")]
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
#line 1 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e40fd847e9cf89e22e1edd3970e1824c23a71908", @"/Views/BeatCode/CreateBeatCode.cshtml")]
    #nullable restore
    public class Views_BeatCode_CreateBeatCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/BeatCode/BeatCodeList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
  
    ViewBag.Title = "BeatCode";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Admin Consol</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">BeatCode Create</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e40fd847e9cf89e22e1edd3970e1824c23a719084429", async() => {
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
                <h3 class=""card-title"">BeatCode Create</h3>
            </div>
            <div class=""card-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label class=""form-label"">Area Name &nbsp;<span style=""color: red;""><b>*</b></span></label>
                                <div class=""input-box"">
                                    <select class=""form-control"" id=""selectarea"">
                                    </select>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-3"">
                            <div class=");
            WriteLiteral(@"""form-group"">
                                <label class=""form-label"">Beat Name &nbsp;<span style=""color: red;""><b>*</b></span></label>
                                <div class=""input-box"">
                                    <select class=""form-control"" id=""selectBeat"">
                                    </select>
                                </div>
                            </div>
                        </div>

                        <div class=""col-md-3"">
                            <div class=""form-group"">
                                <label class=""form-label"">Beat Code Name &nbsp;<span style=""color: red;""><b>*</b></span></label>
                                <input type=""text"" class=""form-control"" id=""beatcodename"" placeholder=""Enter Beatcode Name"" required>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12"">
                            <button ");
            WriteLiteral("type=\"button\" id=\"btncreate\" class=\"btn btn-radius btn-success\">Create</button>\r\n                        </div>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        GetArea()\r\n        async function GetArea(Id) {\r\n            var opt = \'\';\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"");
#nullable restore
#line 80 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
                 Write(apiUrl​);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/Area/GetAreaList"",
                contentType: ""application/json; charset=utf-8"",
                dataType: ""json"",
                success: function (res) {
                    var options = [];
                    options.push('<option value = """" > Select Area </option>');
                    for (var i = 0; i < res.data.length; i++) {
                        if (Id == res.data[i].areaId) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value = ""' + res.data[i].areaId + '"" ' + opt + ' > ' + res.data[i].areaName + '</option>');
                    }
                    $(""#selectarea"").html(options.join(''));
                },

                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
     ");
                WriteLiteral(@"                   window.location.replace('/Message/Unauthorize');
                    }
                }
            });
        }

        $(""#selectarea"").change(async function () {
            var areaId = $(""#selectarea"").val()
            var opt = '';
            $.ajax({
                type: ""POST"",
                url: '");
#nullable restore
#line 112 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/Beat/GetBeatListbyareaid/' + areaId,
                dataType: ""json"",
                success: function (data) {
                    var options = [];
                    options.push('<option value="""">Select Beat </option>');
                    console.log(data)
                    for (var i = 0; i < data['data'].length; i++) {
                        options.push('<option value=""' + data['data'][i].beatId + '"" ' + opt + '>' + data['data'][i].beatName + '</option>');
                    }
                    $(""#selectBeat"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
                }

            });

        });

        $(""#btncreate"").click(function (e) {
            if ");
                WriteLiteral(@"(!document.getElementById(""formPost"").checkValidity()) {
                e.preventDefault();
            } else {
                var model = {
                    areaId: parseInt($(""#selectarea"").val()),
                    beatId: parseInt($(""#selectBeat"").val()),
                    beatCodeName: $.trim($(""#beatcodename"").val()),
                    createdBy: ");
#nullable restore
#line 143 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
                          Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                };\r\n\r\n                console.log(model);\r\n\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
#nullable restore
#line 150 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/BeatCode/BeatCodeRepoCreate\",\r\n                    data: JSON.stringify(model),\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 154 "E:\Pravat Project\EOrderBook\AdminClient\Views\BeatCode\CreateBeatCode.cshtml"
                                            Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        if (xhr.status === 200) {
                            console.log(data);
                            sweetAlert({
                                html: true,
                                title: ""BeatCode Add"",
                                text: ""Successfully Created!"",
                                type: ""success""
                            });
                        } else if (data.status === ""duplicate"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else if (data.status === ""error"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else {
                            sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                        }
                    },
          ");
                WriteLiteral(@"          error: function (data) {
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
