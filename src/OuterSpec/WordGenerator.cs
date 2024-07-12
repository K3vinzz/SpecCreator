using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.IO;

namespace OuterSpec;

public class WordGenerator
{
    static void CreateWordDocumentWithTable(string filePath)
    {
        // Create a new Wordprocessing document
        using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
        {
            // Add a main document part
            MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();

            // Create the Document DOM
            mainPart.Document = new Document();
            Body body = mainPart.Document.AppendChild(new Body());

            // Add a table to the document
            Table table = new Table();

            // Define table properties
            TableProperties tblProps = new TableProperties(
                new TableBorders(
                    new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                    new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                    new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                    new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                    new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                    new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 }
                )
            );
            table.AppendChild(tblProps);

            // Define table columns
            TableGrid tableGrid = new TableGrid(
                new GridColumn { Width = "2000" },
                new GridColumn { Width = "2000" }
            );
            table.AppendChild(tableGrid);

            // Add rows and cells to the table
            string[,] data = {
                { "Header 1", "Header 2" },
                { "Row 1, Cell 1", "Row 1, Cell 2" },
                { "Row 2, Cell 1", "Row 2, Cell 2" },
                { "Row 3, Cell 1", "Row 3, Cell 2" }
            };

            foreach (var row in data)
            {
                TableRow tableRow = new TableRow();
                foreach (var cellText in row)
                {
                    TableCell tableCell = new TableCell();
                    Paragraph para = new Paragraph();
                    Run run = new Run(new Text(cellText.ToString()));
                    para.Append(run);
                    tableCell.Append(para);
                    tableRow.Append(tableCell);
                }
                table.Append(tableRow);
            }

            // Append the table to the body of the document
            body.Append(table);
        }
    }

}
