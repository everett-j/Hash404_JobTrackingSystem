#pragma checksum "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbba12b8b2088c18c53df98ecd1765ad48133ae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Posting), @"mvc.1.0.view", @"/Views/Home/Posting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Posting.cshtml", typeof(AspNetCore.Views_Home_Posting))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbba12b8b2088c18c53df98ecd1765ad48133ae3", @"/Views/Home/Posting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc6db5e3f94884cf76882291fb58e157612a383b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Posting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 342, true);
            WriteLiteral(@"<div id=""nav"">
    <p><BR></p>

</div>


<!--BEGIN of CARD ROW-->
<div class=""row"">
  <div class=""col-sm-6 "">
    <div class=""card text-black bg-light mb-3"">
    <div class=""card-header""><h5 class=""card-title text-white"">Job Details</h5></div>
      <div class=""card-body "">
        <p class=""card-text""><b class=""posting_title"">Company:</b> ");
            EndContext();
            BeginContext(343, 23, false);
#line 13 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                              Write(ViewBag.Posting.Company);

#line default
#line hidden
            EndContext();
            BeginContext(366, 77, true);
            WriteLiteral("</p>\n        <p class=\"card-text\"><b class=\"posting_title\">Date Applied:</b> ");
            EndContext();
            BeginContext(444, 43, false);
#line 14 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                   Write(ViewBag.Posting.DateApply.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(487, 96, true);
            WriteLiteral("</p>\n        <p class=\"card-text\"><b class=\"posting_title\">Job Link:</b> <a style=\"color: black\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 583, "\"", 615, 1);
#line 15 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
WriteAttributeValue(" ", 590, ViewBag.posting.JobLink, 591, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(616, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(618, 23, false);
#line 15 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                                                                        Write(ViewBag.posting.JobLink);

#line default
#line hidden
            EndContext();
            BeginContext(641, 80, true);
            WriteLiteral("</a></p>\n        <p class=\"card-text\"><b class=\"posting_title\">Job Posting:</b> ");
            EndContext();
            BeginContext(722, 26, false);
#line 16 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                  Write(ViewBag.posting.JobPosting);

#line default
#line hidden
            EndContext();
            BeginContext(748, 50, true);
            WriteLiteral("</p>\n       \n     <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(806, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 20 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.ConfirmationEmail == true)
            {
                

#line default
#line hidden
            BeginContext(914, 14, false);
#line 22 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 22 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(994, 14, false);
#line 26 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 26 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(1025, 74, true);
            WriteLiteral("            <b class=\"posting_title\">Received Confirmation Email </b></p>\n");
            EndContext();
            BeginContext(1106, 335, true);
            WriteLiteral(@"      <!--END TRUE FALSE CONTROL-->  
      </div>
    </div>
  </div>
  <div class=""col-sm-6 "">
    <div class=""card text-black bg-light mb-3"">
     <div class=""card-header""><h5 class="" text-white card-title"">Key Info</h5></div>
      <div class=""card-body "">
        <p class=""card-text""><b class=""posting_title"">Position Title: </b>");
            EndContext();
            BeginContext(1442, 29, false);
#line 38 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                     Write(ViewBag.posting.PositionTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1471, 79, true);
            WriteLiteral("</p>\n        <p class=\"card-text\"><b class=\"posting_title\">Recruiter Name:</b> ");
            EndContext();
            BeginContext(1551, 29, false);
#line 39 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                     Write(ViewBag.posting.RecruiterName);

#line default
#line hidden
            EndContext();
            BeginContext(1580, 77, true);
            WriteLiteral("</p>\n        <p class=\"card-text\"><b class=\"posting_title\">Contact Name:</b> ");
            EndContext();
            BeginContext(1658, 27, false);
#line 40 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                   Write(ViewBag.posting.ContactName);

#line default
#line hidden
            EndContext();
            BeginContext(1685, 70, true);
            WriteLiteral("</p>\n        <p class=\"card-text\"><b class=\"posting_title\">Notes:</b> ");
            EndContext();
            BeginContext(1756, 21, false);
#line 41 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                            Write(ViewBag.posting.Notes);

#line default
#line hidden
            EndContext();
            BeginContext(1777, 408, true);
            WriteLiteral(@"</p>
      </div>
    </div>
  </div>
</div>
<!--END of CARD ROW-->

<!--BEGIN of CARD ROW 2-->
<div class=""row"">
  <div class=""col-sm-6 "">
    <div class=""card text-black bg-light mb-3"">
    <div class=""card-header""><h5 class=""text-white card-title"">Phone Screen</h5></div>
      <div class=""card-body "">
      <!--BEGIN DATE CONTROL-->
      <p class=""card-text""><b class=""posting_title"">Phone Screen: </b>");
            EndContext();
#line 55 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                       if (@ViewBag.posting.PhoneScreen == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(2304, 4, false);
#line 57 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 57 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(2373, 45, false);
#line 61 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
           Write(ViewBag.posting.PhoneScreen.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 61 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                              
            }

#line default
#line hidden
            BeginContext(2433, 127, true);
            WriteLiteral("            </p>\n\n      <!--END DATE CONTROL-->\n\n        <p class=\"card-text\"><b class=\"posting_title\">Phone Screen Notes:</b> ");
            EndContext();
            BeginContext(2561, 27, false);
#line 67 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                         Write(ViewBag.posting.ScreenNotes);

#line default
#line hidden
            EndContext();
            BeginContext(2588, 44, true);
            WriteLiteral("</p>\n\n\n     <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(2640, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 72 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.ScreenEmail == true)
            {
                

#line default
#line hidden
            BeginContext(2742, 14, false);
#line 74 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 74 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(2822, 14, false);
#line 78 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 78 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(2853, 67, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Email Sent </b></p>\n");
            EndContext();
            BeginContext(2927, 75, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n    <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(3010, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 85 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.ScreenLetter == true)
            {
                

#line default
#line hidden
            BeginContext(3113, 14, false);
#line 87 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 87 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(3193, 14, false);
#line 91 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 91 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(3224, 68, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Letter Sent </b></p>\n");
            EndContext();
            BeginContext(3299, 77, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n      <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(3384, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 98 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.ScreenCall == true)
            {
                

#line default
#line hidden
            BeginContext(3485, 14, false);
#line 100 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 100 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(3565, 14, false);
#line 104 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 104 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(3596, 66, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Call Made </b></p>\n");
            EndContext();
            BeginContext(3669, 374, true);
            WriteLiteral(@"      <!--END TRUE FALSE CONTROL-->   

      </div>
    </div>
  </div>
  <div class=""col-sm-6 "">
    <div class=""card text-black bg-light mb-3"">
     <div class=""card-header""><h5 class=""text-white card-title"">Phone Interview</h5></div>
      <div class=""card-body "">
      <!--BEGIN DATE CONTROL-->
      <p class=""card-text""><b class=""posting_title"">Phone Interview: </b>");
            EndContext();
#line 118 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                          if (@ViewBag.posting.PhoneInterview == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(4165, 4, false);
#line 120 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 120 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(4234, 48, false);
#line 124 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
           Write(ViewBag.posting.PhoneInterview.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 124 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                 
            }

#line default
#line hidden
            BeginContext(4297, 130, true);
            WriteLiteral("            </p>\n\n      <!--END DATE CONTROL-->\n\n        <p class=\"card-text\"><b class=\"posting_title\">Phone Interview Notes:</b> ");
            EndContext();
            BeginContext(4428, 26, false);
#line 130 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                            Write(ViewBag.posting.PhoneNotes);

#line default
#line hidden
            EndContext();
            BeginContext(4454, 44, true);
            WriteLiteral("</p>\n      \n<!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(4506, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 134 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.PhoneEmail == true)
            {
                

#line default
#line hidden
            BeginContext(4607, 14, false);
#line 136 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 136 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(4687, 14, false);
#line 140 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 140 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(4718, 67, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Email Sent </b></p>\n");
            EndContext();
            BeginContext(4792, 75, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n    <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(4875, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 147 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.PhoneLetter == true)
            {
                

#line default
#line hidden
            BeginContext(4977, 14, false);
#line 149 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 149 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(5057, 14, false);
#line 153 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 153 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(5088, 68, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Letter Sent </b></p>\n");
            EndContext();
            BeginContext(5163, 77, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n      <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(5248, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 160 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.PhoneCall == true)
            {
                

#line default
#line hidden
            BeginContext(5348, 14, false);
#line 162 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 162 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(5428, 14, false);
#line 166 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 166 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(5459, 66, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Call Made </b></p>\n");
            EndContext();
            BeginContext(5532, 441, true);
            WriteLiteral(@"      <!--END TRUE FALSE CONTROL-->

      </div>
    </div>
  </div>
</div>
<!--END of CARD ROW 2-->

<!--BEGIN of CARD ROW 3-->
<div class=""row"">
  <div class=""col-sm-6 "">
    <div class=""card text-black bg-light mb-3"">
    <div class=""card-header""><h5 class=""text-white card-title"">Interview Info</h5></div>
      <div class=""card-body "">
      <!--BEGIN DATE CONTROL-->
      <p class=""card-text""><b class=""posting_title"">Interview: </b>");
            EndContext();
#line 185 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                    if (@ViewBag.posting.Interview == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(6090, 4, false);
#line 187 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 187 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(6159, 43, false);
#line 191 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
           Write(ViewBag.posting.Interview.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 191 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                            
            }

#line default
#line hidden
            BeginContext(6217, 124, true);
            WriteLiteral("            </p>\n\n      <!--END DATE CONTROL-->\n\n        <p class=\"card-text\"><b class=\"posting_title\">Interview Notes:</b> ");
            EndContext();
            BeginContext(6342, 30, false);
#line 197 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                      Write(ViewBag.posting.InterviewNotes);

#line default
#line hidden
            EndContext();
            BeginContext(6372, 38, true);
            WriteLiteral("</p>\n\n<!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(6418, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 201 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.InterviewEmail == true)
            {
                

#line default
#line hidden
            BeginContext(6523, 14, false);
#line 203 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 203 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(6603, 14, false);
#line 207 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 207 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(6634, 67, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Email Sent </b></p>\n");
            EndContext();
            BeginContext(6708, 75, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n    <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(6791, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 214 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.InterviewLetter == true)
            {
                

#line default
#line hidden
            BeginContext(6897, 14, false);
#line 216 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 216 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(6977, 14, false);
#line 220 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 220 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(7008, 68, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Letter Sent </b></p>\n");
            EndContext();
            BeginContext(7083, 77, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n      <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(7168, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 227 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.InterviewCall == true)
            {
                

#line default
#line hidden
            BeginContext(7272, 14, false);
#line 229 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 229 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(7352, 14, false);
#line 233 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 233 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(7383, 66, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Call Made </b></p>\n");
            EndContext();
            BeginContext(7456, 358, true);
            WriteLiteral(@"      <!--END TRUE FALSE CONTROL-->

      </div>
    </div>
  </div>
  <div class=""col-sm-6 "">
    <div class=""card text-black bg-light mb-3"">
     <div class=""card-header""><h5 class=""text-white card-title"">Denied Info</h5></div>
      <div class=""card-body "">
      <!--BEGIN DATE CONTROL-->
      <p class=""card-text""><b class=""posting_title"">Denied: </b>");
            EndContext();
#line 247 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                 if (@ViewBag.posting.Denied == Convert.ToDateTime("0001-01-01 00:00:00.000000"))
            {
                

#line default
#line hidden
            BeginContext(7928, 4, false);
#line 249 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("--");

#line default
#line hidden
            EndContext();
#line 249 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                       ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(7997, 40, false);
#line 253 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
           Write(ViewBag.posting.Denied.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
#line 253 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                         
            }

#line default
#line hidden
            BeginContext(8052, 121, true);
            WriteLiteral("            </p>\n\n      <!--END DATE CONTROL-->\n\n        <p class=\"card-text\"><b class=\"posting_title\">Denied Notes:</b> ");
            EndContext();
            BeginContext(8174, 27, false);
#line 259 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                                                   Write(ViewBag.posting.DeniedNotes);

#line default
#line hidden
            EndContext();
            BeginContext(8201, 38, true);
            WriteLiteral("</p>\n\n<!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(8247, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 263 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.DeniedEmail == true)
            {
                

#line default
#line hidden
            BeginContext(8349, 14, false);
#line 265 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 265 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(8429, 14, false);
#line 269 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 269 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(8460, 67, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Email Sent </b></p>\n");
            EndContext();
            BeginContext(8534, 75, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n    <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(8617, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 276 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.DeniedLetter == true)
            {
                

#line default
#line hidden
            BeginContext(8720, 14, false);
#line 278 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 278 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(8800, 14, false);
#line 282 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 282 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(8831, 68, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Letter Sent </b></p>\n");
            EndContext();
            BeginContext(8906, 77, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->   \n      <!--BEGIN TRUE FALSE CONTROL-->\n");
            EndContext();
            BeginContext(8991, 27, true);
            WriteLiteral("      <p class=\"card-text\">");
            EndContext();
#line 289 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                            if (@ViewBag.posting.DeniedCall == true)
            {
                

#line default
#line hidden
            BeginContext(9092, 14, false);
#line 291 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4D");

#line default
#line hidden
            EndContext();
#line 291 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }
            else
            {
                

#line default
#line hidden
            BeginContext(9172, 14, false);
#line 295 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
            Write("\uD83D\uDC4E");

#line default
#line hidden
            EndContext();
#line 295 "/Users/jeverett/Desktop/Claymore/Claymore/Views/Home/Posting.cshtml"
                                 ;
            }

#line default
#line hidden
            BeginContext(9203, 66, true);
            WriteLiteral("            <b class=\"posting_title\">Follow-up Call Made </b></p>\n");
            EndContext();
            BeginContext(9276, 101, true);
            WriteLiteral("      <!--END TRUE FALSE CONTROL-->\n\n      </div>\n    </div>\n  </div>\n</div>\n<!--END of CARD ROW 3-->");
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
