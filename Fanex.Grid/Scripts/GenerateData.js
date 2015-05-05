/* File Created: January 23, 2013 */

function generateData(numberRows, autoHeight) {
    var rows = [];
    for (var index = 0; index < numberRows; index++) {
        var row = {
            Columns: [
                    { Name: "No", Value: index },
                    { Name: "Text1", Value: parseFloat((Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) },
                    { Name: "Number1", Value: parseFloat((Math.random() * 20000).toFixed(4)) },
                    { Name: "Number2", Value: parseFloat((Math.random() * 100).toFixed(2)) },
                    { Name: "Number3", Value: parseFloat((Math.random() * 500).toFixed(3)) },
                    { Name: "Text2", Value: Math.random().toString(36).substring(7) },
                    { Name: "Text3", Value: Math.random().toString(36).substring(8) },
                    { Name: "Text4", Value: Math.random().toString(36).substring(9) },
                    { Name: "Number4", Value: parseFloat((Math.random() * 1000).toFixed(3)) },
                    { Name: "Number5", Value: parseFloat((index % 2 == 0 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) }
                ],
            CssClass: 'custom-css-class',
            CustomAttr: '',
            SubRows: ''
        };
        if (autoHeight) {
            row.RowHeight = Math.random() * 100;
        }
        rows.push(row);
    }
    return rows;
}

function generateDataMoreColums(numberRows, autoHeight) {
    var rows = [];
    for (var index = 0; index < numberRows; index++) {
        var row = {
            Columns: [
                    { Name: "No", Value: index * 2 },
                    { Name: "Text1", Value: parseFloat((Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) },
                    { Name: "Number1", Value: parseFloat((Math.random() * 20000).toFixed(4)) },
                    { Name: "Number2", Value: parseFloat((Math.random() * 100).toFixed(2)) },
                    { Name: "Number3", Value: parseFloat((Math.random() * 500).toFixed(3)) },
                    { Name: "Text2", Value: Math.random().toString(36).substring(7) },
                    { Name: "Text3", Value: Math.random().toString(36).substring(8) },
                    { Name: "Text4", Value: Math.random().toString(36).substring(9) },
                    { Name: "Number4", Value: parseFloat((Math.random() * 1000).toFixed(3)) },
                    { Name: "Number5", Value: parseFloat((index % 2 == 0 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) },
                    { Name: "Text6", Value: Math.random().toString(36).substring(9) },
                    { Name: "Text7", Value: Math.random().toString(36).substring(9) },
                    { Name: "Text8", Value: Math.random().toString(36).substring(9) },
                    { Name: "Text9", Value: Math.random().toString(36).substring(9) },
                    { Name: "Text10", Value: Math.random().toString(36).substring(9) },
                    { Name: "Text11", Value: Math.random().toString(36).substring(9) },
                    { Name: "Text12", Value: Math.random().toString(36).substring(9) }
            ],
            CssClass: 'custom-css-class',
            CustomAttr: '',
            SubRows: ''
        };
        if (autoHeight) {
            row.RowHeight = Math.random() * 100;
        }
        rows.push(row);
    }
    return rows;
}


function generateLongData(numberRows) {
    var rows = [];
    for (var index = 0; index < numberRows; index++) {
        rows.push(
            {
                Columns: [
                    { Name: "No", Value: index * 2 },
                    { Name: "Text1", Value: parseFloat((Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) },
                    { Name: "Number1", Value: parseFloat((Math.random() * 20000).toFixed(4)) },
                    { Name: "Number2", Value: parseFloat((Math.random() * 100).toFixed(2)) },
                    { Name: "Number3", Value: parseFloat((Math.random() * 500).toFixed(3)) },
                    { Name: "Text2", Value: Math.random().toString(36).substring(8) + ' ' + Math.random().toString(36).substring(8) + ' ' + Math.random().toString(36).substring(8) + ' ' + Math.random().toString(36).substring(8) },
                    { Name: "Text3", Value: Math.random().toString(36).substring(8) },
                    { Name: "Text4", Value: Math.random().toString(36).substring(9) },
                    { Name: "Number4", Value: parseFloat((Math.random() * 1000).toFixed(3)) },
                    { Name: "Number5", Value: parseFloat((index % 2 == 0 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) }
                ],
                CssClass: '',
                CustomAttr: '',
                SubRows: ''
            }
        );
    }
    return rows;
}

function generateShortData(numberRows) {
    var rows = [];
    for (var index = 0; index < numberRows; index++) {
        rows.push(
            {
                Columns: [
                    { Name: "No", Value: index * 2 },
                    { Name: "Text1", Value: parseFloat((Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) },
                    { Name: "Number1", Value: parseFloat((Math.random() * 20000).toFixed(4)) },
                    { Name: "Number2", Value: parseFloat((Math.random() * 100).toFixed(2)) },
                    { Name: "Number3", Value: parseFloat((Math.random() * 500).toFixed(3)) }
                  ],
                CssClass: '',
                CustomAttr: '',
                SubRows: ''
            }
        );
    }
    return rows;
}

function generateTreeData(numberParentRows) {
    var rows = [];
    for (var index = 0; index < numberParentRows; index++) {
        var currentRow = {
            Columns: [
                    { Name: "No", Value: 'Group - ' + index, MergeColNumber: 3 },
                    { Name: "Number2", Value: 'Group - ' + index, MergeColNumber: 7 }
                ],
            SubRows: []
        }
        for (var j = 0; j < 5; j++) {
            var currentSubRow = {
                Columns: [
                    { Name: "No", Value: 'Group - ' + index + ' - ' + j, MergeColNumber: 3 },
                    { Name: "Number2", Value: 'Group - ' + index + ' - ' + j, MergeColNumber: 7 }
                ],
                SubRows: generateData(5),
                CssClass: 'sub-row-class'
            };
            currentRow.SubRows.push(currentSubRow);
        }
        if (index == 4) {
            currentRow.SubRows = [];
            
        }
        rows.push(currentRow);
    }
    return rows;
}

function generateDataMerged(numberRows) {
    var rows = [];
    var currentMerRowNumber = 0;
    var evenClass = '';
    for (var index = 0; index < numberRows; index++) {
        var currentColumms = [];

        if (currentMerRowNumber == 0) {
            currentMerRowNumber = Math.round(Math.random() * 5) + 2;
            //if(currentColumms + index < 0)
            currentColumms.push({ Name: "No", Value: index * 2, MergeRowNumber: currentMerRowNumber });
            if (evenClass == 'freegrid-even') {
                evenClass = '';
            }
            else {
                evenClass = 'freegrid-even';
            }
        }
        rows.push(
            {
                Columns: currentColumms.concat([
//                    { Name: "No", Value: index * 2 },
                    { Name: "Text1", Value: (Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3)) },
                    { Name: "Number1", Value: (Math.random() * 20000).toFixed(4), MergeColNumber: 2 },
//                    { Name: "Number2", Value: (Math.random() * 100).toFixed(2) },
                    { Name: "Number3", Value: (Math.random() * 500).toFixed(3) },
                    { Name: "Text2", Value: Math.random().toString(36).substring(7), MergeColNumber:3 },
                //  { Name: "Text3", Value: Math.random().toString(36).substring(8) },
//                    { Name: "Text4", Value: Math.random().toString(36).substring(9) },
                    { Name: "Number4", Value: (Math.random() * 1000).toFixed(3) },
                    { Name: "Number5", Value: (index % 2 == 0 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3)) }
                ]),
                CssClass: evenClass
            }
        );
            currentMerRowNumber--;
    }
    return rows;
}

function generateDataMergedForTruncate(numberRows) {
    var rows = [];
    var currentMerRowNumber = 0;
    var evenClass = '';
    for (var index = 0; index < numberRows; index++) {
        var currentColumms = [];

        if (currentMerRowNumber == 0) {
            currentMerRowNumber = Math.round(Math.random() * 5) + 2;
            //if(currentColumms + index < 0)
            currentColumms.push({ Name: "No", Value: "Very Long String.......................... end string.", MergeRowNumber: currentMerRowNumber });
            if (evenClass == 'freegrid-even') {
                evenClass = '';
            }
            else {
                evenClass = 'freegrid-even';
            }
        }
        rows.push(
            {
                Columns: currentColumms.concat([
                //                    { Name: "No", Value: index * 2 },
                    {Name: "Text1", Value: (Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3)) },
                    { Name: "Number1", Value: (Math.random() * 20000).toFixed(4), MergeColNumber: 2 },
                //                    { Name: "Number2", Value: (Math.random() * 100).toFixed(2) },
                    {Name: "Number3", Value: (Math.random() * 500).toFixed(3) },
                    { Name: "Text2", Value: Math.random().toString(36).substring(7), MergeColNumber: 3 },
                //  { Name: "Text3", Value: Math.random().toString(36).substring(8) },
                //                    { Name: "Text4", Value: Math.random().toString(36).substring(9) },
                    {Name: "Number4", Value: (Math.random() * 1000).toFixed(3) },
                    { Name: "Number5", Value: (index % 2 == 0 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3)) }
                ]),
                CssClass: evenClass
            }
        );
        currentMerRowNumber--;
    }
    return rows;
}

function generateDataTime(numberRows) {
    var rows = [];
    for (var index = 0; index < numberRows; index++) {
        rows.push(
            {
                Columns: [
                    { Name: "No", Value: index * 2 },
                    { Name: "Text1", Value: (Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3)) },
                    { Name: "Number1", Value: new Date() },
                    { Name: "Number2", Value: (Math.random() * 100).toFixed(2) },
                    { Name: "Number3", Value: (Math.random() * 500).toFixed(3) },
                    { Name: "Text2", Value: Math.random().toString(36).substring(7) },
                    { Name: "Text3", Value: Math.random().toString(36).substring(8) },
                    { Name: "Text4", Value: Math.random().toString(36).substring(9) },
                    { Name: "Number4", Value: (Math.random() * 1000).toFixed(3) },
                    { Name: "Number5", Value: (index % 2 == 0 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3)) }
                ]
            }
        );
    }
    return rows;
}


function generateLongColsData(numberRows) {
    var rows = [];
    for (var index = 0; index < numberRows; index++) {
        rows.push(
            {
                Columns: [
                    { Name: "No", Value: index * 2 },
                    { Name: "Text1", Value: parseFloat((Math.random() > 0.5 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) },
                    { Name: "Number1", Value: parseFloat((Math.random() * 20000).toFixed(4)) },
                    { Name: "Number2", Value: parseFloat((Math.random() * 100).toFixed(2)) },
                    { Name: "Number3", Value: parseFloat((Math.random() * 500).toFixed(3)) },
                    { Name: "Text2", Value: Math.random().toString(36).substring(7) },
                    { Name: "Text3", Value: Math.random().toString(36).substring(8) },
                    { Name: "Text4", Value: Math.random().toString(36).substring(9) },
                    { Name: "Number4", Value: parseFloat((Math.random() * 1000).toFixed(3)) },
                    { Name: "Number5", Value: parseFloat((index % 2 == 0 ? (Math.random() * 500).toFixed(3) : (Math.random() * 500 * -1).toFixed(3))) },
                    { Name: "No2", Value: index * 2 },
                    { Name: "No3", Value: index * 2 },
                    { Name: "No4", Value: index * 2 },
                    { Name: "No5", Value: index * 2 },
                    { Name: "No6", Value: index * 2 },
                    { Name: "No7", Value: index * 2 },
                    { Name: "No8", Value: index * 2 },
                    { Name: "No9", Value: index * 2 },
                    { Name: "No10", Value: index * 2 },
                    { Name: "No11", Value: index * 2 },
                    { Name: "No12", Value: index * 2 },
                    { Name: "No13", Value: index * 2 },
                    { Name: "No14", Value: index * 2 },
                    { Name: "No15", Value: index * 2 },
                    { Name: "No16", Value: index * 2 },
                    { Name: "No17", Value: index * 2 },
                    { Name: "No18", Value: index * 2 },
                    { Name: "No19", Value: index * 2 },
                    { Name: "No20", Value: index * 2 },
                    { Name: "No21", Value: index * 2 },
                    { Name: "No22", Value: index * 2 },
                    { Name: "No23", Value: index * 2 },
                    { Name: "No24", Value: index * 2 },
                    { Name: "No25", Value: index * 2 },
                    { Name: "No26", Value: index * 2 },
                    { Name: "No27", Value: index * 2 },
                    { Name: "No28", Value: index * 2 },
                    { Name: "No29", Value: index * 2 },
                    { Name: "No30", Value: index * 2 },
                    { Name: "No31", Value: index * 2 },
                    { Name: "No32", Value: index * 2 },
                    { Name: "No33", Value: index * 2 },
                    { Name: "No34", Value: index * 2 },
                    { Name: "No35", Value: index * 2 },
                    { Name: "No36", Value: index * 2 },
                    { Name: "No37", Value: index * 2 },
                    { Name: "No38", Value: index * 2 },
                    { Name: "No39", Value: index * 2 },
                    { Name: "No40", Value: index * 2 },
                    { Name: "No41", Value: index * 2 },
                    { Name: "No42", Value: index * 2 },
                    { Name: "No43", Value: index * 2 },
                    { Name: "No44", Value: index * 2 },
                    { Name: "No45", Value: index * 2 },
                    { Name: "No46", Value: index * 2 },
                    { Name: "No47", Value: index * 2 },
                    { Name: "No48", Value: index * 2 },
                    { Name: "No49", Value: index * 2 },
                    { Name: "No50", Value: index * 2 },
                    { Name: "No51", Value: index * 2 },
                    { Name: "No52", Value: index * 2 },
                    { Name: "No53", Value: index * 2 },
                    { Name: "No54", Value: index * 2 },
                    { Name: "No55", Value: index * 2 },
                    { Name: "No56", Value: index * 2 },
                    { Name: "No57", Value: index * 2 },
                    { Name: "No58", Value: index * 2 },
                    { Name: "No59", Value: index * 2 },
                    { Name: "No60", Value: index * 2 },
                    { Name: "No61", Value: index * 2 },
                    { Name: "No62", Value: index * 2 },
                    { Name: "No63", Value: index * 2 },
                    { Name: "No64", Value: index * 2 },
                    { Name: "No65", Value: index * 2 },
                    { Name: "No66", Value: index * 2 },
                    { Name: "No67", Value: index * 2 },
                    { Name: "No68", Value: index * 2 },
                    { Name: "No69", Value: index * 2 },
                    { Name: "No70", Value: index * 2 },
                    { Name: "No71", Value: index * 2 },
                    { Name: "No72", Value: index * 2 },
                    { Name: "No73", Value: index * 2 },
                    { Name: "No74", Value: index * 2 },
                    { Name: "No75", Value: index * 2 },
                    { Name: "No76", Value: index * 2 },
                    { Name: "No77", Value: index * 2 },
                    { Name: "No78", Value: index * 2 },
                    { Name: "No79", Value: index * 2 },
                    { Name: "No80", Value: index * 2 },
                    { Name: "No81", Value: index * 2 },
                    { Name: "No82", Value: index * 2 },
                    { Name: "No83", Value: index * 2 },
                    { Name: "No84", Value: index * 2 },
                    { Name: "No85", Value: index * 2 },
                    { Name: "No86", Value: index * 2 }
                ],
                CssClass: '',
                CustomAttr: '',
                SubRows: '',
                //RowHeight: Math.random() * 100
            }
        );
    }
    return rows;
}