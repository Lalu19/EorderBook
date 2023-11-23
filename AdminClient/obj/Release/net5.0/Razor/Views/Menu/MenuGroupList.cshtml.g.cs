#pragma checksum "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bdb796fbee0e2a8964f285ca60a6a36836aa557"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_MenuGroupList), @"mvc.1.0.view", @"/Views/Menu/MenuGroupList.cshtml")]
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
#line 1 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdb796fbee0e2a8964f285ca60a6a36836aa557", @"/Views/Menu/MenuGroupList.cshtml")]
    #nullable restore
    public class Views_Menu_MenuGroupList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
  
    ViewBag.Title = "Menu Group";
    string apiUrl = Configuration.GetValue<string>("WebAPIBaseUrl");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header"">
    <ol class=""breadcrumb"">
        <li class=""breadcrumb-item""><a href=""#""><i class=""fe fe-pie-chart mr-1""></i> Admin Console</a></li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Menu Groups</li>
    </ol>
    <div class=""ml-auto"">
        <a href=""#"" onclick=""showAddBtn()"" data-toggle=""modal"" data-target=""#menuGrpModal"" class=""btn btn-primary btn-icon btn-sm text-white mr-2"">
            <span>
                <i class=""fe fe-plus""></i>
            </span> Create Menu Group
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

                <table id=""menuGrpTable"" class=""table table-striped table-bordered nowrap dataTable no-footer dtr-inline"" style=""width:100%"">
                    <thead>
                        <tr>
         ");
            WriteLiteral(@"                   <th>Menu Group</th>
                            <th>Actions</th>
                        </tr>
                    </thead>
                </table>
                
            </div>
        </div>
    </div>
</div>


<div id=""menuGrpModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
            <div class=""modal-header"">

            </div>
            <div class=""modal-body"">
                <form action=""#"" role=""form"" class=""validate"" id=""formPost"">
                    <div class=""row"">
                        <div class=""col-lg-12"">
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <label class=""control-label"">Menu Group</label>
                                        <input type=""text"" autocomplete=""off"" class=""form-control"" id=""menuGroup"" req");
            WriteLiteral(@"uired />
                                    </div>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <button type=""button"" id=""btnSave"" class=""btn btn-primary"" style=""display:none"">Save</button>
                                    <button type=""button"" id=""btnUpdate"" class=""btn btn-primary"" style=""display:none"">Update</button>
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


<div id=""menuAssignModal"" class=""modal fade"" role=""dialog"">
    <div class=""modal-dialog modal-lg"">
        <div class=""modal-content"">
    ");
            WriteLiteral(@"        <div class=""modal-header"">

            </div>
            <div class=""modal-body"">
                <div id=""menuList""></div>
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
        var menuGrpIdForUpdate;

        $(function () {
            loadMenuGrp();

            $('#menuGrpTable tbody').on('click', 'button[data-target=""#menuGrpModal""]', function () {
                var id = $(this).data('id');
                loadSingleMenuGroup(id);
                $('#btnUpdate').show();
                $('#btnSave').hide();
                menuGrpIdForUpdate = id;
            });

            $('#menuGrpTable tbody').on('click', 'button[data-target=""#delete""]', function () {
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
                }, function ");
                WriteLiteral("() {\r\n                    $.ajax({\r\n                        type: \"GET\",\r\n                        url: \"");
#nullable restore
#line 131 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/DeleteSingleMenuGroup/\" + id,\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                           \"authorization\": \"Bearer ");
#nullable restore
#line 134 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                                               Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                        },
                        dataType: ""json"",
                        success: function (data, statusText, xhr) {
                            if (xhr.status == 200) {
                                $('#menuGrpTable').DataTable().ajax.reload(null, false);
                                sweetAlert({
                                    html: true,
                                    title: ""Menu"",
                                    text: ""Successfully deleted!"",
                                    type: ""success""
                                });
                            }else if (xhr.status == 202) {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            }else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
                            }
                        },
                        error: function (data) {
                            i");
                WriteLiteral(@"f (data.status == 401) {
                                window.location.replace('/Message/TokenExpire');
                            } else if (data.status == 403) {
                                window.location.replace('/Message/Unauthorize');
                            }
                        }
                    });
                });
            });

            $('#menuGrpTable tbody').on('click', 'button[data-target=""#menuAssignModal""]', function () {
                var id = $(this).data('id');
                menuGrpIdForUpdate = id;
                //console.log(id);
                $('#menuList').html('');
                $.ajax({
                    type: ""GET"",
                    url: """);
#nullable restore
#line 170 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/GetMenuAccessList/\" + id,\r\n                    contentType: \"text/plain; charset=utf-8\",\r\n                    headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 173 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""text"",
                    success: function (data, statusText, xhr) {
                        //console.log(data);
                        if (data){
                            $('#menuList').append(data);
                        }else {
                            sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
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

            });

         ");
                WriteLiteral(@"   $(""#btnSave"").click(function (e) {
                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                } else {
                        var model = {
                            menuGroupName: $.trim($(""#menuGroup"").val()),
                            isActive: true,
                            addedBy:");
#nullable restore
#line 204 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                               Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                        }\r\n                    console.log(model);\r\n\r\n                $.ajax({\r\n                    type: \"POST\",\r\n                    url: \"");
#nullable restore
#line 210 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                     Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/CreateMenuGroup\",\r\n                    data: JSON.stringify(model),\r\n                    contentType: \"application/json; charset=utf-8\",\r\n                    headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 214 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                    },
                    dataType: ""json"",
                    success: function (data, statusText, xhr) {
                        console.log(xhr.status);
                        console.log(data);
                        if (xhr.status === 200) {
                            $('#menuGrpTable').DataTable().ajax.reload(null, false);
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
                        }else {
                                ");
                WriteLiteral(@"sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
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

            $(""#btnUpdate"").click(function (e) {
                if (!document.getElementById(""formPost"").checkValidity()) {
                    e.preventDefault();
                } else {
                        var model = {
                            menuGroupID: menuGrpIdForUpdate,
                     ");
                WriteLiteral("       menuGroupName: $.trim($(\"#menuGroup\").val()),\r\n                            lastUpdatedBy:");
#nullable restore
#line 256 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                                     Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n                        }\r\n                    $.ajax({\r\n                        type: \"POST\",\r\n                        url: \"");
#nullable restore
#line 260 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                         Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/UpdateMenuGroup\",\r\n                        data: JSON.stringify(model),\r\n                        contentType: \"application/json; charset=utf-8\",\r\n                        headers: {\r\n                           \"authorization\": \"Bearer ");
#nullable restore
#line 264 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
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
                                $('#menuGrpTable').DataTable().ajax.reload(null, false);
                                    sweetAlert({
                                        html: true,
                                        title: ""Menu"",
                                        text: ""Successfully updated!"",
                                        type: ""success""
                                    });
                            }else if (xhr.status == 202) {
                                sweetAlert(""Validation Alert!"", data.responseMsg, ""warning"");
                            } else {
                                sweetAlert(""Validation Alert!"", ""Something unexpected!"", ""warning"");
   ");
                WriteLiteral(@"                         }
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

        function loadSingleMenuGroup(id) {
            $.ajax({
                type: ""GET"",
                url: """);
#nullable restore
#line 301 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/GetSingleMenuGroup/\" + id,\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 304 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
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
                        $('#menuGroup').val(data.menuGroupName);
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

        function loadMenuGrp() {
            var table = $('#menuGrpTable').DataTable();
            table.destroy();

            table = $('#menuGrpTable').dataTable({
                ""paginationType"": ""full_numbers"",
                ""dom"": 'B");
                WriteLiteral(@"frtip',
                ""buttons"": ['copy', 'csv', 'excel', 'pdf', 'print'],
                ""searching"": true,
                ""paging"": true,
                ""sort"": true,
                ""info"": true,
                ""ajax"": {
                    ""url"": '");
#nullable restore
#line 338 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                       Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/GetMenuGroupList\',\r\n                    \"type\": \"GET\",\r\n                    \"dataType\": \"json\",\r\n                    \"headers\": {\r\n                        \"authorization\": \"Bearer ");
#nullable restore
#line 342 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
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
                    { ""data"": ""menuGroupName"", ""orderable"": true },
                    {
                        ""orderable"": false,
                        ""class"": ""action_button"",
                        ""render"": function (data, type, row) {
                            var id = row.menuGroupID;
                            var actionButtonsHtml = """";
                            actionButtonsHtml += generateActionButtonForList(id, 'menuGrpModal');
                            return actionButtonsHtml;
                        }
         ");
                WriteLiteral(@"           }
                ]
            });
        }

        function menuManipulate(attr) {
            var menuId = attr.id;
            var opt = '';
            if ($(attr).prop('checked') == true) {
                opt = 'insert';
            } else if ($(attr).prop('checked')==false) {
                opt = 'delete';
            }
            var model ={
                menuGroupId: menuGrpIdForUpdate,
                menuId: parseInt(menuId),
                operation:opt,
                addedBy:");
#nullable restore
#line 381 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                   Write(Context.Session.GetInt32("UserId"));

#line default
#line hidden
#nullable disable
                WriteLiteral(",\r\n            }\r\n            console.log(model);\r\n            $.ajax({\r\n                type: \"POST\",\r\n                url: \"");
#nullable restore
#line 386 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                 Write(apiUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral("/api/Menu/MenuAssign\",\r\n                data: JSON.stringify(model),\r\n                contentType: \"application/json; charset=utf-8\",\r\n                headers: {\r\n                       \"authorization\": \"Bearer ");
#nullable restore
#line 390 "E:\Pravat Project\EOrderBook\AdminClient\Views\Menu\MenuGroupList.cshtml"
                                           Write(Context.Session.GetString("TokenTxt"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
                },
                dataType: ""json"",
                success: function (data, statusText, xhr) {
                    //console.log(data);
                    if (xhr.status === 200) {
                        sweetAlert({
                            html: true,
                            title: ""Menu"",
                            text: ""Successfully Assigned!"",
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
                        window.location.replace('/Message/TokenExpire');
                    } else if (data.status == 403) {
                        window.loc");
                WriteLiteral(@"ation.replace('/Message/Unauthorize');
                    }
                }
            });

        }

        function showAddBtn() {
            $('#btnSave').show();
            $('#btnUpdate').hide();
           // resetInput('#menuGrpModal');
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
