#pragma checksum "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5dcff69eddd3aff814f13ebb6b5979b9dc1d406"
// <auto-generated/>
#pragma warning disable 1591
namespace D_SIM_UI.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using D_SIM_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using D_SIM_UI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Layout>(0);
            __builder.AddAttribute(1, "Class", "layout");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.Header>(3);
                __builder2.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(5, "<div class=\"logo\" b-si9bx1ye40><a href=\"/\" b-si9bx1ye40><img src=\"/public/logo.png\" alt=\"Dematic Logo\" height=\"60\" b-si9bx1ye40></a></div>        \r\n        ");
                    __builder3.OpenComponent<AntDesign.Menu>(6);
                    __builder3.AddAttribute(7, "Theme", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuTheme>(
#nullable restore
#line 6 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
                     MenuTheme.Dark

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(8, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 6 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
                                           MenuMode.Horizontal

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
#nullable restore
#line 7 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
             foreach (string system in systemList)
            {

#line default
#line hidden
#nullable disable
                        __builder4.OpenComponent<AntDesign.MenuItem>(10);
                        __builder4.AddAttribute(11, "Key", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
                               systemList.IndexOf(system).ToString()

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(12, "RouterLink", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
                                                                                  String.Format("/Systems/{0}", system)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(13, "RouterMatch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 9 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
                                                                                                                                      NavLinkMatch.All

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(15, 
#nullable restore
#line 9 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
                                                                                                                                                         system

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
#nullable restore
#line 10 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
            }

#line default
#line hidden
#nullable disable
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Content>(17);
                __builder2.AddAttribute(18, "Style", "padding: 0 50px;");
                __builder2.AddAttribute(19, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Breadcrumb>(20);
                    __builder3.AddAttribute(21, "Style", "margin: 16px 0;");
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.BreadcrumbItem>(23);
                        __builder4.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(25, "Home");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(26, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.BreadcrumbItem>(27);
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(29, "List");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(30, "\r\n            ");
                        __builder4.OpenComponent<AntDesign.BreadcrumbItem>(31);
                        __builder4.AddAttribute(32, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(33, "App");
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(34, "\r\n        ");
                    __builder3.OpenElement(35, "div");
                    __builder3.AddAttribute(36, "class", "site-layout-content");
                    __builder3.AddAttribute(37, "b-si9bx1ye40");
                    __builder3.AddContent(38, 
#nullable restore
#line 19 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Shared\MainLayout.razor"
                                          Body

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n    ");
                __builder2.OpenComponent<AntDesign.Footer>(40);
                __builder2.AddAttribute(41, "Style", "text-align: center; ");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "©2022 Dematic Pty Ltd");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.AddMarkupContent(45, @"<style b-si9bx1ye40>
    .site-layout-content {
        background: #fff;
        padding: 24px;
        min-height: 280px;
    }

    #components-layout-demo-top .logo {
        width: 120px;
        height: 31px;
        background: rgba(255, 255, 255, 0.2);
        margin: 16px 24px 16px 0;
        float: left;
    }

    .site-layout-content {
        min-height:700px;
    }
</style>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
