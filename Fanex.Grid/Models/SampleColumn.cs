using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fanex.Grid.Models
{
    public class SampleColumn
    {
        public int IntValue { get; set; }

        public string StringValue { get; set; }

        public bool BoolValue { get; set; }

        public SampleColumn SampleValue { get; set; }
    }
}