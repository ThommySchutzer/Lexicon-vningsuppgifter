#pragma checksum "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f6ff2eb8c353d04c1df3216eceae70bfdf31ab"
// <auto-generated/>
#pragma warning disable 1591
namespace MongoBlazorServer.Components
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
    public partial class RangeControl : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "rc-" + (
#nullable restore
#line 1 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
             ID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, 
#nullable restore
#line 2 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
      new MarkupString($@"<style>
        #rc-{ID} {{
            position: relative;
            width: {Width}px;
        }}

        #rc-{ID} > input[type='range'] {{
            padding: 0;
            margin: 0;
            display: inline-block;
            vertical-align: top;
            width: 100%;
            --range-color: hsl(190, 80%, 40%);
            background: var(--track-background);
        }}
        #rc-{ID} > input[type='range']::-moz-range-track {{
            border-color: transparent; /* needed to switch FF to 'styleable' control */
        }}
        #rc-{ID} > input[name='low-range'] {{
            position: absolute;
            --track-background: linear-gradient(to right, transparent {100 * (ValueLow - MinValue) / (MaxValue - MinValue) + 1}%, var(--range-color) 0, var(--range-color) {100 * (ValueHigh - MinValue) / (MaxValue - MinValue) - 1}%, transparent 0 ) no-repeat 0 45% / 100% 40%;
        }}
        #rc-{ID} > input[name='low-range']::-webkit-slider-thumb {{
            position: relative;
            z-index: 2;
        }}
        #rc-{ID} > input[name='low-range']::-moz-range-thumb {{
                transform: scale(1); /* FF doesn't apply position it seems */
                z-index: 1;
            }}
        #rc-{ID} > input[name='high-range'] {{
            position: relative;
            --track-background: linear-gradient(to right, transparent {100 * (ValueLow - MinValue) / (MaxValue - MinValue) + 1}%, var(--range-color) 0, var(--range-color) {100 * (ValueHigh - MinValue) / (MaxValue - MinValue) - 1}%, transparent 0 ) no-repeat 0 45% / 100% 40%;
            clip-path: polygon({50 * (ValueLow + ValueHigh) / (MaxValue - MinValue) + 1}% 0, 100% 0, 100% 100%, {50 * (ValueLow + ValueHigh) / (MaxValue - MinValue) + 1}% 100%);
        }}

        #rc-{ID} > input[type='range']::-webkit-slider-runnable-track {{
            background: var(--track-background);
        }}

        #rc-{ID} > input[type='range']::-moz-range-track {{
            background: var(--track-background);
        }}
    </style>")

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "name", "low-range");
            __builder.AddAttribute(6, "type", "range");
            __builder.AddAttribute(7, "min", 
#nullable restore
#line 46 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
                                               MinValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "max", 
#nullable restore
#line 46 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
                                                               MaxValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 46 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
                                                                                 ValueLow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ValueLow = __value, ValueLow));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "name", "high-range");
            __builder.AddAttribute(14, "type", "range");
            __builder.AddAttribute(15, "min", 
#nullable restore
#line 47 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
                                                MinValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "max", 
#nullable restore
#line 47 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
                                                                MaxValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
                                                                                  ValueHigh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ValueHigh = __value, ValueHigh));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 50 "D:\Användare\tillt\source\repos\AspNet\MongoBlazorServer\MongoBlazorServer\Components\RangeControl.razor"
 
    int _valueLow = 0;
    int _valueHigh = 100;
    [Parameter] public int Width { get; set; } = 200;
    [Parameter] public int MinValue { get; set; } = 0;
    [Parameter] public int MaxValue { get; set; } = 100;
    [Parameter]
    public int ValueLow
    {
        get => Math.Min(_valueLow, _valueHigh);
        set
        {
            if (_valueLow.Equals(value))
                return;
            _valueLow = value;
            if (_valueLow >= _valueHigh)
            {
                _valueLow = _valueHigh;
                _valueHigh = value;
                ValueHighChanged.InvokeAsync(_valueHigh);
            }
            ValueLowChanged.InvokeAsync(_valueLow);
        }
    }
    [Parameter]
    public int ValueHigh
    {
        get => Math.Max(_valueLow, _valueHigh);
        set
        {
            if (_valueHigh.Equals(value))
                return;
            _valueHigh = value;
            if (_valueLow >= _valueHigh)
            {
                _valueHigh = _valueLow;
                _valueLow = value;
                ValueLowChanged.InvokeAsync(_valueLow);
            }
            ValueHighChanged.InvokeAsync(_valueHigh);
        }
    }
    [Parameter] public EventCallback<int> ValueLowChanged { get; set; }
    [Parameter] public EventCallback<int> ValueHighChanged { get; set; }
    string ID = Guid.NewGuid().ToString().Replace("-", "").Substring(15);

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
