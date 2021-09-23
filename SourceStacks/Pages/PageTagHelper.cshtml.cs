using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace SourceStacks.Pages
{
    [HtmlTargetElement("datetime", Attributes = "asp-showicons,asp-only")]
    public class PageTagHelperModel : TagHelper
    {
        //����һ���Զ����TagHelper��DateTimeTagHelper����Razor��ʹ�ã�
        //<datetime>@DateTime.Now</datetime> ����HTML��ǩ��
        //<small>2019��7��8�� 14��59��</small>
        //����������ԣ�asp-showicon
        //<datetime asp-showicon="true"> @DateTime.Now</datetime>��asp-showicon= "true"ʱ�����ɵ�HTML��ǩ����һ������ͼ�꣺
        //<small><span class="glyphicon glyphicon-calendar"></span>2019��7��8�� 14��59��</small>
        //��������ԣ�asp-only
        //<datetime asp-only="date"> @DateTime.Now</datetime>��asp-only= "date"ʱ�����ɵ�HTML��ǩֻ��ʾ���ڣ�����ʾʱ��
        //<small>2019��7��8��</small>


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "small";
            if (context.AllAttributes["asp-showicons"].Value.ToString() == "true")
            {
                output.PreContent.AppendHtml("<span class=\"fa fa-calendar \"></span>");
            }//else nothing
            if (context.AllAttributes["asp-only"].Value.ToString() == "date")
            {
                output.Content.AppendHtml(
                    Convert.ToDateTime(output.GetChildContentAsync()
                    .Result.GetContent()).ToString("yyyy��MM��dd��"));
            }//else nothing

            base.Process(context, output);
        }
    }
}
