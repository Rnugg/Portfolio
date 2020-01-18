#pragma checksum "/Users/randonjordan/Documents/CodingDojo/Coding/Portfolio/Views/Home/Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc457ddbd862e1fbf82fc765c8f2df1149ba471f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Projects), @"mvc.1.0.view", @"/Views/Home/Projects.cshtml")]
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
#line 1 "/Users/randonjordan/Documents/CodingDojo/Coding/Portfolio/Views/_ViewImports.cshtml"
using c_sharpPortfolio;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/randonjordan/Documents/CodingDojo/Coding/Portfolio/Views/_ViewImports.cshtml"
using c_sharpPortfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc457ddbd862e1fbf82fc765c8f2df1149ba471f", @"/Views/Home/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7ae2587519b0a183a4377c6edb023da4935432", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/brewproject.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Brewscovery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/stockx.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/randonjordan/Documents/CodingDojo/Coding/Portfolio/Views/Home/Projects.cshtml"
  
    ViewData["Title"] = "Projects";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""projects"">
            <div class=""navbar_projects"">
                <h1 class=""title"" data-aos=""fade-up""
                data-aos-anchor-placement=""bottom-bottom"">Projects</h1>
            </div>
            <div class=""project1"" data-aos=""flip-left""
            data-aos-easing=""ease-out-cubic""
            data-aos-anchor-placement=""bottom-bottom""
            data-aos-duration=""2000"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc457ddbd862e1fbf82fc765c8f2df1149ba471f5112", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""overlay1"">
                    <div class=""text1"">
                        <h3>About Brewscovery</h3>
                            <p>An Application using an API to search for your favorite beer. Register and Login to your profile and search for your 
                                favorite beer to find which brewery closest to you has it.
                            </p>
                        <div class='frontend'>
                            <h4 class='feheader'>Front-end</h4>
                            <ul class='frontlist'>
                                <li>HTML5</li>
                                <li>CSS3</li>
                                <li>JavaScript</li>
                                <button>See Code</button>
                            </ul>
                        </div>
                        <div class='backend'>
                            <h4 class=beheader>Back-end</h4>
                            <ul class=""backlist"">
                                <");
            WriteLiteral(@"li>Python</li>
                                <li>Django</li>
                                <li>MySQL</li>
                                <button>See Project</button>

                            </ul>
                        
                        </div>
                    </div>
                </div>
            </div>
            
            <div class=""project1"" data-aos=""flip-up""
            data-aos-easing=""ease-out-cubic""
            data-aos-anchor-placement=""bottom-bottom""
            data-aos-duration=""2000"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc457ddbd862e1fbf82fc765c8f2df1149ba471f7911", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""overlay1"">
                    <div class=""text1"">
                        <h3>About Stock Palace</h3>
                            <p>Stock Palace is a streetwear eCommerce application I created with
                            two other friends and hosted on Amazon Web Services. 
                            </p>
                        <div class='frontend'>
                            <h4 class='feheader'>Front-end</h4>
                            <ul class='frontlist'>
                                <li>HTML5</li>
                                <li>CSS3</li>
                                <li>Bootstrap</li>
                                <button>See Code</button>
                            </ul>
                        </div>
                        <div class='backend'>
                            <h4 class=beheader>Back-end</h4>
                            <ul class=""backlist"">
                                <li>Node.js</li>
                                <li>MongoDB</");
            WriteLiteral(@"li>
                                <li>Express.js</li>
                                <button>See Project</button>

                            </ul>
                        
                        </div>
                    </div>
                </div>
            </div>
            <div class=""project1"" data-aos=""flip-right""
            data-aos-easing=""ease-out-cubic""
            data-aos-anchor-placement=""bottom-bottom""
            data-aos-duration=""2000"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dc457ddbd862e1fbf82fc765c8f2df1149ba471f10646", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                <div class=""overlay1"">
                    <div class=""text1"">Hello Animal Shelter</div>
                </div>
            </div>
            
            
            <div class=""projects_quote"" data-aos=""fade-in""
            data-aos-anchor-placement=""top-center""
            data-aos-duration=""3000"">
                <div class=""quote"">
                    <blockquote cite=""https://www.goodreads.com/quotes/201306-when-you-don-t-create-things-you-become-defined-by-your"">""When you don't create things, you become defined by your
                     tastes rather than 
                    ability. Your tastes only narrow and exlude people.... So, create!""</blockquote>
                    
                    <h4>- Why The Lucky Stiff</h4>
                </div>
            </div>


        </div>

");
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
