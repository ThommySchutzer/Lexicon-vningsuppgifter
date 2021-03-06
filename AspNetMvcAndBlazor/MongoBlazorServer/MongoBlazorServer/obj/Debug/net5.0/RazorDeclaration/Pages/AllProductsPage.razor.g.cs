// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
