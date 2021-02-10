#pragma checksum "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51eae05816236fb8a28c7e5beb0a384abfc194b2"
// <auto-generated/>
#pragma warning disable 1591
namespace bcportal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using bcportal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\villem\source\repos\bcportal\bcportal\_Imports.razor"
using bcportal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
using Microsoft.NAV;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/assemblyorders/{No}")]
    public partial class AssemblyOrder : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Assembly Order</h1>");
#nullable restore
#line 9 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
 if (assemblyOrder == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading..</em></p>");
#nullable restore
#line 12 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h1");
            __builder.AddContent(3, "Order No: ");
            __builder.AddContent(4, 
#nullable restore
#line 16 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                   assemblyOrder.No

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "h2");
            __builder.AddContent(7, "Item: ");
            __builder.AddContent(8, 
#nullable restore
#line 17 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
               assemblyOrder.ItemNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "h2");
            __builder.AddContent(11, "Desc: ");
            __builder.AddContent(12, 
#nullable restore
#line 18 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
               assemblyOrder.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "h2");
            __builder.AddContent(15, "Quantity (Base): ");
            __builder.AddContent(16, 
#nullable restore
#line 19 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                          assemblyOrder.QuantityBase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "h2");
            __builder.AddContent(19, "Remaining Quantity (Base): ");
            __builder.AddContent(20, 
#nullable restore
#line 20 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                    assemblyOrder.RemainingQuantityBase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "h2");
            __builder.AddContent(23, "Assembled quantity (Base): ");
            __builder.AddContent(24, 
#nullable restore
#line 21 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                    assemblyOrder.AssembledQuantityBase

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "<p>Insert the quantity you wish to assemble:</p>\r\n    ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "number");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                  QuantityToPost

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => QuantityToPost = __value, QuantityToPost, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                      UpdateOrderQuantityToPost

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(33, "Update Quantity To Assemble");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                      PostOrder

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Post Order");
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
     if (APIError)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, 
#nullable restore
#line 29 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
         ErrorMessage

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 29 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                     
    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "table");
            __builder.AddAttribute(40, "class", "table");
            __builder.AddMarkupContent(41, @"<thead><tr><th>
                    Line No.
                </th>
                <th>
                    Component Item
                </th>
                <th>
                    Quantity Per
                </th>
                <th>
                    Component Quantity
                </th>
                <th>
                    Quantity To Consume
                </th>
                <th>
                    Consumed Quantity
                </th>
                <th>
                    Input Lot No.
                </th></tr></thead>
        ");
            __builder.OpenElement(42, "tbody");
#nullable restore
#line 58 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
             foreach (var line in assemblyOrder.assemblyOrderLines.ToArray())
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "tr");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 61 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                         line.lineNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 62 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                         line.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 63 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                         line.Qty_per_Unit_of_Measure

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 64 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                         line.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                      line.Quantity_to_Consume

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => line.Quantity_to_Consume = __value, line.Quantity_to_Consume));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 66 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                         line.Consumed_Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                    ");
            __builder.OpenElement(64, "td");
            __builder.OpenComponent<bcportal.Shared.LotSelection>(65);
            __builder.AddAttribute(66, "itemStockStates", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.NAV.itemStockState[]>(
#nullable restore
#line 67 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                                        GetItemInventory(line.No, line.Location_Code)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "ItemDescription", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                                                                                                         line.Description

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "ComponentQuantity", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Decimal?>(
#nullable restore
#line 68 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                                          line.Quantity

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "AssemblyOrderNo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                                                                           No

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "ItemNo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                                                                                        line.No

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "LineNo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 68 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                                                                                                          line.lineNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "LocationCode", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
                                                                                                                                                      line.Location_Code

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 71 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\villem\source\repos\bcportal\bcportal\Pages\AssemblyOrder.razor"
       
    [Parameter]
    public string No { get; set; }

    private decimal? QuantityToPost;
    ElementReference sel;

    private List<string> selections = new List<string>();

    private assemblyOrder assemblyOrder;

    private bool APIError;
    private string ErrorMessage;


    protected override async Task OnInitializedAsync()
    {
        try
        {
            APIError = false;
            assemblyOrder = await BCService.GetAssemblyOrder(No);
            QuantityToPost = assemblyOrder.QuantityToAssemble;
        }
        catch (Exception ex)
        {
            APIError = true;
            ErrorMessage = ex.InnerException.InnerException.Message;
        }

    }

    protected itemStockState[] GetItemInventory(string itemNo, string location)
    {
        try
        {
            var itemInventory = BCService.GetItemStock(itemNo, location);

            return itemInventory;
        }
        catch (Exception ex)
        {
            APIError = true;
            ErrorMessage = ex.InnerException.Message;
            return null;
        }

    }

    protected async Task UpdateOrderQuantityToPost()
    {
        try
        {
            APIError = false;

            await BCService.UpdateOrderQuantityToAssemble(No, QuantityToPost);
            assemblyOrder = await BCService.GetAssemblyOrder(No);

            StateHasChanged();
        }
        catch (Exception ex)
        {
            APIError = true;
            ErrorMessage = ex.InnerException.Message;

        }
    }

    protected async Task PostOrder()
    {
        try
        {
            await UpdateOrderQuantityToPost();
            APIError = false;
            await BCService.UpdateQuantityToAssemble(No, QuantityToPost);
            await BCService.PostAssemblyOrder(No);
            assemblyOrder = await BCService.GetAssemblyOrder(No);
            QuantityToPost = assemblyOrder.RemainingQuantity;
            StateHasChanged();
        }
        catch (Exception ex)
        {
            APIError = true;
            ErrorMessage = ex.InnerException.Message;
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private bcportal.Services.BCService BCService { get; set; }
    }
}
#pragma warning restore 1591