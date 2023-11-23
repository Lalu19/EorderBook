#pragma checksum "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7398740ead870dd9d252269179671f9cf595dcc7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_MenuList), @"mvc.1.0.view", @"/Views/Menu/MenuList.cshtml")]
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
#line 1 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7398740ead870dd9d252269179671f9cf595dcc7", @"/Views/Menu/MenuList.cshtml")]
    #nullable restore
    public class Views_Menu_MenuList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
  
    ViewBag.Title = "Menu";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-pie-chart mr-1""></i> Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Menu</li>
    </ol>
    <div class=""ml-auto"">
        <a href=""#"" onclick=""showAddBtn()"" data-toggle=""modal"" data-target=""#menuModal"" class=""btn btn-primary btn-icon btn-sm text-white mr-2"">
            <span>
                <i class=""fe fe-plus""></i>
            </span> Create Menu
        </a>

    </div>
</div>



<div class=""col-md-12 col-lg-12"">
    <div class=""card"">
        <div class=""card-header"">
            <div class=""card-title"">Menu</div>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table id=""menuTable"" class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                    <thead>
                        <tr>
                        ");
            WriteLiteral(@"    <th>Menu Title</th>
                            <th>URL</th>
                            <th>Is Sub-Menu?</th>
                            <th>Parent</th>
                            <th>Order No.</th>
                            <th>Icon-Class</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
    </div>
</div>


<div id=""menuModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">

            </div>
            <div class=""modal-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    ");
            WriteLiteral(@"<div class=""form-group"">
                                        <label class=""control-label"">Menu Title<i class=""fas fa-exclamation-triangle text-danger fa-sm""></i></label>
                                        <input type=""text"" autocomplete=""off"" class=""form-control"" id=""menu"" required/>
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Parent Menu<i class=""fas fa-exclamation-triangle text-danger fa-sm""></i></label>
                                        <select id=""parentMenu"" class=""custom-select""></select>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-g");
            WriteLiteral(@"roup"">
                                        <label class=""control-label"">URL</label>
                                        <input type=""text"" autocomplete=""off"" class=""form-control"" id=""url"" />
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Is Sub-Menu?<i class=""fas fa-exclamation-triangle text-danger fa-sm""></i></label>
                                        <select id=""subMenu"" class=""custom-select"" required>
                                            <option value=""1"">Yes</option>
                                            <option value=""0"">No</option>
                                        </select>
                                    </div>
                                </div>
                            </div>
                            <div class=""row"" id=""par");
            WriteLiteral(@"entMenuCheck"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Order No.<i class=""fas fa-exclamation-triangle text-danger fa-sm""></i></label>
                                        <input type=""number"" autocomplete=""off"" class=""form-control"" id=""orderNo"" required />
                                    </div>
                                </div>
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Icon Class(fontawesome icon)</label>
                                        <input type=""text"" autocomplete=""off"" class=""form-control"" id=""icon"" />
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                         ");
            WriteLiteral(@"       <div class=""col-lg-6"">
                                    <button type=""button"" id=""btnSave"" class=""btn btn-radius btn-success"" style=""display:none"">Save</button>
                                    <button type=""button"" id=""btnUpdate"" class=""btn btn-radius btn-success"" style=""display:none"">Update</button>
                                </div>
                            </div>
                        </div>
                    </div>
                </form>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
            </div>
        </div>

    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        var menuIdForUpdate;

       
        $(function () {
            loadMenus();
            $('#menuTable tbody').on('click', 'button[data-target=""#menuModal""]', function () {
                var id = $(this).data('id');
                loadSingleMenu(id);
                $('#btnUpdate').show();
                $('#btnSave').hide();
                menuIdForUpdate = id;
            });
            $('#menuTable tbody').on('click', 'button[data-target=""#delete""]', function () {
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
             ");
                WriteLiteral("       $.ajax({\r\n                        type: \"GET\",\r\n                        url: \"");
#nullable restore
#line 157 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/DeleteSingleMenu/\" + id,\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                           \"authorization\": \"Bearer ");
#nullable restore
#line 160 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                                               Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            if (xhr.status == 200) {
                                $('#menuTable').DataTable().ajax.reload(null, false);
                                sweetAlert({
                                    html: true,
                                    title: ""Menu"",
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
                            if");
                WriteLiteral(@" (data.status == 401) {
                                window.location.replace('/Message/TokenExpire');
                            } else if (data.status == 403) {
                                window.location.replace('/Message/Unauthorize');
                            }
                        }
                    });
                });
            });
            $(""#btnSave"").click(function (e) {
                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                } else {
                        var model = {
                            parentID: parseInt($(""#parentMenu"").val()),
                            isSubMenu: parseInt($(""#subMenu"").val()),
                            menuTitle: $.trim($(""#menu"").val()),
                            sortOrder: parseInt($(""#orderNo"").val()),
                            iconClass: $.trim($(""#icon"").val()),
                            url: $.trim($(""#url"").val()),
               ");
                WriteLiteral("             addedBy:");
#nullable restore
#line 199 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                               Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                        }\r\n                    console.log(model);\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
#nullable restore
#line 204 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/CreateMenu\",\r\n                    data: JSON.stringify(model),\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                           \"authorization\": \"Bearer ");
#nullable restore
#line 208 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                                               Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        //console.log(xhr.status);
                        console.log(data);
                        if (xhr.status === 200) {
                            $('#menuTable').DataTable().ajax.reload(null, false);
                            sweetAlert({
                                html: true,
                                title: ""Menu"",
                                text: ""Successfully created!"",
                                type: ""success""
                                });
                        } else if (data.status === ""duplicate"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        } else if (data.status === ""error"") {
                            sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                        }else{
                            sweetA");
                WriteLiteral(@"lert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                        }
                    },
                    error: function (data) {
                        if (data.status == 401) {
                            window.location.replace('/Message/TokenExpire');
                        } else if (data.status == 403) {
                            window.location.replace('/Message/Unauthorize');
                        }else if (data.status == 400) {
                            sweetAlert(""Validation Alert!"", ""Please check input data!"", ""warning"");
                        }
                    }
                    });
                }
            });
            $(""#btnUpdate"").click(function (e) {
                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                } else {
                        var model = {
                            menuID: menuIdForUpdate,
                            parentID: pars");
                WriteLiteral(@"eInt($(""#parentMenu"").val()),
                            isSubMenu: parseInt($(""#subMenu"").val()),
                            menuTitle: $.trim($(""#menu"").val()),
                            sortOrder: parseInt($(""#orderNo"").val()),
                            iconClass: $.trim($(""#icon"").val()),
                            url: $.trim($(""#url"").val()),
                            lastUpdatedBy:");
#nullable restore
#line 254 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                                     Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                    }\r\n                    console.log(model);\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 259 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/UpdateMenu\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                           \"authorization\": \"Bearer ");
#nullable restore
#line 263 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                                               Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            //console.log(xhr.status);
                            //console.log(statusText);
                            if (xhr.status==200) {
                                $('#menuTable').DataTable().ajax.reload(null, false);
                                    sweetAlert({
                                        html: true,
                                        title: ""Menu"",
                                        text: ""Successfully updated!"",
                                        type: ""success""
                                    });
                            } else if (xhr.status == 202) {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
     ");
                WriteLiteral(@"                       }
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
        function loadSingleMenu(id) {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 299 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/GetSingleMenu/\" + id,\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                           \"authorization\": \"Bearer ");
#nullable restore
#line 302 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                                               Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (data) {
                    //console.log(data);
                    if (data){
                        $('#menu').val(data.menuTitle);
                        $('#url').val(data.url);
                        $('#subMenu').val(data.isSubMenu);
                        $('#orderNo').val(data.sortOrder);
                        $('#icon').val(data.iconClass);
                        parentMenuList(data.parentID);
                        iconAddRemove(data.parentID)
                    } else {
                        sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                    }
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize'");
                WriteLiteral(@");
                    }
                }
            });
        }
        function loadMenus() {
            var table = $('#menuTable').DataTable();
            table.destroy();
            table = $('#menuTable').dataTable({
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
#line 340 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/GetMenuList\',\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 344 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
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
                    { ""data"": ""menuTitle"", ""orderable"": true },
                    { ""data"": ""url"", ""orderable"": true },
                    {
                        ""data"": ""isSubMenu"",""orderable"": true,
                        ""render"": function (data, type, row) {
                            return row.isSubMenu===1?'Yes':'No'
                        }
                    },
                    {
                        ""data"": ""parentMenuName"", ""orderable"": true,
                        ""render"": function (data, type, row) {
      ");
                WriteLiteral(@"                      return row.parentMenuName === null ? 'Root' : row.parentMenuName
                        }
                    },
                    {
                        ""data"": ""sortOrder"", ""orderable"": true,
                        ""render"": function (data, type, row) {
                            return row.sortOrder===0?'':row.sortOrder
                        }
                    },
                    { ""data"": ""iconClass"", ""orderable"": true },
                    {
                        ""orderable"": false,
                        ""class"": ""action_button"",
                        ""render"": function (data, type, row) {
                            var id = row.menuID;
                            var actionButtonsHtml = """";
                            actionButtonsHtml += generateActionButtonForList(id, 'menuModal');
                            return actionButtonsHtml;
                        }
                    }
                ]
            });
        }
        ");
                WriteLiteral("function parentMenuList(id) {\r\n            var opt = \'\';\r\n            $.ajax({\r\n                type: \"GET\",\r\n                url: \"");
#nullable restore
#line 394 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/GetParentMenuList\",\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                           \"authorization\": \"Bearer ");
#nullable restore
#line 397 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuList.cshtml"
                                               Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (data) {
                    var options = [];
                    options.push('<option value=""0"">Root</option>');
                    for (var i = 0; i < data.length; i++) {
                        if (id == data[i].menuID) {
                            opt = 'selected'
                        } else {
                            opt = '';
                        }
                        options.push('<option value=""' + data[i].menuID + '"" ' + opt + '>' + data[i].menuTitle+ '</option>');
                    }
                    $(""#parentMenu"").html(options.join(''));
                },
                error: function (data) {
                    if (data.status == 401) {
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.location.replace('/Message/Unauthorize');
                    }
       ");
                WriteLiteral(@"         }
            });
        }
        function showAddBtn() {
            parentMenuList('');
            $('#btnSave').show();
            $('#btnUpdate').hide();
            resetInput('#menuModal');
            $('#parentMenuCheck').show();
            $('#icon').prop('required', true);
            $('#orderNo').val(0);
            $('#subMenu').val(1);
            $('#subMenu').prop('disabled', false);
        }
        function iconAddRemove(val) {
            if (val == 0) {
                $('#parentMenuCheck').show();
                $('#icon').prop('required', true);
                $('#subMenu').val(1);
                $('#subMenu').prop('disabled', false);
            } else {
                $('#icon').prop('required', false);
                $('#parentMenuCheck').hide();
                $('#orderNo').val(0);
                $('#icon').val('');
                $('#subMenu').val(0);
                $('#subMenu').prop('disabled',true);
            }
        }
    ");
                WriteLiteral("    $(\'#parentMenu\').on(\'change\', function () {\r\n            var value = $(\'#parentMenu\').val();\r\n            iconAddRemove(value);\r\n        });\r\n    </script>\r\n");
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
