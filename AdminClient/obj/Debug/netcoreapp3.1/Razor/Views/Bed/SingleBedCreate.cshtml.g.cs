#pragma checksum "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27681871ee5db971f0998223033541c4f8599274"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bed_SingleBedCreate), @"mvc.1.0.view", @"/Views/Bed/SingleBedCreate.cshtml")]
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
#line 1 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27681871ee5db971f0998223033541c4f8599274", @"/Views/Bed/SingleBedCreate.cshtml")]
    #nullable restore
    public class Views_Bed_SingleBedCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Bed/BedCreate"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-icon btn-sm text-white mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Bed/BedList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
  
    ViewBag.Title = "Bed";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i>Bed</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Bed Create</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27681871ee5db971f0998223033541c4f85992744758", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span>Prefix Bed Create\r\n        ");
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
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27681871ee5db971f0998223033541c4f85992746040", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span>Bed View\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
                <h3 class=""card-title"">Bed Create</h3>
            </div>
            <div class=""card-body"">
                <form action=""#"" name=""myForm"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Hospital &nbsp;<span style=""color: red;""><b>*</b></span></label>
                                <select class=""form-control"" id=""hospitalid"" disabled></select>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">No of Floor &nbsp;<span style=""color: red;""><b>*</b");
            WriteLiteral(@"></span></label>
                                <select class=""form-control"" id=""floorno"" readonly></select>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">

                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Select Floor &nbsp;<span style=""color: red;""><b>*</b></span></label>
                                <select class=""form-control"" id=""Floors"">
                                    <option value=""SelectFloor"">Select Floor</option>
                                    <option value=""GroundFloor"">Ground Floor</option>
                                    <option value=""FirstFloor"">First Floor</option>
                                    <option value=""SecondFloor"">Second Floor</option>
                                    <option value=""ThirdFloor"">Third Floor</option>
                                    <op");
            WriteLiteral(@"tion value=""FourthFloor"">Fourth Floor</option>
                                    <option value=""FifthFloor"">Fifth Floor</option>
                                    <option value=""SixthFloor"">Sixth Floor</option>
                                    <option value=""SeventhFloor"">Seventh Floor</option>
                                </select>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Bed No &nbsp;<span style=""color: red;""><b>*</b></span></label>
                                <input type=""text"" class=""form-control"" id=""bedno"" placeholder=""Bed No"">
                            </div>
                        </div>
                       
                    </div>
                    <br />
                    <br />
                    <div class=""table-responsive"">
                        <table id=""BEd"" class=""");
            WriteLiteral(@"table table-bordered table-hover mb-0"">
                            <thead>
                                <tr>
                                    <th>Hospital</th>
                                    <th>No of Floor</th>
                                    <th>Select Floor</th>
                                    <th>Bed Number</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody id=""Bed_tb"">
                            </tbody>
                        </table>
                    </div>
                    <br />
                    <br />
                    <br />
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <button type=""button"" id=""Add_Bed"" class=""btn btn-radius btn-info"" onclick=""validateForm()"">Add Bed</button>
                            <button type=""button"" id=""btnSave"" class=""btn btn-radius btn-su");
            WriteLiteral(@"ccess"">Save</button>
                            <a type=""button"" href=""/Bed/SingleBedCreate"" class=""btn btn-radius btn-danger"">Reset</a>

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

        $(function () {

            $(""#btnSave"").click(function (e) {

                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                }
                else {
                    var itemDeatils = [];
                    $.each($(""#BEd tbody tr""), function () {
                        var $irow = $(this),
                            rowObj = {};
                        var k = 0
                        var HospitalName;
                        var NoOf_Floor;
                        var FloorName;
                        var BedNo;
                        $.each($(""td"", $irow), function () {
                            var $col = $(this);

                            if (k == 0) {
                                HospitalName = parseInt($col.html())
                            }
                            if (k == 1) {
                                NoOf_Floor = parseInt($col.html())
            ");
                WriteLiteral(@"                }
                            if (k == 2) {
                                FloorName = $col.html()
                            }
                            if (k == 3) {
                                BedNo = $col.html()
                            }
                            k = k + 1
                        });
                        var a = {
                            ""hospitalMasterid"": parseInt($(""#hospitalid"").val()),
                            ""floorNoid"": parseInt($(""#floorno"").val()),
                            ""floorsName"": FloorName,
                            ""bedNo"": BedNo,
                        }
                        itemDeatils.push(a)
                    });

                    var model = {
                        bedDTOs: itemDeatils,
                        createdBy: ");
#nullable restore
#line 162 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                              Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 166 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Bed/CreateBed\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                            \"authorization\": \"Bearer ");
#nullable restore
#line 170 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
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
                                    title: ""Bed"",
                                    text: ""Successfully created!"",
                                    type: ""success""
                                });
                            } else if (data.status === ""duplicate"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else if (data.status === ""error"") {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");");
                WriteLiteral(@"
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

        GetHospitalList()
        function GetHospitalList(Id) {
            var opt = '';
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 210 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalByUserId/\" + ");
#nullable restore
#line 210 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                                                              Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                    \"authorization\": \"Bearer ");
#nullable restore
#line 213 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                                        Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (res) {
                    console.log(res)
                    var options = [];
                    for (var i = 0; i < res.data.length; i++) {
                        if (Id == res.data[i].hospitalMasterid) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].hospitalMasterid + '"" ' + opt + '>' + res.data[i].hospitalName + '</option>');
                    }
                    $(""#hospitalid"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
");
                WriteLiteral("                }\r\n            });\r\n        }\r\n\r\n        GetFloorList()\r\n        function GetFloorList(Id) {\r\n            var opt = \'\';\r\n            $.ajax({\r\n                type: \"GET\",\r\n                url: \"");
#nullable restore
#line 244 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetNoOfFloorByHospitalId/\" + ");
#nullable restore
#line 244 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                                                                   Write(Context.Session.GetInt32("HospitalMasterid"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                    \"authorization\": \"Bearer ");
#nullable restore
#line 247 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Bed\SingleBedCreate.cshtml"
                                        Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (res) {
                    console.log(res)
                    var options = [];
                    for (var i = 0; i < res.data.length; i++) {
                        if (Id == res.data[i].hospitalMasterid) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + res.data[i].hospitalMasterid + '"" ' + opt + '>' + res.data[i].nooffloor + '</option>');
                    }
                    $(""#floorno"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
      ");
                WriteLiteral(@"          }
            });
        }

        $(function () {
            $(""#Add_Bed"").click(function (e) {
                var x = $('#Bed_tb').html();
                var Hospital = $('#hospitalid option:selected').text();
                var Nooffloors = $('#floorno option:selected').text();
                var Foors = $('#Floors').val();
                var BedNo = $('#bedno').val();

                x = x + ""<tr><td>"" + Hospital + ""</td><td>"" + Nooffloors + ""</td><td>"" + Foors + ""</td><td>"" + BedNo + ""</td><td><button class='delRowBtn'>Delete</button></td></tr>""
                
                $('#Bed_tb').html(x);
                $(document.body).delegate("".delRowBtn"", ""click"", function () {
                    $(this).closest(""tr"").remove();
                });
            });
        });

        function validateForm() {
            var x = document.forms[""myForm""][""hospitalid""].value;
            if (x == """") {
                alert(""Plese Select Hospital"");
             ");
                WriteLiteral("   return false;\r\n            }\r\n        }\r\n    </script>\r\n");
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
