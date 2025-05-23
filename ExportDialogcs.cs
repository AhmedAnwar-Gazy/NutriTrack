using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace NutriTrack
{
    public partial class ExportDialogcs : Form
    {
        public ExportDialogcs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }


        public void ExportToPDF(
    List<(DataGridView grid, List<string> columns)> grids,
    List<Chart> charts,
    List<string> paragraphs)
{
    // Let user choose file path with default name
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    string defaultFileName = $"Report_{DateTime.Now:dd-MMM-yyyy_HH-mm}.pdf";
    saveFileDialog.FileName = defaultFileName;
    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
    saveFileDialog.Title = "Save PDF Report";

    if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;

    string pdfFilePath = saveFileDialog.FileName;

    Document pdfDoc = new Document(PageSize.A4, 25, 25, 30, 30);

    try
    {
        PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(pdfFilePath, FileMode.Create));
        pdfDoc.Open();

        // Add paragraphs
        if (paragraphs != null)
        {
            foreach (var paraText in paragraphs)
            {
                Paragraph paragraph = new Paragraph(paraText);
                pdfDoc.Add(paragraph);
                pdfDoc.Add(iTextSharp.text.Chunk.NEWLINE);
            }
        }

        // Add DataGrids
        if (grids != null)
        {
            foreach (var (grid, columns) in grids)
            {
                if (grid == null) continue;

                var pdfTable = new PdfPTable(columns.Count);
                pdfTable.WidthPercentage = 100;

                foreach (var colName in columns)
                {
                    pdfTable.AddCell(new Phrase(colName));
                }

                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (var colName in columns)
                    {
                        var cellValue = row.Cells[colName]?.Value?.ToString() ?? "";
                        pdfTable.AddCell(new Phrase(cellValue));
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Add(iTextSharp.text.Chunk.NEWLINE);
            }
        }

        // Add Charts
        if (charts != null)
        {
            foreach (var chart in charts)
            {
                using (var ms = new MemoryStream())
                {
                    chart.SaveImage(ms, ChartImageFormat.Png);
                    iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(ms.ToArray());

                    chartImage.ScaleToFit(pdfDoc.PageSize.Width - pdfDoc.LeftMargin - pdfDoc.RightMargin, 300);
                    chartImage.Alignment = Element.ALIGN_CENTER;

                    pdfDoc.Add(chartImage);
                    pdfDoc.Add(iTextSharp.text.Chunk.NEWLINE);
                }
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error exporting PDF: {ex.Message}");
        return;
    }
    finally
    {
        pdfDoc.Close();
    }


    try
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = pdfFilePath,
            UseShellExecute = true
        });
    }
    catch (Exception ex)
    {
        MessageBox.Show($"PDF created but could not be opened automatically😁😁: {ex.Message}");
    }
}

        
        
    }
}
