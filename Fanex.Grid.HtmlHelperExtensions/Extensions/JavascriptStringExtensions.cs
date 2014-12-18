namespace Fanex.Grid.HtmlHelperExtensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Enumerations;

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

        public static string ToJavascriptProperty(this TextAlign textAlign, string propertyName)
        {
            string textAlignValue = "left";
            switch (textAlign)
            {
                case TextAlign.Center:
                    textAlignValue = "center";
                    break;
                case TextAlign.Right:
                    textAlignValue = "right";
                    break;
            }

            return propertyName + ":" + textAlignValue + ",";
        }

        public static void AppendJavascriptPropertyLine(this StringBuilder script, string stringValue, string propertyName)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                script.AppendLine(stringValue.ToJavascriptProperty(propertyName));
            }
        }

        public static void AppendJavascriptPropertyLine(this StringBuilder script, int? intValue, string propertyName)
        {
            if (intValue.HasValue)
            {
                script.AppendLine(intValue.Value.ToJavascriptProperty(propertyName));
            }
        }

        public static void AppendJavascriptPropertyLine(this StringBuilder script, bool? boolValue, string propertyName)
        {
            if (boolValue.HasValue)
            {
                script.AppendLine(boolValue.Value.ToJavascriptProperty(propertyName));
            }
        }

        public static void AppendJavascriptPropertyLine(this StringBuilder script, TextAlign? textAlign, string propertyName)
        {
            if (textAlign.HasValue)
            {
                script.AppendLine(textAlign.Value.ToJavascriptProperty(propertyName));
            }
        }
    }
}
