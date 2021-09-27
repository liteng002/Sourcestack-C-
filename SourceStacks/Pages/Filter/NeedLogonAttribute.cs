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
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (context.HttpContext.Request.Method.ToUpper() == "GET")
            {
                //if (context.HttpContext.Request.Cookies[Keys.UserId] == null)
                //{
                //	((PageModel)context.HandlerInstance).TempData[Keys.ErrorMessage]
                //		= $"访问{context.HttpContext.Request.Path}页面需要先登录";
                //	context.Result = new RedirectToPageResult("/Log/On");
                //}//else nothing
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
