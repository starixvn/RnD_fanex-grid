using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fanex.Grid.ViewModels
{
    public class ComplexColumnViewModel
    {
        public int IntValue { get; set; }

        public string StringValue { get; set; }

        public bool BoolValue { get; set; }

        public ComplexColumnViewModel SampleValue { get; set; }
    }
}