#pragma checksum "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7184538100a60c7a53aa20959462525a1403051b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Order_Index), @"mvc.1.0.view", @"/Areas/User/Views/Order/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\_ViewImports.cshtml"
using ePizzaHub.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7184538100a60c7a53aa20959462525a1403051b", @"/Areas/User/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e58d56bf3880eaa468156c41235465a7410d0bf", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Order_Index : ePizzaHub.WebUI.Helpers.BaseViewPage<IEnumerable<ePizzaHub.Entities.Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>My Orders</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
 if (Model != null && Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 15 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 19 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PaymentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 22 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 25 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 28 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 31 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 34 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PaymentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Locality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
                   Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 71 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-sm-12 mt-4"">
            <p style=""min-height:300px"">
                You haven't placed any order yet. Please search your pizza from the menu! <br><br>
                <a href=""/"" class=""btn btn-primary"">Browse Menu</a>
            </p>
        </div>
    </div>
");
#nullable restore
#line 82 "C:\Users\MCM\Desktop\Pizza Project Dotnet\ePizzaHub\ePizzaHub.WebUI\Areas\User\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ePizzaHub.Entities.Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591