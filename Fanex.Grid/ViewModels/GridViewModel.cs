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
        public string FirstColumnName
        {
            get
            {
                return "firstColumn";
            }
        }

        public string FirstColumnText
        {
            get
            {
                return "First Column";
            }
        }

        public string SecondColumnName
        {
            get
            {
                return "secondColumn";
            }
        }

        public string SecondColumnText
        {
            get
            {
                return "Second Column";
            }
        }

        public string ThirdColumnName
        {
            get
            {
                return "thirdColumn";
            }
        }

        public string ThirdColumnText
        {
            get
            {
                return "Third Column";
            }
        }

        public string FourthColumnName
        {
            get
            {
                return "fourthColumn";
            }
        }

        public string FourthColumnText
        {
            get
            {
                return "Fourth Column";
            }
        }

        public string FifthColumnName
        {
            get
            {
                return "fifthColumn";
            }
        }

        public string FifthColumnText
        {
            get
            {
                return "Fifth Column";
            }
        }

        public string SixthColumnName
        {
            get
            {
                return "sixthColumn";
            }
        }

        public string SixthColumnText
        {
            get
            {
                return "Sixth Column";
            }
        }

        public string SeventhColumnName
        {
            get
            {
                return "seventhColumn";
            }
        }

        public string SeventhColumnText
        {
            get
            {
                return "Seventh Column";
            }
        }

        public string EighthColumnName
        {
            get
            {
                return "eighthColumn";
            }
        }

        public string EighthColumnText
        {
            get
            {
                return "Eighth Column";
            }
        }

        public string NinthColumnName
        {
            get
            {
                return "ninthColumn";
            }
        }

        public string NinthColumnText
        {
            get
            {
                return "Ninth Column";
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

            if (isAddHeaderRows)
            {
                this.AddHeaderRows();
            }

            if (isAddFooterRows)
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
                        .AddColumn(new RowColumn(SixthColumnName, i))
                        .AddColumn(new RowColumn(SeventhColumnName, i))
                        .AddColumn(new RowColumn(EighthColumnName, i))
                        .AddColumn(new RowColumn(NinthColumnName, i))
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
                        .AddColumn(new RowColumn(SixthColumnName, i))
                        .AddColumn(new RowColumn(SeventhColumnName, i))
                        .AddColumn(new RowColumn(EighthColumnName, i))
                        .AddColumn(new RowColumn(NinthColumnName, i))
                        );
            }
        }

        private void AddHeaderRows()
        {
            HeaderRows = new List<Row>();
            HeaderRows.Add(
                new Row()
                    .AddColumn(new RowColumn(FirstColumnName).SetHeaderText("Group 1").SetMergeColumnNumber(2).SetTextAlign(TextAlign.Center))
                    .AddColumn(new RowColumn(ThirdColumnName).SetHeaderText(ThirdColumnText).SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(FourthColumnName).SetHeaderText(FourthColumnText).SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(FifthColumnName).SetHeaderText(FifthColumnText).SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(SixthColumnName).SetHeaderText(SixthColumnText).SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(SeventhColumnName).SetHeaderText(SeventhColumnText).SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(EighthColumnName).SetHeaderText(EighthColumnText).SetMergeRowNumber(2))
                    .AddColumn(new RowColumn(NinthColumnName).SetHeaderText(NinthColumnText).SetMergeRowNumber(2))
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
                        .AddColumn(new RowColumn(FifthColumnName, 5).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
                        .AddColumn(new RowColumn(SixthColumnName, 6).SetMergeColumnNumber(4))

                );
            FooterRows.Add(
                    new Row()
                        .AddColumn(new RowColumn(SecondColumnName, 22))
                        .AddColumn(new RowColumn(ThirdColumnName, 3))
                        .AddColumn(new RowColumn(FourthColumnName, 4))
                        .AddColumn(new RowColumn(SixthColumnName, 6).SetMergeColumnNumber(2))
                        .AddColumn(new RowColumn(EighthColumnName, 8).SetMergeColumnNumber(2))
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