#pragma checksum "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0e5707863109f3a44501fb4e83be64c5d59cbee"
// <auto-generated/>
#pragma warning disable 1591
namespace Tuesdays.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using Tuesdays.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\_Imports.razor"
using Tuesdays.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
using Tuesdays.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/businessadminpage")]
    public partial class BusinessAdminPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.AddMarkupContent(2, "\r\n    <br>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-lg-6 col-md-6 col-sm-12");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h3>Add Business</h3>\r\n        <br>\r\n        ");
            __builder.OpenElement(7, "input");
            __builder.AddAttribute(8, "type", "text");
            __builder.AddAttribute(9, "class", "form-control mb-3");
            __builder.AddAttribute(10, "placeholder", "Enter Name");
            __builder.AddAttribute(11, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
                                        newBusiness.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newBusiness.Name = __value, newBusiness.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "type", "text");
            __builder.AddAttribute(16, "class", "form-control mb-3");
            __builder.AddAttribute(17, "placeholder", "Enter Link");
            __builder.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
                                        newBusiness.Link

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newBusiness.Link = __value, newBusiness.Link));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "text");
            __builder.AddAttribute(23, "class", "form-control mb-3");
            __builder.AddAttribute(24, "placeholder", "Enter Offer");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
                                        newBusiness.Offer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newBusiness.Offer = __value, newBusiness.Offer));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "button");
            __builder.AddAttribute(29, "class", "btn btn-block btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
                                                            SubmitBusiness

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, "Submit");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-lg-6 col-md-6 col-sm-12");
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.AddMarkupContent(37, "<h3>List of Businesses</h3>\r\n        <br>\r\n");
#nullable restore
#line 19 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
 if (businesses == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "    ");
            __builder.AddMarkupContent(39, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 22 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "    ");
            __builder.OpenElement(41, "table");
            __builder.AddAttribute(42, "class", "table table-responsive");
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.AddMarkupContent(44, "<thead>\r\n            <tr>\r\n                <th>Id</th>\r\n                <th>Name</th>\r\n                <th>Link</th>\r\n                <th>Offer</th>\r\n                <th></th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(45, "tbody");
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 37 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
             foreach (var business in businesses)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(47, "                ");
            __builder.OpenElement(48, "tr");
            __builder.AddMarkupContent(49, "\r\n                    ");
            __builder.OpenElement(50, "td");
#nullable restore
#line 40 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
__builder.AddContent(51, business.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
#nullable restore
#line 41 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
__builder.AddContent(54, business.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                    ");
            __builder.OpenElement(56, "td");
#nullable restore
#line 42 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
__builder.AddContent(57, business.Link);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "td");
#nullable restore
#line 43 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
__builder.AddContent(60, business.Offer);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "td");
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
                                            ()=>GetBusiness(@business.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "class", "btn btn-sm btn-primary");
            __builder.AddContent(67, "Edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                     ");
            __builder.OpenElement(70, "td");
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.OpenElement(72, "button");
            __builder.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
                                            ()=>DeleteBusiness(@business.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "class", "btn btn-sm btn-primary");
            __builder.AddContent(75, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
#nullable restore
#line 52 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(79, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#nullable restore
#line 55 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\gstull1\Documents\Blazor\Tuesdays\Client\Pages\BusinessAdminPage.razor"
       
    private Business[] businesses;
    private bool edit = false;
    private Business newBusiness = new Business();

    protected override async Task OnInitializedAsync()
    {
        businesses = await Http.GetFromJsonAsync<Business[]>("api/business");
    }
    private async Task SubmitBusiness(){
        if(edit == false){
            await Http.PostAsJsonAsync<Business>("api/business",newBusiness);
            await OnInitializedAsync();
            newBusiness = new Business();
        }else{
            await Http.PutAsJsonAsync<Business>("api/business/"+newBusiness.Id,newBusiness);
            await OnInitializedAsync();
            edit = false;
            newBusiness = new Business();
        }
    }
    private async Task DeleteBusiness(int id){
            await Http.DeleteAsync("api/business/"+id.ToString());
            await OnInitializedAsync();
    }
    private async Task GetBusiness(int id){
        newBusiness = await Http.GetFromJsonAsync<Business>("api/business/"+id.ToString());
        edit = true;

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
