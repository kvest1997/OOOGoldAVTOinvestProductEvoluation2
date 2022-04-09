using AngleSharp.Html.Dom;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOGoldAVTOinvestProductEvoluation2.Core.Site
{
    class SiteParser : IParser<string[]>
    {
        public string[] Parser(IHtmlDocument document)
        {
            var list = new List<string>();
            var items = document.QuerySelectorAll("h3").Where(item => item.ClassName != null & item.ClassName.Contains("title-root-zZCwT iva-item-title-py3i_ title-listRedesign-_rejR title-root_maxHeight-X6PsH text-text-LurtD text-size-s-BxGpL text-bold-SinUO"));
        
            
            foreach(var item in items)
            {
                list.Add(item.TextContent);
            }

            return list.ToArray();

        }
    }
}
