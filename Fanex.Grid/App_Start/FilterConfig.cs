// --------------------------------------------------------------------------
// <copyright file="FilterConfig.cs" company="">
// Copyright (c) . All rights reserved.
// </copyright>
// --------------------------------------------------------------------------
// <history>
//   <change who="Ricky.Nguyen" date="2013.11.27">Created</change>
// </history>

namespace Fanex.Grid
{
    using System.Web.Mvc;

    /// <summary>
    /// Filter Configurations.
    /// </summary>
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}