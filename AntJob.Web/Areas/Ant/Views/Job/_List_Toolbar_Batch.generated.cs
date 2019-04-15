﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    
    #line 2 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
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
    using AntJob.Web;
    using NewLife;
    
    #line 1 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
    using NewLife.Common;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Ant/Views/Job/_List_Toolbar_Batch.cshtml")]
    public partial class _Areas_Ant_Views_Job__List_Toolbar_Batch_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Ant_Views_Job__List_Toolbar_Batch_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
  
    var user = ViewBag.User as IUser ?? User.Identity as IUser;
    var fact = ViewBag.Factory as IEntityOperate;
    var enableSelect = this.EnableSelect();

    var sdic = new Dictionary<String, String>();
    sdic["strFormat"] = "yyyy-MM-dd HH:mm:ss";
    sdic["dname"] = "sday";
    sdic["title"] = "开始";

    var edic = new Dictionary<String, String>();
    edic["strFormat"] = "yyyy-MM-dd HH:mm:ss";
    edic["dname"] = "eday";
    edic["title"] = "结束";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 18 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
 if (enableSelect)
{

            
            #line default
            #line hidden
WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 20 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
                                                                                   Write(Url.Action("Set"));

            
            #line default
            #line hidden
WriteLiteral("?enable=true\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        批量启用\r\n    </button>\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-error btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 23 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
                                                                                 Write(Url.Action("Set"));

            
            #line default
            #line hidden
WriteLiteral("?enable=false\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        批量禁用\r\n    </button>\r\n");

WriteLiteral("    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" name=\"days\"");

WriteLiteral(" value=\"-1\"");

WriteLiteral(" title=\"重置到多少天之前（-1表示直接清空开始时间）\"");

WriteLiteral(" style=\"width:40px\"");

WriteLiteral(" />\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-warning btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 27 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
                                                                                   Write(Url.Action("ResetTime"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-fields=\"keys,days\"");

WriteLiteral(" disabled>\r\n        重置时间\r\n    </button>\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-danger btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 30 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
                                                                                  Write(Url.Action("ResetOther"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-fi");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        重置其它\r\n    </button>\r\n");

WriteLiteral("    <input");

WriteLiteral(" type=\"number\"");

WriteLiteral(" name=\"offset\"");

WriteLiteral(" value=\"15\"");

WriteLiteral(" title=\"距离实际时间秒数\"");

WriteLiteral(" style=\"width:40px\"");

WriteLiteral(" />\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 34 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
                                                                                   Write(Url.Action("SetOffset"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-fields=\"keys,offset\"");

WriteLiteral(" disabled>\r\n        设置偏移\r\n    </button>\r\n");

WriteLiteral("    <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"btn btn-success btn-sm\"");

WriteLiteral(" data-action=\"action\"");

WriteLiteral(" data-url=\"");

            
            #line 37 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
                                                                                   Write(Url.Action("ClearError"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" data-fields=\"keys\"");

WriteLiteral(" disabled>\r\n        清空错误数\r\n    </button>\r\n");

            
            #line 40 "..\..\Areas\Ant\Views\Job\_List_Toolbar_Batch.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591