#pragma checksum "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58bc16b0e1ab4e72481c2b87443b9e8d75cf430f"
// <auto-generated/>
#pragma warning disable 1591
namespace WarehouseManger.Client.Shared.Components
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
#line 1 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
using WarehouseManger.Shared.Constants.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    public partial class LanguageSelector : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::MudBlazor.MudMenu>(0);
            __builder.AddAttribute(1, "Icon", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 2 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
                Icons.Material.Outlined.Translate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Color", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Color>(
#nullable restore
#line 2 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
                                                          Color.Inherit

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Direction", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::MudBlazor.Direction>(
#nullable restore
#line 2 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
                                                                                    Direction.Bottom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OffsetY", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 2 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
                                                                                                               true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "Dense", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 2 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
                                                                                                                            true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
#nullable restore
#line 3 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
     foreach (var language in LocalizationConstants.SupportedLanguages)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenComponent<global::MudBlazor.MudMenuItem>(7);
                __builder2.AddAttribute(8, "OnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
                              (()=> ChangeLanguageAsync(language.Code))

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 5 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
__builder3.AddContent(10, language.DisplayName);

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 6 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
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
#line 10 "C:\Learning\DotNetMicroServices\Main\Blazor\WarehouseManger\src\Client\Shared\Components\LanguageSelector.razor"
 
    private async Task ChangeLanguageAsync(string languageCode)
    {
        var result = await _clientPreferenceManager.ChangeLanguageAsync(languageCode);
        if (result.Succeeded)
        {
            _snackBar.Add(result.Messages[0], Severity.Success);
            _navigationManager.NavigateTo(_navigationManager.Uri, forceLoad: true);
        }
        else
        {
            foreach (var error in result.Messages)
            {
                _snackBar.Add(error, Severity.Error);
            }
        }
    }

#line default
#line hidden
#nullable disable
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
