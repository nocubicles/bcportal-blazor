#pragma checksum "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b2389fd95e2f7c0e368cba8582b642ad432eb78"
// <auto-generated/>
#pragma warning disable 1591
namespace bcportal.Shared
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
#line 2 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
using Microsoft.NAV;

#line default
#line hidden
#nullable disable
    public partial class LotSelection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
 if (ShowPopUp)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "modal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "style", "display:block;background-color:darkslategrey");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal-dialog modal-dialog-centered");
            __builder.AddAttribute(9, "role", "document");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddAttribute(13, "style", "width: auto;");
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "modal-header");
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "h3");
            __builder.AddAttribute(19, "class", "modal-title");
            __builder.AddContent(20, "Select Lot Nos to use for ");
            __builder.AddContent(21, 
#nullable restore
#line 11 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                                                       ItemDescription

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(22, " quantity ");
            __builder.AddContent(23, 
#nullable restore
#line 11 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                                                                                 ComponentQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, "Selected Quantity: ");
            __builder.AddContent(27, 
#nullable restore
#line 12 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                           TotalSelectedQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                    ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "type", "button");
            __builder.AddAttribute(31, "class", "close");
            __builder.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                      ClosePopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.AddMarkupContent(34, "<span aria-hidden=\"true\">X</span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "modal-body");
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 19 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                     if (APIError)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "                        ");
            __builder.OpenElement(41, "span");
            __builder.AddAttribute(42, "style", "color:red");
            __builder.AddContent(43, 
#nullable restore
#line 21 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                                 ErrorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 22 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "container-fluid");
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "table");
            __builder.AddAttribute(50, "class", "table");
            __builder.AddMarkupContent(51, "\r\n                            ");
            __builder.AddMarkupContent(52, @"<thead>
                                <tr>
                                    <th>
                                        Item No.
                                    </th>
                                    <th>
                                        Lot No.
                                    </th>
                                    <th>
                                        Reamining lot quantity
                                    </th>
                                    <th>
                                        Quantity to use
                                    </th>
                                </tr>
                            </thead>
                            ");
            __builder.OpenElement(53, "tbody");
            __builder.AddMarkupContent(54, "\r\n");
#nullable restore
#line 42 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                 foreach (var itemStockState in itemStockStates)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(55, "                                    ");
            __builder.OpenElement(56, "tr");
            __builder.AddMarkupContent(57, "\r\n                                        ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 45 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                             itemStockState.itemNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                        ");
            __builder.OpenElement(61, "td");
            __builder.AddContent(62, 
#nullable restore
#line 46 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                             itemStockState.lotNo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                        ");
            __builder.OpenElement(64, "td");
            __builder.AddContent(65, 
#nullable restore
#line 47 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                             itemStockState.remainingQuantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                        ");
            __builder.OpenElement(67, "td");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "number");
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                                                              e => UpdateSelectedQuantity(itemStockState.remainingQuantity, itemStockState.lotNo, e)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                                                                                                                                                          if (QuantityOver)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<span style=\"color:red\">Quantity over</span>");
#nullable restore
#line 49 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                                                                     }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 51 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 59 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(82, "\r\n\r\n");
            __builder.OpenElement(83, "button");
            __builder.AddAttribute(84, "class", "btn btn-primary");
            __builder.AddAttribute(85, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
                                          ManageLotNos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(86, "\r\n    Lot Nos\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "C:\Users\villem\source\repos\bcportal\bcportal\Shared\LotSelection.razor"
       
    [Parameter]
    public itemStockState[] itemStockStates { get; set; }

    [Parameter]
    public decimal? ComponentQuantity { get; set; }

    [Parameter]
    public string ItemDescription { get; set; }

    [Parameter]
    public string AssemblyOrderNo { get; set; }

    [Parameter]
    public string ItemNo { get; set; }

    [Parameter]
    public string LocationCode { get; set; }

    [Parameter]
    public int LineNo { get; set; }

    private bool ShowPopUp = false;
    private bool QuantityOver = false;
    private bool APIError = false;
    private string ErrorMessage;

    private decimal TotalSelectedQuantity;

    void UpdateSelectedQuantity(decimal? remainingQuantity,string lotNo, ChangeEventArgs args)
    {
        decimal value = 0;
        APIError = false;
        ErrorMessage = "";
        try
        {
            value = Decimal.Parse(args.Value.ToString());
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error parsing input");
        }

        if (value > remainingQuantity)
        {
            QuantityOver = true;
        } else
        {
            QuantityOver = false;
        }

        try
        {
            BCService.AddItemTrackingForComponent(value, AssemblyOrderNo, ItemNo, LocationCode, lotNo, LineNo);

        } catch (Exception ex)
        {
            APIError = true;

            ErrorMessage = ex.InnerException.Message;
        }

        UpdateTotalSelectedQuantity(value);
    }

    void UpdateTotalSelectedQuantity(decimal quantity)
    {
        TotalSelectedQuantity += quantity;
    }

    void ManageLotNos()
    {
        ShowPopUp = true;
    }

    void ClosePopup()
    {
        ShowPopUp = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private bcportal.Services.BCService BCService { get; set; }
    }
}
#pragma warning restore 1591