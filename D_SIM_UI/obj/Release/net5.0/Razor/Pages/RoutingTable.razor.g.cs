#pragma checksum "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59dfda5b81a96da235c61ebb2f440304ea46c5db"
// <auto-generated/>
#pragma warning disable 1591
namespace D_SIM_UI.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Systems/{SystemID}/RoutingTable")]
    public partial class RoutingTable : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<AntDesign.Menu>(0);
            __builder.AddAttribute(1, "Mode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<AntDesign.MenuMode>(
#nullable restore
#line 3 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
               MenuMode.Horizontal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<AntDesign.MenuItem>(3);
                __builder2.AddAttribute(4, "Key", "app");
                __builder2.AddAttribute(5, "RouterLink", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 4 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                                         String.Format("/Systems/{0}/RoutingTable", SystemID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "RouterMatch", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 4 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                                                                                                            NavLinkMatch.All

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<AntDesign.Icon>(8);
                    __builder3.AddAttribute(9, "Type", "appstore");
                    __builder3.AddAttribute(10, "Theme", "outline");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n            Routing Table\r\n        ");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\r\n\r\n    ");
            __builder.OpenElement(13, "h3");
            __builder.AddContent(14, "RoutingTable : ");
            __builder.AddContent(15, 
#nullable restore
#line 10 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                        SystemID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n    ");
            __builder.AddMarkupContent(17, "<h3>RoutingTable</h3>");
#nullable restore
#line 14 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
 if (RTRows is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<p>Loading</p>");
#nullable restore
#line 17 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
}else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AntDesign.Table<RT_Row>>(19);
            __builder.AddAttribute(20, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<RT_Row>>(
#nullable restore
#line 21 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                    RTRows

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<RT_Row>)((context) => (__builder2) => {
                __Blazor.D_SIM_UI.Pages.RoutingTable.TypeInference.CreateColumn_0(__builder2, 22, 23, true, 24, 
#nullable restore
#line 22 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                          context.LocationID

#line default
#line hidden
#nullable disable
                , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.LocationID = __value, context.LocationID)), 26, () => context.LocationID);
                __builder2.AddMarkupContent(27, "\r\n    ");
                __Blazor.D_SIM_UI.Pages.RoutingTable.TypeInference.CreateColumn_1(__builder2, 28, 29, 
#nullable restore
#line 23 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                          context.Destinations

#line default
#line hidden
#nullable disable
                , 30, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Destinations = __value, context.Destinations)), 31, () => context.Destinations, 32, (__builder3) => {
                    __builder3.OpenComponent<AntDesign.Dropdown>(33);
                    __builder3.AddAttribute(34, "Overlay", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<AntDesign.Menu>(35);
                        __builder4.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
#nullable restore
#line 27 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                     foreach (string destination in context.Destinations)
                        {

#line default
#line hidden
#nullable disable
                            __builder5.OpenComponent<AntDesign.MenuItem>(37);
                            __builder5.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.OpenElement(39, "a");
                                __builder6.AddAttribute(40, "class", "ant-dropdown-link");
                                __builder6.AddEventPreventDefaultAttribute(41, "onclick", true);
                                __builder6.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                                         () => upDateDefaultDestinationAsync(destination,context)

#line default
#line hidden
#nullable disable
                                ));
                                __builder6.AddContent(43, 
#nullable restore
#line 33 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                                 destination

#line default
#line hidden
#nullable disable
                                );
                                __builder6.CloseElement();
                            }
                            ));
                            __builder5.CloseComponent();
#nullable restore
#line 36 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                        }

#line default
#line hidden
#nullable disable
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.AddAttribute(44, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(45, 
#nullable restore
#line 40 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                 context.DefaultDestination

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(46, "\r\n        ");
                    __builder3.OpenComponent<AntDesign.Icon>(47);
                    __builder3.AddAttribute(48, "Type", "down");
                    __builder3.CloseComponent();
                }
                );
                __builder2.AddMarkupContent(49, "\r\n    ");
                __Blazor.D_SIM_UI.Pages.RoutingTable.TypeInference.CreateColumn_2(__builder2, 50, 51, true, 52, 
#nullable restore
#line 45 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                          context.Status

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.Status = __value, context.Status)), 54, () => context.Status);
                __builder2.AddMarkupContent(55, "\r\n    ");
                __Blazor.D_SIM_UI.Pages.RoutingTable.TypeInference.CreateColumn_3(__builder2, 56, 57, true, 58, 
#nullable restore
#line 46 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                          context.CurrentFulfilment

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.CurrentFulfilment = __value, context.CurrentFulfilment)), 60, () => context.CurrentFulfilment);
                __builder2.AddMarkupContent(61, "\r\n    ");
                __Blazor.D_SIM_UI.Pages.RoutingTable.TypeInference.CreateColumn_4(__builder2, 62, 63, true, 64, 
#nullable restore
#line 47 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                          context.MaximumFulfilment

#line default
#line hidden
#nullable disable
                , 65, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.MaximumFulfilment = __value, context.MaximumFulfilment)), 66, () => context.MaximumFulfilment);
                __builder2.AddMarkupContent(67, "\r\n    ");
                __Blazor.D_SIM_UI.Pages.RoutingTable.TypeInference.CreateColumn_5(__builder2, 68, 69, true, 70, 
#nullable restore
#line 48 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                          context.LaneCheckEnabled

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.LaneCheckEnabled = __value, context.LaneCheckEnabled)), 72, () => context.LaneCheckEnabled, 73, (__builder3) => {
                    __builder3.OpenElement(74, "a");
                    __builder3.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                     () => upCheckEnabledAsync("LaneCheckEnabled",context.LaneCheckEnabled,context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(76, 
#nullable restore
#line 49 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                                                                                                      context.LaneCheckEnabled

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                );
                __builder2.AddMarkupContent(77, "\r\n    ");
                __Blazor.D_SIM_UI.Pages.RoutingTable.TypeInference.CreateColumn_6(__builder2, 78, 79, true, 80, 
#nullable restore
#line 52 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                          context.ProfileCheckEnabled

#line default
#line hidden
#nullable disable
                , 81, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => context.ProfileCheckEnabled = __value, context.ProfileCheckEnabled)), 82, () => context.ProfileCheckEnabled, 83, (__builder3) => {
                    __builder3.OpenElement(84, "a");
                    __builder3.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                     () => upCheckEnabledAsync("ProfileCheckEnabled",context.ProfileCheckEnabled,context)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddContent(86, 
#nullable restore
#line 53 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
                                                                                                            context.ProfileCheckEnabled

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                );
            }
            ));
            __builder.AddComponentReferenceCapture(87, (__value) => {
#nullable restore
#line 19 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
             table = (AntDesign.Table<RT_Row>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 57 "C:\Users\D_SIM_DEV\Source\Repos\D_SIM_UI\D_SIM_UI\Pages\RoutingTable.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.D_SIM_UI.Pages.RoutingTable
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateColumn_0<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Sortable", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateColumn_1<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TData __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Field", __arg0);
        __builder.AddAttribute(__seq1, "FieldChanged", __arg1);
        __builder.AddAttribute(__seq2, "FieldExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateColumn_2<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Sortable", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateColumn_3<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Sortable", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateColumn_4<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Sortable", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateColumn_5<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Sortable", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateColumn_6<TData>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Boolean __arg0, int __seq1, TData __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TData> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TData>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::AntDesign.Column<TData>>(seq);
        __builder.AddAttribute(__seq0, "Sortable", __arg0);
        __builder.AddAttribute(__seq1, "Field", __arg1);
        __builder.AddAttribute(__seq2, "FieldChanged", __arg2);
        __builder.AddAttribute(__seq3, "FieldExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
