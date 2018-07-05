﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel.Atr.Admin.Helpers
{
    public static class ListHelper
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, string[] items)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item);
                ul.InnerHtml += li.ToString();
            }
            return new MvcHtmlString(ul.ToString());
        }

        public static MvcHtmlString CreateList(this HtmlHelper html, string[] items, object obj)
        {
            
        var type = obj.GetType();
            var props = type.GetProperties();
            Dictionary<string, string> dic = props.ToDictionary(x => x.Name, x => x.GetValue(obj, null).ToString());
            TagBuilder ul = new TagBuilder("ul");
            foreach (string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item);
                ul.InnerHtml += li.ToString();
            }
            foreach (var attr in dic)
            {
                ul.MergeAttribute(attr.Key.ToString(), attr.Value.ToString());
            }
            return new MvcHtmlString(ul.ToString());
        }
    }
}