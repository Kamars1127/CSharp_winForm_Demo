using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AskingThingsSystem.Function
{
    public class ExportPDF
    {
        FormFunction form = new FormFunction();

        /*--- 產生PDF檔
         *
         *- 參數1: 檔案名稱
         *- 參數2: 檢視表
         *---------------------------------*/
        public void GeneratePDF(string fileName, DataGridView dataView)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF(*.pdf)|*.pdf";
            saveFile.FileName = fileName+".pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                CreatePDF(saveFile.FileName, fileName, dataView);
            }
        }

        /*--- 產生PDF檔
         *
         *- 參數1: 檔案名稱
         *- 參數2: 資料表
         *---------------------------------*/
        public void GeneratePDF(string fileName, DataTable dataTable)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF(*.pdf)|*.pdf";
            saveFile.FileName = fileName + ".pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                CreatePDF(saveFile.FileName, fileName, dataTable);
            }
        }


        private void CreatePDF(string fileName, string pdfTitle, DataGridView dataView)
        {
            /*- 取得標楷體 ttf檔位置 -*/
            string fontPath = @"E:\C_Sharp_WS\WindowsFormsApp1\WindowsFormsApp1\Font\kaiu.ttf";

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                /* Create a PdfWriter writing to the passed outputstream and with default writer properties. */
                PdfWriter pdfWriter = new PdfWriter(stream);
                /* Open PDF document in writing mode */
                PdfDocument pdfDoc = new PdfDocument(pdfWriter);
                /* Creates a document from a iText.Kernel.Pdf.PdfDocument
                 * with a manually set iText.Kernel.Geom.PageSize.
                 *------------------------------------------------------------*/
                Document doc = new Document(pdfDoc, PageSize.A4);
                doc.SetMargins(20f, 10f, 10f, 10f); //一次設定全部margin(top,right,bottom,left)

                /*-- 設定字體 --------------------------------------------------
                 *
                 *- 引數1: 字體路徑
                 *- 引數2: The Unicode encoding with horizontal writing
                 *- 引數3: 把字體嵌入到文檔中
                 *------------------------------------------------------------*/
                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H, true);

                /*-- 設定樣式 ----------------------
                 *『titleStyle』: PDF標題
                 *『cellStyle』: 儲存格樣式1
                 *『cellStyle2』: 儲存格樣式2
                 *--------------------------------*/
                Style titleStyle = new Style().SetFont(font).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER);
                Style cellStyle = new Style().SetFont(font).SetFontSize(11).SetTextAlignment(TextAlignment.CENTER);
                Style cellStyle2 = new Style().SetFont(font).SetFontSize(11).SetTextAlignment(TextAlignment.LEFT);

                /*-- 建立PDF標題 --*/
                doc.Add(new Paragraph(pdfTitle).AddStyle(titleStyle));
                /*-- 建立表格 --*/
                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 2, 5, 2, 3 }));
                table.UseAllAvailableWidth(); //table 佔滿整頁寬

                /*-- 表格的標題列 --*/
                foreach (DataGridViewColumn column in dataView.Columns)
                {
                    Cell cell = new Cell();
                    cell.Add(new Paragraph(column.HeaderText.ToString()));
                    cell.AddStyle(cellStyle);
                    table.AddCell(cell);
                }

                /*-- 表格的資料列 --*/
                foreach (DataGridViewRow row in dataView.Rows)
                {
                    Cell cell = new Cell(); //序號
                    Cell cell2 = new Cell(); //姓名
                    Cell cell3 = new Cell(); //紀錄事項
                    Cell cell4 = new Cell(); //聯絡電話
                    Cell cell5 = new Cell(); //備註
                    cell3.SetKeepTogether(true); //表格超過該頁不分割
                    cell5.SetKeepTogether(true); //表格超過該頁不分割

                    /*- 序號 -*/
                    cell.Add(new Paragraph(""));
                    cell.AddStyle(cellStyle);
                    table.AddCell(cell);

                    /*- 姓名 -*/
                    cell2.Add(new Paragraph(row.Cells[1].Value.ToString()));
                    cell2.AddStyle(cellStyle);
                    table.AddCell(cell2);

                    /*- 紀錄事項 -*/
                    cell3.Add(new Paragraph(row.Cells[2].Value.ToString()));
                    cell3.AddStyle(cellStyle2);
                    table.AddCell(cell3);

                    /*- 聯絡電話 -*/
                    cell4.Add(new Paragraph(row.Cells[3].Value.ToString()));
                    cell4.AddStyle(cellStyle);
                    table.AddCell(cell4);

                    /*- 備註 -*/
                    cell5.Add(new Paragraph(row.Cells[4].Value.ToString()));
                    cell5.AddStyle(cellStyle2);
                    table.AddCell(cell5);
                }

                doc.Add(table);
                doc.Close();
                stream.Close();

                form.OpenFocusForm(new Message.SuccessForm("匯出成功"));
            }
        }

        private void CreatePDF(string fileName, string pdfTitle, DataTable dataTable)
        {
            /*- 取得標楷體 ttf檔位置 -*/
            string fontPath = @"E:\C_Sharp_WS\WindowsFormsApp1\WindowsFormsApp1\Font\kaiu.ttf";
            
            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                PdfWriter pdfWriter = new PdfWriter(stream);
                PdfDocument pdfDoc = new PdfDocument(pdfWriter);
                Document doc = new Document(pdfDoc, PageSize.A4);
                doc.SetMargins(20f, 10f, 10f, 10f);
                
                /*-- 設定字體 --*/
                PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H, true);

                Style titleStyle = new Style().SetFont(font).SetFontSize(12).SetTextAlignment(TextAlignment.CENTER);
                Style cellStyle = new Style().SetFont(font).SetFontSize(11).SetTextAlignment(TextAlignment.CENTER);
                Style cellStyle2 = new Style().SetFont(font).SetFontSize(11).SetTextAlignment(TextAlignment.LEFT);

                /*- PDF標題 -*/
                doc.Add(new Paragraph(pdfTitle).AddStyle(titleStyle));

                /*- 建立表格 -*/
                Table table = new Table(UnitValue.CreatePercentArray(new float[] { 1, 2, 5, 2, 3 }));
                //table.UseAllAvailableWidth(); //table 佔滿整頁寬
                table.SetWidth(UnitValue.CreatePercentValue(100)); //table 佔滿整頁寬
                /*- 標題欄 -*/
                table.AddCell(new Cell().Add(new Paragraph("序號")).AddStyle(cellStyle));

                foreach (DataColumn column in dataTable.Columns)
                {
                    Cell cell = new Cell();
                    cell.Add(new Paragraph(column.ColumnName));
                    cell.AddStyle(cellStyle);
                    table.AddCell(cell);
                }

                /*- 資料列 -*/
                foreach (DataRow row in dataTable.Rows)
                {
                    Cell cell = new Cell();
                    Cell cell2 = new Cell();
                    Cell cell3 = new Cell();
                    Cell cell4 = new Cell();
                    Cell cell5 = new Cell();
                    cell3.SetKeepTogether(true); //表格超過該頁不分隔
                    cell5.SetKeepTogether(true); //表格超過該頁不分隔

                    /*- 序號 -*/
                    cell.Add(new Paragraph(""));
                    cell.AddStyle(cellStyle);
                    table.AddCell(cell);

                    /*- 姓名 -*/
                    cell2.Add(new Paragraph(row[0].ToString()));
                    cell2.AddStyle(cellStyle);
                    table.AddCell(cell2);

                    /*- 紀錄事項 -*/
                    cell3.Add(new Paragraph(row[1].ToString()));
                    cell3.AddStyle(cellStyle2);
                    table.AddCell(cell3);
                    /*- 聯絡電話 -*/
                    cell4.Add(new Paragraph(row[2].ToString()));
                    cell4.AddStyle(cellStyle);
                    table.AddCell(cell4);

                    /*- 備註 -*/
                    cell5.Add(new Paragraph(row[3].ToString()));
                    cell5.AddStyle(cellStyle2);
                    table.AddCell(cell5);
                    
                }
                doc.Add(table);
                doc.Close();
                stream.Close();
                
                form.OpenFocusForm(new Message.SuccessForm("匯出成功"));
            }
        }
    }
}
