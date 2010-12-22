﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClosedXML.Excel;
using System.Drawing;


namespace ClosedXML_Examples.Styles
{
    public class DefaultStyles
    {
        public void Create(String filePath)
        {
            // The static default values are read-only so even if 
            // you try to change a referenced type, the changes will be discarded.
            var style = XLWorkbook.DefaultStyle;
            style.Border.DiagonalUp = true;
            style.Border.DiagonalDown = true;
            style.Border.DiagonalBorder = XLBorderStyleValues.Thick;
            style.Border.DiagonalBorderColor = XLColor.Red;

            // Create our workbook
            var workbook = new XLWorkbook();

            // This worksheet will have the default style, row height, column width, and page setup
            var ws1 = workbook.Worksheets.Add("Default Style");

            // Change the default row height for all new worksheets in this workbook
            workbook.RowHeight = 30;

            var ws2 = workbook.Worksheets.Add("Tall Rows");

            // Create a worksheet and change the default row height
            var ws3 = workbook.Worksheets.Add("Short Rows");
            ws3.RowHeight = 7.5;

            workbook.SaveAs(filePath);
        }
    }
}