#pragma checksum "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7dddf23a26ca5d256947b1f6fad94d256aafbe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Diet_DietEdit), @"mvc.1.0.view", @"/Views/Diet/DietEdit.cshtml")]
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
#line 1 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7dddf23a26ca5d256947b1f6fad94d256aafbe8", @"/Views/Diet/DietEdit.cshtml")]
    #nullable restore
    public class Views_Diet_DietEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Diet/DietList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
  
    ViewBag.Title = "Diet";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- PAGE-HEADER -->
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-file-text mr-1""></i> Forms</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Form-Elements</li>
    </ol>
    <div class=""ml-auto"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7dddf23a26ca5d256947b1f6fad94d256aafbe84363", async() => {
                WriteLiteral("\r\n            <span>\r\n                <i class=\"fe fe-plus\"></i>\r\n            </span> Diet List\r\n        ");
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
                <h3 class=""card-title"">Diet Create</h3>
            </div>
            <div class=""card-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""form-label"">Patient Name</label>
                                <input type=""text"" class=""form-control"" id=""patientname"" placeholder=""Patient Name"">
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">IP No</label>
                                <input type=""text"" class=""form-control"" id=""ipno"" placeholder=""IP No"">
                            </div>
            ");
            WriteLiteral(@"                
                            <div class=""form-group"">
                                <div class=""form-group overflow-hidden"">
                                    <label class=""form-label"">Select Floor</label>
                                    <select class=""form-control"" id=""Floors"">
                                        <option value=""SelectFloor"">Select Floor</option>
                                        <option value=""GroundFloor"">Ground Floor</option>
                                        <option value=""FirstFloor"">First Floor</option>
                                        <option value=""SecondFloor"">Second Floor</option>
                                        <option value=""ThirdFloor"">Third Floor</option>
                                        <option value=""FourthFloor"">Fourth Floor</option>
                                        <option value=""FifthFloor"">Fifth Floor</option>
                                        <option value=""SixthFloor"">Sixth Floor</opti");
            WriteLiteral(@"on>
                                        <option value=""SeventhFloor"">Seventh Floor</option>
                                    </select>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <div class=""form-group overflow-hidden"">
                                    <label class=""form-label"">Bed No</label>
                                    <select class=""form-control"" id=""bedno""></select>
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Hospital</label>
                                <select class=""form-control"" id=""hospitalid""></select>
                            </div>
                        </div>
                        <div class=""col-md-6"">
                            <div class=""form-group"">
                                <label class=""");
            WriteLiteral(@"form-label"">Type Of Patient</label>
                                <select id=""TypeofPatient"" class=""form-control"">
                                </select>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Service Type</label>
                                <select class=""form-control"" id=""servicetype"">
                                </select>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Diet Type</label>
                                <select id=""Diettype"" class=""form-control"">
                                </select>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Plan Status</label>
                                <select class=""form-control"" id=""planstatus"">
                                  ");
            WriteLiteral(@"  <option value=""On-Bed"">On-Bed</option>
                                    <option value=""Plan Discharge"">Plan Discharge</option>
                                </select>
                            </div>
                            <div class=""form-group"">
                                <label class=""form-label"">Special Instruction</label>
                                <textarea type=""text"" class=""form-control"" id=""specification"" placeholder=""Special Instruction..""></textarea>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-md-12 text-center"">
                            <button type=""button"" id=""btnSave"" class=""btn btn-radius btn-success"">Create New</button>
                            <button type=""button"" id=""btnUpdate"" class=""btn btn-radius btn-success"">Update</button>
                            <a type=""button"" href=""/Diet/DietCreate"" class=""btn btn-radius btn-");
            WriteLiteral("danger\">Reset</a>\r\n                        </div>\r\n                    </div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n<script>\r\n    var dietMasterId = ");
#nullable restore
#line 115 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                  Write(ViewBag.dietMasterId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    loadSingleDiet()\r\n    function loadSingleDiet() {\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \"");
#nullable restore
#line 120 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DIETMaster/GetSingleDietId/\" + dietMasterId,\r\n            contentType: \"application/json; charset=utf-8\",\r\n            headers: {\r\n                \"authorization\": \"Bearer ");
#nullable restore
#line 123 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                                    Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
            },
            dataType: ""json"",
            success: function (data) {
                //console.log(data);
                if (data) {
                    $('#patientname').val(data.patientName);
                    $('#ipno').val(data.ip);
                    HospitalList(data.hospitalMasterid);
                    GetBedList(data.bedId);
                    $('#Floors').val(data.floorsName);
                    PatientList(data.patientTypeId);
                    ServiceTypeList(data.foodServiceTypeId);
                    GetDietList(data.dietTypeId);
                    $('#planstatus').val(data.patientStatus);
                    $('#specification').val(data.specialInstruction);
                }
                else {
                    sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                }
            },
            error: function (data) {
                if (data.status == 401) {
                    window.location.replace('/Mess");
                WriteLiteral(@"age/TokenExpire');
                } else if (data.status == 403) {
                    window.location.replace('/Message/Unauthorize');
                }
            }
        });
    }

    function HospitalList(Id) {
        var opt = '';
        $.ajax({
            type: ""GET"",
            url: """);
#nullable restore
#line 158 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Hospital/GetHospitalByUserId/\" + ");
#nullable restore
#line 158 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                                                          Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n            contentType: \"application/json; charset=utf-8\",\r\n            headers: {\r\n                \"authorization\": \"Bearer ");
#nullable restore
#line 161 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
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
                options.push('<option value="""">Select Hospital</option>');
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
                WriteLiteral("    }\r\n        });\r\n    }\r\n\r\n    $(\"#Floors\").change(function () {\r\n        var hospitalMasterid = $(\"#hospitalid\").val()\r\n        Floors = $(\"#Floors\").val()\r\n        var opt = \'\';\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \'");
#nullable restore
#line 194 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/api/Bed/GetBedByFloorName/' + Floors + '/' + hospitalMasterid,
            dataType: ""json"",
            success: function (data) {
                var options = [];
                console.log(data)
                options.push('<option>Select Bed </option>');
                for (var i = 0; i < data['data'].length; i++) {

                    options.push('<option value=""' + data['data'][i].bedMasterId + '"" ' + opt + '>' + data['data'][i].bedNo + '</option>');
                }
                $(""#bedno"").html(options.join(''));

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

    function PatientList(Id) {
        var opt = '';
        $.ajax({
            type: ""GET"",
            url: """);
#nullable restore
#line 221 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/PatientType/GetPatientTypeList\",\r\n            contentType: \"application/json; charset=utf-8\",\r\n            headers: {\r\n                \"authorization\": \"Bearer ");
#nullable restore
#line 224 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                                    Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
            },
            dataType: ""json"",
            success: function (res) {
                var options = [];
                options.push('<option value="""">Select Type of Patient</option>');
                for (var i = 0; i < res.data.length; i++) {
                    if (Id == res.data[i].patientTypeId) {
                        opt = 'selected'
                    } else {
                        opt = '';
                    }
                    options.push('<option value=""' + res.data[i].patientTypeId + '"" ' + opt + '>' + res.data[i].typeOfPatient + '</option>');
                }
                $(""#TypeofPatient"").html(options.join(''));
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

");
                WriteLiteral("    function ServiceTypeList(Id) {\r\n        var opt = \'\';\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \"");
#nullable restore
#line 254 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/FoodServiceType/GetFoodServiceTypeList\",\r\n            contentType: \"application/json; charset=utf-8\",\r\n            headers: {\r\n                \"authorization\": \"Bearer ");
#nullable restore
#line 257 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                                    Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
            },
            dataType: ""json"",
            success: function (res) {
                var options = [];
                options.push('<option value="""">Select Service Type</option>');
                for (var i = 0; i < res.data.length; i++) {
                    if (Id == res.data[i].foodServiceTypeId) {
                        opt = 'selected'
                    } else {
                        opt = '';
                    }
                    options.push('<option value=""' + res.data[i].foodServiceTypeId + '"" ' + opt + '>' + res.data[i].foodServiceTypeName + '</option>');
                }
                $(""#servicetype"").html(options.join(''));
            },
            error: function (data) {
                if (data.status == 401) {
                    window.location.replace('/Message/TokenExpire');
                } else if (data.status == 403) {
                    window.location.replace('/Message/Unauthorize');
                }
            }
        });
");
                WriteLiteral("    }\r\n\r\n    function GetDietList(Id) {\r\n        var opt = \'\';\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \"");
#nullable restore
#line 287 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DietType/GetDietTypeList\",\r\n            contentType: \"application/json; charset=utf-8\",\r\n            headers: {\r\n                \"authorization\": \"Bearer ");
#nullable restore
#line 290 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                                    Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
            },
            dataType: ""json"",
            success: function (res) {
                
                var options = [];
                options.push('<option value="""">Select Diet Type</option>');
                for (var i = 0; i < res.data.length; i++) {
                    if (Id == res.data[i].dietTypeId) {
                        opt = 'selected'
                    } else {
                        opt = '';
                    }
                    options.push('<option value=""' + res.data[i].dietTypeId + '"" ' + opt + '>' + res.data[i].dietTypeName + '</option>');
                }
                $(""#Diettype"").html(options.join(''));
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

");
                WriteLiteral("    function GetBedList(Id) {\r\n        var opt = \'\';\r\n        $.ajax({\r\n            type: \"GET\",\r\n            url: \"");
#nullable restore
#line 321 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
             Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Bed/GetBedList\",\r\n            contentType: \"application/json; charset=utf-8\",\r\n            headers: {\r\n                \"authorization\": \"Bearer ");
#nullable restore
#line 324 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
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
                options.push('<option value="""">Select Bed</option>');
                for (var i = 0; i < res.data.length; i++) {
                    if (Id == res.data[i].bedMasterId) {
                        opt = 'selected'
                    } else {
                        opt = '';
                    }
                    options.push('<option value=""' + res.data[i].bedMasterId + '"" ' + opt + '>' + res.data[i].bedNo + '</option>');
                }
                $(""#bedno"").html(options.join(''));
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
");
                WriteLiteral(@"
    $(function () {

        $(""#btnSave"").click(function (e) {

            if (!document.getElementById(""formPost"").checkValidity()) {
                e.preventDefault();
            }
            else {
                var model = {
                    patientName: $.trim($(""#patientname"").val()),
                    hospitalMasterid: parseInt($(""#hospitalid"").val()),
                    floorsName: $.trim($(""#Floors"").val()),
                    bedId: parseInt($(""#bedno"").val()),
                    patientTypeId: parseInt($(""#TypeofPatient"").val()),
                    foodServiceTypeId: parseInt($(""#servicetype"").val()),
                    dietTypeId: parseInt($(""#Diettype"").val()),
                    specialInstruction: $.trim($(""#specification"").val()),
                    ip: $.trim($(""#ipno"").val()),
                    patientStatus: $.trim($(""#planstatus"").val()),
                    createdBy: ");
#nullable restore
#line 370 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                          Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                }\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
#nullable restore
#line 374 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DIETMaster/CreateDiet\",\r\n                    data: JSON.stringify(model),\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 378 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
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
                                title: ""Diet"",
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
                WriteLiteral(@"    error: function (data) {
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

    $(function () {

            $(""#btnUpdate"").click(function (e) {

            if (!document.getElementById(""formPost"").checkValidity()) {
                e.preventDefault();
            }
            else {
                var model = {
                    dietMasterId: dietMasterId,
                    patientName: $.trim($(""#patientname"").val()),
                    hospitalMasterid: parseInt($(""#hospitalid"").val()),
                    ");
                WriteLiteral(@"floorsName: $.trim($(""#Floors"").val()),
                    bedId: parseInt($(""#bedno"").val()),
                    patientTypeId: parseInt($(""#TypeofPatient"").val()),
                    foodServiceTypeId: parseInt($(""#servicetype"").val()),
                    dietTypeId: parseInt($(""#Diettype"").val()),
                    specialInstruction: $.trim($(""#specification"").val()),
                    ip: $.trim($(""#ipno"").val()),
                    patientStatus: $.trim($(""#planstatus"").val()),
                    updatedBy: ");
#nullable restore
#line 432 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                          Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                }\r\n                console.log(model)\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
#nullable restore
#line 437 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/DIETMaster/UpdateDiet\",\r\n                    data: JSON.stringify(model),\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 441 "E:\Pravat Project\Yatris\AdminConsole\AdminClient\Views\Diet\DietEdit.cshtml"
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
                                title: ""Diet"",
                                text: ""Successfully Updated!"",
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
                WriteLiteral(@"    error: function (data) {
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
