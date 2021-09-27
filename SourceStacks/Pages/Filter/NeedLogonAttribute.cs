using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SourceStacks.Pages.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SourceStacks.Pages.Filter
{
    public class NeedLogonAttribute : Attribute, IPageFilter
    {
        //	参考一起帮，使用[NeedLogOn] 保证未登录用户无法访问只有登录用户才能访问的页面：
        //未登录用户强行访问上述页面，自动跳转到登录页面
        //此时的登录页面显示提示
        //登录之后，自动跳转到之前欲访问页面
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (context.HttpContext.Request.Method.ToUpper() == "GET")
            {
                if (context.HttpContext.Session.Keys == null)
                {
                    ((PageModel)context.HandlerInstance).TempData[Keys.ErrorMessage]
                        = $"访问{context.HttpContext.Request.Path}页面需要先登录";
                    context.Result = new RedirectToPageResult("/Log/On");
                }//else nothing
            }//else not
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
        }
    }
}
