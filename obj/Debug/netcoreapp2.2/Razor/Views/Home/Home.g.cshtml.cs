#pragma checksum "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c44e77a09b097b89e71ce925c56f73687844ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Home.cshtml", typeof(AspNetCore.Views_Home_Home))]
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
#line 1 "/Users/jeverett/Desktop/Claymore/Claymore/Views/_ViewImports.cshtml"
using Claymore;

#line default
#line hidden
#line 2 "/Users/jeverett/Desktop/Claymore/Claymore/Views/_ViewImports.cshtml"
using Claymore.Models;

#line default
#line hidden
#line 1 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
using Claymore.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c44e77a09b097b89e71ce925c56f73687844ef", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6db5e3f94884cf76882291fb58e157612a383b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 51, true);
            WriteLiteral("\n\n<div id=\"nav\">\n     <p><br></p>\n    <h5>Welcome, ");
            EndContext();
            BeginContext(80, 22, false);
#line 6 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
            Write(ViewBag.user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(102, 103, true);
            WriteLiteral("</h5>\n    <p><br></p>\n</div>\n<p class=\"card-text\"><b class=\"posting_title\">Total Jobs Applied To: </b> ");
            EndContext();
            BeginContext(206, 16, false);
#line 9 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                                                     Write(ViewBag.JobCount);

#line default
#line hidden
            EndContext();
            BeginContext(222, 719, true);
            WriteLiteral(@" </p>
<!--BEGIN STATS AREA-->
<!--FUTURE-->   
<!-- <div class=""row"">
  <div class=""col-sm-6"">
    <div class=""card"">
      <div class=""card-header card-home"">
        <nav class=""navbar navbar-dark bg-dark"">
          <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#collapseStats"" aria-expanded=""false"" aria-controls=""collapseStats"">
          <span class=""navbar-toggler-icon""></span></button><h5 class=""card-title"">Your Job Stats</h5>
      </div>
      <div class=""card-body collapse"" id=""collapseStats"">
        <p class=""card-text""><b class=""posting_title"">Last Application Entered On: </b>  </p>
        <p class=""card-text""><b class=""posting_title"">Total Jobs Applied To: </b> ");
            EndContext();
            BeginContext(942, 16, false);
#line 22 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                                                             Write(ViewBag.JobCount);

#line default
#line hidden
            EndContext();
            BeginContext(958, 1757, true);
            WriteLiteral(@" </p> -->
<!--FUTURE-->       
        <!-- <p class=""card-text""><b class=""posting_title"">Total Phone Screens: </b> No Data </p>
        <p class=""card-text""><b class=""posting_title"">Total Phone Interviews: </b> No Data </p>
        <p class=""card-text""><b class=""posting_title"">Total Interviews: </b> No Data </p>
        <p class=""card-text""><b class=""posting_title"">Total Denied: </b> No Data </p> -->
      <!-- </div>
    </nav>
  </div>
</div> -->
<!--FUTURE-->  
  <!-- <div class=""col-sm-6"">
    <div class=""card"">
      <div class=""card-header card-home"">
        <nav class=""navbar navbar-dark bg-dark"">
          <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#collapseStats2"" aria-expanded=""false"" aria-controls=""collapseStats2"">
          <span class=""navbar-toggler-icon""></span></button><h5 class=""card-title"">More Stats</h5>
      </div>
      <div class=""card-body collapse"" id=""collapseStats2"">
        <p class=""card-text""><b class=""posting_title"">Percent to Phone Screen");
            WriteLiteral(@": </b> No Data </p>
        <p class=""card-text""><b class=""posting_title"">Percent to Phone Interview: </b> No Data </p>
        <p class=""card-text""><b class=""posting_title"">Percent to Interview: </b> No Data </p>
    </div>
    </nav>
  </div>
</div> -->
<!-- </div> -->
<p><br></p>
<!--END STATS AREA-->
<table class=""table table-striped table-hover"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Date Applied</th>
      <th scope=""col"">Company Name</th>
      <th scope=""col"">Position</th>
      <th scope=""col"">Phone Screen</th>
      <th scope=""col"">Phone Interview</th>
      <th scope=""col"">Interview</th>
      <th scope=""col"">Mark Denied</th>
      <th scope=""col"">Options</th>
    </tr>
  </thead>
  <tbody>
");
            EndContext();
#line 65 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
        
          foreach (var posting in @ViewBag.AA)
          {

#line default
#line hidden
            BeginContext(2783, 62, true);
            WriteLiteral("              <tr>\n                <td class=\"table-success\"> ");
            EndContext();
            BeginContext(2846, 35, false);
#line 69 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                      Write(posting.DateApply.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(2881, 30, true);
            WriteLiteral(" </td>\n                <td> <a");
            EndContext();
            BeginWriteAttribute("href", " href= \"", 2911, "\"", 2946, 2);
            WriteAttributeValue("", 2919, "/posting/", 2919, 9, true);
#line 70 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
WriteAttributeValue("", 2928, posting.PostingId, 2928, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2947, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2949, 15, false);
#line 70 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                                       Write(posting.Company);

#line default
#line hidden
            EndContext();
            BeginContext(2964, 30, true);
            WriteLiteral("</a></td>\n                <td>");
            EndContext();
            BeginContext(2995, 21, false);
#line 71 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
               Write(posting.PositionTitle);

#line default
#line hidden
            EndContext();
            BeginContext(3016, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
#line 72 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                     if (posting.PhoneScreen == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(3152, 4, false);
#line 74 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 74 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(3221, 37, false);
#line 78 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
           Write(posting.PhoneScreen.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 78 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                                      
            }

#line default
#line hidden
            BeginContext(3273, 38, true);
            WriteLiteral("            </td>\n                <td>");
            EndContext();
#line 81 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                     if (posting.PhoneInterview == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(3424, 4, false);
#line 83 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 83 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(3493, 40, false);
#line 87 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
           Write(posting.PhoneInterview.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 87 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                                         
            }

#line default
#line hidden
            BeginContext(3548, 38, true);
            WriteLiteral("            </td>\n                <td>");
            EndContext();
#line 90 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                     if (posting.Interview == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(3694, 4, false);
#line 92 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 92 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(3763, 35, false);
#line 96 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
           Write(posting.Interview.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 96 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                                    
            }

#line default
#line hidden
            BeginContext(3813, 38, true);
            WriteLiteral("            </td>\n                <td>");
            EndContext();
#line 99 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                     if (posting.Denied == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(3956, 4, false);
#line 101 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 101 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(4025, 32, false);
#line 105 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
           Write(posting.Denied.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 105 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
                                                 
            }

#line default
#line hidden
            BeginContext(4072, 57, true);
            WriteLiteral("            </td>\n                \n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href= \"", 4129, "\"", 4161, 2);
            WriteAttributeValue("", 4137, "/edit/", 4137, 6, true);
#line 109 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
WriteAttributeValue("", 4143, posting.PostingId, 4143, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4162, 85, true);
            WriteLiteral(" class=\"btn btn-outline-info btn-sm \" role=\"button\" aria-disabled=\"true\">Edit</a>  <a");
            EndContext();
            BeginWriteAttribute("href", " href= \"", 4247, "\"", 4281, 2);
            WriteAttributeValue("", 4255, "/Delete/", 4255, 8, true);
#line 109 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
WriteAttributeValue("", 4263, posting.PostingId, 4263, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4282, 127, true);
            WriteLiteral("class=\"btn btn-outline-danger btn-sm \" role=\"button\" aria-disabled=\"true\">Delete</a></td>\n                \n              </tr>\n");
            EndContext();
#line 112 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Home.cshtml"
          }
      

#line default
#line hidden
            BeginContext(4429, 137, true);
            WriteLiteral("     \n  </tbody>\n</table>\n\n<a href=\"/AddPosting\" class=\"btn btn-success btn-sm\" role=\"button\" aria-disabled=\"true\">Add a New Posting</a>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
