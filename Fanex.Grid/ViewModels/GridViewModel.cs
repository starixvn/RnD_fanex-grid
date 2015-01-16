using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Fanex.Grid.HtmlHelperExtensions;
using Fanex.Grid.HtmlHelperExtensions.Enumerations;

namespace Fanex.Grid.ViewModels
{
    public class GridViewModel
    {
        public string FirstColumnName { 
            get
            {
                return "firstColumn";
            }
        }

        public string SecondColumnName { 
            get
            {
                return "secondColumn";
            }
        }

        public string ThirdColumnName { 
            get
            {
                return "thirdColumn";
            }
        }

        public string FourthColumnName { 
            get
            {
                return "fourthColumn";
            }
        }

        public string FifthColumnName { 
            get
            {
                return "fifthColumn";
            }
        }

        public List<Row> BodyRows { get; set; }
        public List<Row> FooterRows { get; set; }
        public List<Row> HeaderRows { get; set; }

        public GridViewModel(
            int bodyRowNumber = 100, 
            bool withComplexColumnValue = false,
            bool isAddHeaderRows = false, 
            bool isAddFooterRows = false)
        {
            if (withComplexColumnValue)
            {
                this.AddBodyRowsWithComplexColumnValue(bodyRowNumber);
            }
            else
            {
                this.AddBodyRows(bodyRowNumber);
            }

            if(isAddHeaderRows)
            {
                this.AddHeaderRows();
            }

            if(isAddFooterRows)
            {
                this.AddFooterRows();
            }
        }

        private void AddBodyRows(int bodyRowNumber)
        {
            BodyRows = new List<Row>();
            for (int i = 0; i < bodyRowNumber; i++)
            {
                BodyRows.Add(
                    new Row()
                        .AddColumn(new RowColumn(FirstColumnName, i))
                        .AddColumn(new RowColumn(SecondColumnName, RandomString(6)))
                        .AddColumn(new RowColumn(ThirdColumnName, random.Next()))
                        .AddColumn(new RowColumn(FourthColumnName, RandomString(3)))
                        .AddColumn(new RowColumn(FifthColumnName, i * 2))
                        );
            }
        }

        private void AddBodyRowsWithComplexColumnValue(int bodyRowNumber)
        {
            BodyRows = new List<Row>();
            for (int i = 0; i < bodyRowNumber; i++)
            {
                BodyRows.Add(
                    new Row()
                        .AddColumn(new RowColumn(FirstColumnName, i))
                        .AddColumn(new RowColumn(SecondColumnName, RandomString(6)))
                        .AddColumn(new RowColumn(ThirdColumnName, random.Next()))
                        .AddColumn(new RowColumn(FourthColumnName, RandomString(3)))
                        .AddColumn(new RowColumn(FifthColumnName, new ComplexColumnViewModel
                        {
                            IntValue = i
                        }))
                        );
            }
        }

        private void AddHeaderRows()
        {
            HeaderRows = new List<Row>();
            HeaderRows.Add(
                new Row()
                    .AddColumn(new RowColumn(FirstColumnName).SetHeaderText("Group 1").SetMergeColumnNumber(2).SetTextAlign(TextAlign.Center))
                    .AddColumn(new RowColumn(ThirdColumnName).SetHeaderText("Third Column").SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(FourthColumnName).SetHeaderText("Fourth Column").SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(FifthColumnName).SetHeaderText("Fifth Column").SetMergeRowNumber(2))
            );
        }

        private void AddFooterRows()
        {
            FooterRows = new List<Row>();
            FooterRows.Add(
                    new Row()
                        .AddColumn(new RowColumn(FirstColumnName, 1).SetMergeRowNumber(2))
                        .AddColumn(new RowColumn(SecondColumnName, 2))
                        .AddColumn(new RowColumn(ThirdColumnName, 3).SetMergeColumnNumber(2))
                        .AddColumn(new RowColumn(FirstColumnName, 5).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
                );
            FooterRows.Add(
                    new Row()
                        .AddColumn(new RowColumn(SecondColumnName, 2))
                        .AddColumn(new RowColumn(ThirdColumnName, 3))
                        .AddColumn(new RowColumn(FourthColumnName, 4))
                        );  
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

    }
}