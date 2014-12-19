namespace Fanex.Grid.HtmlHelperExtensions.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions.Enumerations;

    internal static class JavascriptStringExtensions
    {
        public static string ToJavascriptPropertyWithoutComma(this bool boolValue, string propertyName)
        {
            return propertyName + ":" + (boolValue ? "true" : "false");
        }

        public static string ToJavascriptPropertyWithoutComma(this int intValue, string propertyName)
        {
            return propertyName + ":" + intValue.ToString();
        }

        public static string ToJavascriptPropertyWithoutComma(this string stringValue, string propertyName)
        {
            return propertyName + ":'" + stringValue + "'";
        }

        public static string ToJavascriptFunctionWithoutComma(this string functionName, string propertyName)
        {
            return propertyName + ":" + functionName;
        }

        public static string ToJavascriptPropertyWithoutComma(this TextAlign textAlign, string propertyName)
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

            return propertyName + ":'" + textAlignValue + "'";
        }

        public static string ToJavascriptProperty(this bool boolValue, string propertyName)
        {
            return boolValue.ToJavascriptPropertyWithoutComma(propertyName) + ",";
        }

        public static string ToJavascriptProperty(this int intValue, string propertyName)
        {
            return intValue.ToJavascriptPropertyWithoutComma(propertyName) + ",";
        }

        public static string ToJavascriptProperty(this string stringValue, string propertyName)
        {
            return stringValue.ToJavascriptPropertyWithoutComma(propertyName) + ",";
        }

        public static string ToJavascriptProperty(this TextAlign textAlign, string propertyName)
        {
            return textAlign.ToJavascriptPropertyWithoutComma(propertyName) + ",";
        }

        public static string ToJavascriptFunction(this string functionName, string propertyName)
        {
            return functionName.ToJavascriptFunctionWithoutComma(propertyName) + ",";
        }

        public static void AppendJavascriptProperty(this StringBuilder script, string stringValue, string propertyName, bool isBreakNewLine = true)
        {
            if (!string.IsNullOrEmpty(stringValue))
            {
                script.AppendString(stringValue.ToJavascriptProperty(propertyName), isBreakNewLine);
            }
        }

        public static void AppendJavascriptFunction(this StringBuilder script, string functionName, string propertyName, bool isBreakNewLine = true)
        {
            if (!string.IsNullOrEmpty(functionName))
            {
                script.AppendString(functionName.ToJavascriptFunction(propertyName), isBreakNewLine);
            }
        }

        public static void AppendJavascriptProperty(this StringBuilder script, int? intValue, string propertyName, bool isBreakNewLine = true)
        {
            if (intValue.HasValue)
            {
                script.AppendString(intValue.Value.ToJavascriptProperty(propertyName), isBreakNewLine);
            }
        }

        public static void AppendJavascriptProperty(this StringBuilder script, bool? boolValue, string propertyName, bool isBreakNewLine = true)
        {
            if (boolValue.HasValue)
            {
                script.AppendString(boolValue.Value.ToJavascriptProperty(propertyName), isBreakNewLine);
            }
        }

        public static void AppendJavascriptProperty(this StringBuilder script, TextAlign? textAlign, string propertyName, bool isBreakNewLine = true)
        {
            if (textAlign.HasValue)
            {
                script.AppendString(textAlign.Value.ToJavascriptProperty(propertyName), isBreakNewLine);
            }
        }

        public static void AppendJavascriptProperty(this StringBuilder script, object objectValue, string propertyName, bool isBreakNewLine = true)
        {
            if (objectValue != null)
            {
                script.AppendString(propertyName + ":" + objectValue.ToString() + ",", isBreakNewLine);
            }
        }

        public static void AppendString(this StringBuilder script, string propertyScript, bool isBreakNewLine = true)
        {
            if (isBreakNewLine)
            {
                script.AppendLine(propertyScript);
            }
            else
            {
                script.Append(propertyScript);
            }
        }

        public static void AppendJavascriptPropertyLine<T>(this StringBuilder script, List<T> listValue, string propertyName)
        {
            if(listValue != null && listValue.Any())
            {
                script.AppendLine(propertyName + ":[");

                foreach (object value in listValue)
                {
                    script.Append(value.ToString());
                }

                script.AppendLine("],");
            }
        }
    }
}
