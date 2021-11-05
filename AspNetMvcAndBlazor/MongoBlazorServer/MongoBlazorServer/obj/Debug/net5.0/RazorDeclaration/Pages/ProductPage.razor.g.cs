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
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id}")]
    public partial class ProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Pages\ProductPage.razor"
       
    int SessionValue = 0;
    string chosenColor = "";
    string chosenSize = "";
    string currentBigPicture = "";

    private Product product;

    [Parameter]
    public string Id { get; set; }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        product = productService.GetProduct(MongoDB.Bson.ObjectId.Parse(Id));

        currentBigPicture = product.Image1;
    }

    private async void Save()
    {
        product.Colors[0] = chosenColor;
        product.Sizes[0] = chosenSize;
        productService.SaveOrUpdateCart(product);
        SessionValue = await oLocalStore.GetItemAsync<int>("MySessionValue");
        await oLocalStore.SetItemAsync("MySessionValue", ++SessionValue);
    }

    private void BigPicture(int newPic)
    {
        switch (newPic)
        {
            case 1:
                currentBigPicture = product.Image1;
                break;
            case 2:
                currentBigPicture = product.Image2;
                break;
            case 3:
                currentBigPicture = product.Image3;
                break;
            case 4:
                currentBigPicture = product.Image4;
                break;
            default:
                break;
        }

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService productService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService oLocalStore { get; set; }
    }
}
#pragma warning restore 1591
