#pragma checksum "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a7789a11387373da26a5756ff50a7ecc49eb9da"
// <auto-generated/>
#pragma warning disable 1591
namespace MongoBlazorServer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoBlazorServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoBlazorServer.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoBlazorServer.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoBlazorServer.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoBlazorServer.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoBlazorServer.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoDB.Bson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoDB.Bson.Serialization.Attributes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\_Imports.razor"
using MongoDB.Bson.Serialization.IdGenerators;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/allproducts/")]
    public partial class AllProductsPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\" style=\"margin-bottom:20px;padding:50px 0;background-color:black;color:white;text-align:center;\" b-h14q3saxvp><h2 b-h14q3saxvp>Home / Shop</h2></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddAttribute(3, "b-h14q3saxvp");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.AddAttribute(6, "b-h14q3saxvp");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "sidenav col-3");
            __builder.AddAttribute(9, "style", "display:block;");
            __builder.AddAttribute(10, "b-h14q3saxvp");
            __builder.OpenComponent<MongoBlazorServer.Components.CategorySelectorComponent>(11);
            __builder.AddAttribute(12, "SetCurrentCategory", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 13 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                           SetCurrentCategory

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n            <hr b-h14q3saxvp>\r\n            ");
            __builder.AddMarkupContent(14, "<p b-h14q3saxvp><strong b-h14q3saxvp>Filter by Price</strong></p>\r\n            ");
            __builder.OpenComponent<MongoBlazorServer.Components.RangeControl>(15);
            __builder.AddAttribute(16, "MinValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                                                             0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "MaxValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                                                                          800

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "Width", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                                                                                      200

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ValueHigh", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                           ShowModel.Price[1]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ValueHighChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShowModel.Price[1] = __value, ShowModel.Price[1]))));
            __builder.AddAttribute(21, "ValueLow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 16 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                               ShowModel.Price[0]

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "ValueLowChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ShowModel.Price[0] = __value, ShowModel.Price[0]))));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "b-h14q3saxvp");
            __builder.AddMarkupContent(26, "\r\n                Price:\r\n                ");
            __builder.OpenElement(27, "span");
            __builder.AddAttribute(28, "b-h14q3saxvp");
            __builder.AddContent(29, 
#nullable restore
#line 19 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                       ShowModel.Price[0].ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddContent(30, " - ");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "b-h14q3saxvp");
            __builder.AddContent(33, 
#nullable restore
#line 19 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                        ShowModel.Price[1].ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "span");
            __builder.AddAttribute(36, "style", "float:right;");
            __builder.AddAttribute(37, "b-h14q3saxvp");
            __builder.OpenElement(38, "img");
            __builder.AddAttribute(39, "src", "Icons/Filter btn.png");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                                       e => SetCurrentPriceRange()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "b-h14q3saxvp");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n        \r\n        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "main col-9");
            __builder.AddAttribute(45, "b-h14q3saxvp");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "row profile-row");
            __builder.AddAttribute(48, "style", "margin-left:10px");
            __builder.AddAttribute(49, "b-h14q3saxvp");
#nullable restore
#line 27 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                 foreach (var pro in products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-4");
            __builder.AddAttribute(52, "b-h14q3saxvp");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "card");
            __builder.AddAttribute(55, "style", "width: 28rem;");
            __builder.AddAttribute(56, "b-h14q3saxvp");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "card-body");
            __builder.AddAttribute(59, "b-h14q3saxvp");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(60);
            __builder.AddAttribute(61, "href", 
#nullable restore
#line 32 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                 $"product/{pro.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(63, "img");
                __builder2.AddAttribute(64, "src", 
#nullable restore
#line 33 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                               pro.Image9

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(65, "b-h14q3saxvp");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(66, "\r\n\r\n                                ");
            __builder.OpenElement(67, "h5");
            __builder.AddAttribute(68, "class", "card-title");
            __builder.AddAttribute(69, "b-h14q3saxvp");
            __builder.AddContent(70, 
#nullable restore
#line 36 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                        pro.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                                ");
            __builder.OpenElement(72, "h6");
            __builder.AddAttribute(73, "class", "card-subtitle mb-2 text-muted");
            __builder.AddAttribute(74, "b-h14q3saxvp");
            __builder.AddContent(75, 
#nullable restore
#line 37 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                           pro.Brand

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                                <hr b-h14q3saxvp>\r\n                                ");
            __builder.OpenElement(77, "p");
            __builder.AddAttribute(78, "b-h14q3saxvp");
            __builder.AddMarkupContent(79, "\r\n                                    Price: ");
            __builder.OpenElement(80, "label");
            __builder.AddAttribute(81, "style", "color:darkred");
            __builder.AddAttribute(82, "b-h14q3saxvp");
            __builder.AddContent(83, 
#nullable restore
#line 40 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                                                                         pro.Price.ToString("c")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.AddMarkupContent(85, @"<div class=""row"" b-h14q3saxvp><nav aria-label=""Page navigation example"" b-h14q3saxvp><ul class=""pagination"" b-h14q3saxvp><li class=""page-item"" b-h14q3saxvp><a class=""page-link"" href=""#"" b-h14q3saxvp>Previous</a></li>
                        <li class=""page-item"" b-h14q3saxvp><a class=""page-link"" href=""#"" b-h14q3saxvp>1</a></li>
                        <li class=""page-item"" b-h14q3saxvp><a class=""page-link"" href=""#"" b-h14q3saxvp>2</a></li>
                        <li class=""page-item"" b-h14q3saxvp><a class=""page-link"" href=""#"" b-h14q3saxvp>3</a></li>
                        <li class=""page-item"" b-h14q3saxvp><a class=""page-link"" href=""#"" b-h14q3saxvp>Next</a></li></ul></nav></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 66 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\AllProductsPage.razor"
       
    public ShowModel ShowModel = new ShowModel();

    public List<Product> products = new List<Product>();

    private int currentCategory = 7;

    private void SetCurrentCategory(int value)
    {
        currentCategory = value;

        for (int i = 0; i < ShowModel.Category.Length; i++)
        {
            ShowModel.Category[i] = false;
        }

        ShowModel.Category[currentCategory] = true;
        products = productService.GetProducts(ShowModel);

    }

    private void SetCurrentPriceRange()
    {
        products = productService.GetProducts(ShowModel);
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        //// Filter products
        //ShowModel.Category[7] = false;
        //ShowModel.Category[3] = true;

        products = productService.GetProducts(ShowModel);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
    }
}
#pragma warning restore 1591
