﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NuGetGallery.Views.Packages
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Microsoft.Web.Helpers;
    using NuGetGallery;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.2.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Packages/Download.cshtml")]
    public class Download : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Download()
        {
        }
        public override void Execute()
        {

            
            #line 1 "..\..\Views\Packages\Download.cshtml"
  
    ViewBag.Tab = "Packages";


            
            #line default
            #line hidden
WriteLiteral(@"
<h1 class=""page-heading"">Where is the download link for this package?</h1>
<p>
    The short answer is, <em>there is no download link</em> because NuGet provides 
    a faster better way to incorporate a library into your project.
</p>

<p>
    Simply:
</p>
<ul>
    <li>
        <a href=""http://docs.nuget.org/docs/start-here/installing-nuget"" title=""Installinsg NuGet""><strong>Install NuGet</strong></a> 
        (it&#8217;s quick and easy)
    </li>
    <li>
        Then start using it to <a href=""http://docs.nuget.org/docs/start-here/managing-nuget-packages-using-the-dialog"" title=""Managing NuGet packages""><strong>find and acquire your favorite libraries</strong></a>
    </li>
</ul>

<h2>Why NuGet?</h2>
<p>
    Typically, when you download a zip file that contains an assembly, you have to:
</p>

<ul>
    <li>&#8220;Unblock&#8221; the package to mark the downloaded package as safe</li>
    <li>Unzip the package contents (assemblies, images, css files, etc.) into a location in the solution</li>
    <li>Add an assembly reference to the project</li>
    <li>Update the web.config file with the correct settings (which you probably have to search for if they’re not included in the package somehow.)</li>
</ul>

<p>
    NuGet does all this for you! For a brief overview of what NuGet is, 
    see <a href=""http://docs.nuget.org/docs/start-here/overview"">NuGet overview</a>.
</p>

");


        }
    }
}
#pragma warning restore 1591