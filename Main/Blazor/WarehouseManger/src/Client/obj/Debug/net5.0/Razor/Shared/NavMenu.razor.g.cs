#pragma checksum "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13fe329992936df43dc042aa20c7df1f7af00ef8"
// <auto-generated/>
#pragma warning disable 1591
namespace WarehouseManger.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using Blazored.FluentValidation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Roles;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.RoleClaims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Identity.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Preferences;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Interceptors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Catalog.Brand;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Communication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Audit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.Document;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Managers.Misc.DocumentType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Shared.Constants.Permission;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Shared.Dialogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Settings;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Application.Requests.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Pages.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Infrastructure.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
using WarehouseManger.Client.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class NavMenu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::WarehouseManger.Client.Shared.Components.UserCard>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenComponent<global::MudBlazor.MudNavMenu>(2);
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(4);
                __builder2.AddAttribute(5, "Href", "/");
                __builder2.AddAttribute(6, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 6 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 6 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                         Icons.Material.Outlined.Home

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(8, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 6 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(9, _localizer["Home"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 7 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
     if (_canViewHangfire)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(10);
                __builder2.AddAttribute(11, "Href", "/jobs");
                __builder2.AddAttribute(12, "Target", "_blank");
                __builder2.AddAttribute(13, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 9 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                        Icons.Material.Outlined.Work

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 10 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(15, _localizer["Hangfire"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 12 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(16);
                __builder2.AddAttribute(17, "Href", "https://codewithmukesh.com/blog/blazor-hero-quick-start-guide/");
                __builder2.AddAttribute(18, "Target", "_blank");
                __builder2.AddAttribute(19, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 13 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                                                                             Icons.Material.Outlined.ReadMore

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 14 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(21, _localizer["Quick Start Guide"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(23);
                __builder2.AddAttribute(24, "Href", "/swagger/index.html");
                __builder2.AddAttribute(25, "Target", "_blank");
                __builder2.AddAttribute(26, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 16 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                                  Icons.Material.Outlined.LiveHelp

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 17 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(28, _localizer["Swagger"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(30);
                __builder2.AddAttribute(31, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(32, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 19 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(33, _localizer["Personal"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 20 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
     if (_canViewDashboards)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(34);
                __builder2.AddAttribute(35, "Href", "/dashboard");
                __builder2.AddAttribute(36, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 22 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                             Icons.Material.Outlined.Dashboard

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 23 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(38, _localizer["Dashboard"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 25 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(39);
                __builder2.AddAttribute(40, "Href", "/account");
                __builder2.AddAttribute(41, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 26 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                       Icons.Material.Outlined.SupervisorAccount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 27 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(43, _localizer["Account"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 29 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
     if (_canViewAuditTrails)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(44);
                __builder2.AddAttribute(45, "Href", "/audit-trails");
                __builder2.AddAttribute(46, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 31 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                Icons.Material.Outlined.Security

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 32 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(48, _localizer["Audit Trails"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 34 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
     if (_canViewDocuments || _canViewDocumentTypes)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(49);
                __builder2.AddAttribute(50, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(51, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 37 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(52, _localizer["Document Management"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 38 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         if (_canViewDocuments)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(53);
                __builder2.AddAttribute(54, "Href", "/document-store");
                __builder2.AddAttribute(55, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 40 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.AttachFile

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 41 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(57, _localizer["Document Store"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 43 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         if (_canViewDocumentTypes)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(58);
                __builder2.AddAttribute(59, "Href", "/document-types");
                __builder2.AddAttribute(60, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 46 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.FileCopy

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 47 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(62, _localizer["Document Types"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 49 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
     if (_canViewUsers || _canViewRoles)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(63);
                __builder2.AddAttribute(64, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(65, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 54 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(66, _localizer["Administrator"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 55 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         if (_canViewUsers)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(67);
                __builder2.AddAttribute(68, "Href", "/identity/users");
                __builder2.AddAttribute(69, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 57 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 58 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(71, _localizer["Users"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 60 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         if (_canViewRoles)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(72);
                __builder2.AddAttribute(73, "Href", "/identity/roles");
                __builder2.AddAttribute(74, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 63 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.Person

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(75, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 63 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(76, _localizer["Roles"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 64 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
     if (_canViewChat)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(77);
                __builder2.AddAttribute(78, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(79, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 68 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(80, _localizer["Communication"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(82);
                __builder2.AddAttribute(83, "Href", "/chat");
                __builder2.AddAttribute(84, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 69 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                        Icons.Material.Outlined.Chat

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 70 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(86, _localizer["Chat"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 72 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 73 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
     if (_canViewProducts || _canViewBrands)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudListSubheader>(87);
                __builder2.AddAttribute(88, "Class", "mt-2 mb-n2");
                __builder2.AddAttribute(89, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 75 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(90, _localizer["Catalog Management"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 76 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         if (_canViewProducts)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(91);
                __builder2.AddAttribute(92, "Href", "/catalog/products");
                __builder2.AddAttribute(93, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 78 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                        Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 79 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(95, _localizer["Products"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 81 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         if (_canViewBrands)
        {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudNavLink>(96);
                __builder2.AddAttribute(97, "Href", "/catalog/brands");
                __builder2.AddAttribute(98, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 84 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
                                                      Icons.Material.Outlined.CallToAction

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 85 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
__builder3.AddContent(100, _localizer["Brands"]);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 87 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
         
    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\NavMenu.razor"
       
    private ClaimsPrincipal _authenticationStateProviderUser;

    private bool _canViewHangfire;
    private bool _canViewDashboards;
    private bool _canViewDocuments;
    private bool _canViewDocumentTypes;
    private bool _canViewAuditTrails;
    private bool _canViewRoles;
    private bool _canViewUsers;
    private bool _canViewChat;
    private bool _canViewProducts;
    private bool _canViewBrands;

    protected override async Task OnParametersSetAsync()
    {
        _authenticationStateProviderUser = await _stateProvider.GetAuthenticationStateProviderUserAsync();
        _canViewHangfire = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Hangfire.View)).Succeeded;
        _canViewDashboards = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Dashboards.View)).Succeeded;
        _canViewDocuments = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Documents.View)).Succeeded;
        _canViewDocumentTypes = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.DocumentTypes.View)).Succeeded;
        _canViewAuditTrails = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.AuditTrails.View)).Succeeded;
        _canViewRoles = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Roles.View)).Succeeded;
        _canViewUsers = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Users.View)).Succeeded;
        _canViewChat = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Communication.Chat)).Succeeded;
        _canViewProducts = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Products.View)).Succeeded;
        _canViewBrands = (await _authorizationService.AuthorizeAsync(_authenticationStateProviderUser, Permissions.Brands.View)).Succeeded;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Localization.IStringLocalizer<NavMenu> _localizer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserManager _userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ClientPreferenceManager _clientPreferenceManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpInterceptorManager _interceptor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient _httpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService _dialogService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthorizationService _authorizationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorHeroStateProvider _stateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccountManager _accountManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAuthenticationManager _authenticationManager { get; set; }
    }
}
#pragma warning restore 1591
