namespace Fanex.Grid.HtmlHelperExtensions
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;

    [JsonObject(NamingStrategyType = typeof(DefaultNamingStrategy))]
    public class Row
    {
        public string CssClass { get; private set; }

        public string CustomAttributes { get; private set; }

        [JsonProperty(PropertyName = "Columns")]
        public List<Cell> Cells { get; private set; } = new List<Cell>();

        public List<Row> SubRows { get; private set; }

        public Row AddCells(List<Cell> columns)
        {
            Cells.AddRange(columns);

            return this;
        }

        public Row AddCell(Cell cell)
        {
            Cells.Add(cell);

            return this;
        }

        public Row AddSubRows(List<Row> subRows)
        {
            SubRows = subRows;

            return this;
        }

        public Row SetCssClass(string cssClass)
        {
            CssClass = cssClass;

            return this;
        }

        public Row SetCustomAttributes(string customAttributes)
        {
            CustomAttributes = customAttributes;

            return this;
        }
    }
}