namespace Fanex.Grid.Documentation
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Fanex.Grid.HtmlHelperExtensions;
    using Fanex.Grid.HtmlHelperExtensions.Enumerations;

    public class GridViewModel
    {
        public string Master => "Master";

        public string MasterText => "Master";

        public string Turnover => "Turnover";

        public string TurnoverText => "Turnover";

        public string GrossComm => "GrossComm";

        public string GrossCommText => "Gross Comm";

        public string MasterTotal => "MasterTotal";

        public string MasterTotalText => "Master Total";

        public string WinLoss => "WinLoss";

        public string WinLossText => "Win/Loss";

        public string Comm => "Comm";

        public string CommText => "Comm";

        public string Total => "Total";

        public string TotalText => "Total";

        public string Company => "Company";

        public string CompanyText => "Company";

        public string SuperText => "Super";

        public List<Row> BodyRows { get; set; }
        public List<Row> FooterRows { get; set; }
        public List<Row> HeaderRows { get; set; }

        public GridViewModel(
            int bodyRowNumber = 100,
            bool withComplexColumnValue = false)
        {
            if (withComplexColumnValue)
            {
                this.AddBodyRowsWithComplexColumnValue(bodyRowNumber);
            }
            else
            {
                this.AddBodyRows(bodyRowNumber);
            }

            HeaderRows = GenerateHeaderRows();
            FooterRows = GenerateFooterRows();
        }

        private void AddBodyRows(int bodyRowNumber)
        {
            BodyRows = new List<Row>();
            for (int i = 0; i < bodyRowNumber; i++)
            {
                BodyRows.Add(
                    new Row()
                        .AddCell(new Cell(Master, RandomString(6)))
                        .AddCell(new Cell(Turnover, i * 10).SetTextAlign(TextAlign.Right))
                        .AddCell(new Cell(GrossComm, i * 1002).SetTextAlign(TextAlign.Right))
                        .AddCell(new Cell(MasterTotal, i * 12320).SetTextAlign(TextAlign.Right))
                        .AddCell(new Cell(WinLoss, i * 2).SetTextAlign(TextAlign.Right))
                        .AddCell(new Cell(Comm, i).SetTextAlign(TextAlign.Right))
                        .AddCell(new Cell(Total, i).SetTextAlign(TextAlign.Right))
                        .AddCell(new Cell(Company, i).SetTextAlign(TextAlign.Right)));
            }
        }

        private List<Row> GenerateFooterRows()
            => new List<Row>
            {
                new Row()
                        .AddCell(new Cell(Master, "total"))
                        .AddCell(new Cell(Turnover, "49,920.00"))
                        .AddCell(new Cell(GrossComm, "49,920.00"))
                        .AddCell(new Cell(MasterTotal, "49,920.00"))
                        .AddCell(new Cell(WinLoss, "49,920.00"))
                        .AddCell(new Cell(Comm, "49,920.00"))
                        .AddCell(new Cell(Total, "49,920.00"))
                        .AddCell(new Cell(Company, "49,920.00"))
            };

        private void AddBodyRowsWithComplexColumnValue(int bodyRowNumber)
        {
            BodyRows = new List<Row>();
            for (int i = 0; i < bodyRowNumber; i++)
            {
                BodyRows.Add(
                    new Row()
                        .AddCell(new Cell(Master, i))
                        .AddCell(new Cell(Turnover, RandomString(6)))
                        .AddCell(new Cell(GrossComm, random.Next()))
                        .AddCell(new Cell(MasterTotal, RandomString(3)))
                        .AddCell(new Cell(WinLoss, new ComplexColumnViewModel
                        {
                            IntValue = i
                        }))
                        .AddCell(new Cell(Comm, i))
                        .AddCell(new Cell(Total, i))
                        .AddCell(new Cell(Company, i))
                        .AddCell(new Cell(SuperText, i))
                        );
            }
        }

        private List<Row> GenerateHeaderRows()
            => new List<Row> {
                new Row()
                    .AddCell(new Cell(Master).SetHeaderText(MasterText).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
                    .AddCell(new Cell(Turnover).SetHeaderText(TurnoverText).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
                .AddCell(new Cell(GrossComm).SetHeaderText(GrossCommText).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
                .AddCell(new Cell(MasterTotal).SetHeaderText(MasterTotalText).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
                .AddCell(new Cell(WinLoss).SetHeaderText(SuperText).SetMergeColumnNumber(3).SetTextAlign(TextAlign.Center))
                .AddCell(new Cell(Company).SetHeaderText(CompanyText).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
            };

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


//namespace Fanex.Grid.Documentation
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Text;
//    using Fanex.Grid.HtmlHelperExtensions;
//    using Fanex.Grid.HtmlHelperExtensions.Enumerations;

//    public class GridViewModel
//    {
//        public string FirstColumnName => "firstColumn";

//        public string FirstColumnText => "First Column";

//        public string SecondColumnName => "secondColumn";

//        public string SecondColumnText => "Second Column";

//        public string ThirdColumnName => "thirdColumn";

//        public string ThirdColumnText => "Third Column";

//        public string FourthColumnName => "fourthColumn";

//        public string FourthColumnText => "Fourth Column";

//        public string FifthColumnName => "fifthColumn";

//        public string FifthColumnText => "Fifth Column";

//        public string SixthColumnName => "sixthColumn";

//        public string SixthColumnText => "Sixth Column";

//        public string SeventhColumnName => "seventhColumn";

//        public string SeventhColumnText => "Seventh Column";

//        public string EighthColumnName => "eighthColumn";

//        public string EighthColumnText => "Eighth Column";

//        public string NinthColumnName => "ninthColumn";

//        public string NinthColumnText => "Ninth Column";

//        public List<Row> BodyRows { get; set; }
//        public List<Row> FooterRows { get; set; }
//        public List<Row> HeaderRows { get; set; }

//        public GridViewModel(
//            int bodyRowNumber = 100,
//            bool withComplexColumnValue = false)
//        {
//            if (withComplexColumnValue)
//            {
//                this.AddBodyRowsWithComplexColumnValue(bodyRowNumber);
//            }
//            else
//            {
//                this.AddBodyRows(bodyRowNumber);
//            }

//            HeaderRows = GenerateHeaderRows();
//            FooterRows = GenerateFooterRows();
//        }

//        private void AddBodyRows(int bodyRowNumber)
//        {
//            BodyRows = new List<Row>();
//            for (int i = 0; i < bodyRowNumber; i++)
//            {
//                BodyRows.Add(
//                    new Row()
//                        .AddCell(new Cell(FirstColumnName, i))
//                        .AddCell(new Cell(SecondColumnName, RandomString(6)))
//                        .AddCell(new Cell(ThirdColumnName, random.Next()))
//                        .AddCell(new Cell(FourthColumnName, RandomString(3)))
//                        .AddCell(new Cell(FifthColumnName, i * 2))
//                        .AddCell(new Cell(SixthColumnName, i))
//                        .AddCell(new Cell(SeventhColumnName, i))
//                        .AddCell(new Cell(EighthColumnName, i))
//                        .AddCell(new Cell(NinthColumnName, i))
//                        );
//            }
//        }

//        private List<Row> GenerateFooterRows()
//            => new List<Row>
//            {
//                new Row()
//                        .AddCell(new Cell(FirstColumnName, 1).SetMergeRowNumber(2))
//                        .AddCell(new Cell(SecondColumnName, 2))
//                        .AddCell(new Cell(ThirdColumnName, 3).SetMergeColumnNumber(2))
//                        .AddCell(new Cell(FifthColumnName, 5).SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
//                        .AddCell(new Cell(SixthColumnName, 6).SetMergeColumnNumber(4)),
//                new Row()
//                        .AddCell(new Cell(SecondColumnName, 22))
//                        .AddCell(new Cell(ThirdColumnName, 3))
//                        .AddCell(new Cell(FourthColumnName, 4))
//                        .AddCell(new Cell(SixthColumnName, 6).SetMergeColumnNumber(2))
//                        .AddCell(new Cell(EighthColumnName, 8).SetMergeColumnNumber(2))
//            };

//        private void AddBodyRowsWithComplexColumnValue(int bodyRowNumber)
//        {
//            BodyRows = new List<Row>();
//            for (int i = 0; i < bodyRowNumber; i++)
//            {
//                BodyRows.Add(
//                    new Row()
//                        .AddCell(new Cell(FirstColumnName, i))
//                        .AddCell(new Cell(SecondColumnName, RandomString(6)))
//                        .AddCell(new Cell(ThirdColumnName, random.Next()))
//                        .AddCell(new Cell(FourthColumnName, RandomString(3)))
//                        .AddCell(new Cell(FifthColumnName, new ComplexColumnViewModel
//                        {
//                            IntValue = i
//                        }))
//                        .AddCell(new Cell(SixthColumnName, i))
//                        .AddCell(new Cell(SeventhColumnName, i))
//                        .AddCell(new Cell(EighthColumnName, i))
//                        .AddCell(new Cell(NinthColumnName, i))
//                        );
//            }
//        }

//        private List<Row> GenerateHeaderRows()
//            => new List<Row> {
//                new Row()
//                    .AddCell(new Cell(FirstColumnName).SetHeaderText("Group 1").SetMergeRowNumber(2).SetTextAlign(TextAlign.Center))
//                    .AddCell(new Cell(SecondColumnName).SetHeaderText(ThirdColumnText).SetMergeColumnNumber(8))
//            };

//        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden

//        private string RandomString(int size)
//        {
//            StringBuilder builder = new StringBuilder();
//            char ch;
//            for (int i = 0; i < size; i++)
//            {
//                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
//                builder.Append(ch);
//            }

//            return builder.ToString();
//        }
//    }
//}