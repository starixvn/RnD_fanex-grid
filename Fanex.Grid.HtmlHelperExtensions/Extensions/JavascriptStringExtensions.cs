namespace Fanex.Grid.HtmlHelperExtensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class JavascriptStringExtensions
    {
        public static string ToJavascriptProperty(this bool boolValue, string propertyName)
        {
            return propertyName + ":" + (boolValue ? "true" : "false") + ",";
        }

        public static string ToJavascriptProperty(this int intValue, string propertyName)
        {
            return propertyName + ":" + intValue.ToString() + ",";
        }

        public static string ToJavascriptProperty(this string stringValue, string propertyName)
        {
            return propertyName + ":" + stringValue + ",";
        }
    }
}
