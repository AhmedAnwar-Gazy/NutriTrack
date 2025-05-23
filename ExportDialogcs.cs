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
        private ListView myView;
        public ExportDialogcs(ListView items)
        {  this.myView=items;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

       public void ExportToPDF(
    List<(ListView listView, List<string> columns)> listViews,
    List<Chart> charts,
    List<string> paragraphs)
{
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

        // Add ListView tables
        if (listViews != null)
        {
            foreach (var (listView, columns) in listViews)
            {
                if (listView == null || columns == null || columns.Count == 0)
                    continue;

                var pdfTable = new PdfPTable(columns.Count);
                pdfTable.WidthPercentage = 100;

                // Add column headers
                foreach (var colName in columns)
                {
                    pdfTable.AddCell(new Phrase(colName));
                }

                // Add data rows
                foreach (ListViewItem item in listView.Items)
                {
                    foreach (var colName in columns)
                    {
                        int colIndex = listView.Columns.IndexOfKey(colName);
                        if (colIndex == -1 && int.TryParse(colName, out int numIndex))
                            colIndex = numIndex;

                        string cellValue = (colIndex >= 0 && colIndex < item.SubItems.Count)
                            ? item.SubItems[colIndex].Text
                            : "";

                        pdfTable.AddCell(new Phrase(cellValue));
                    }
                }

                pdfDoc.Add(pdfTable);
                pdfDoc.Add(iTextSharp.text.Chunk.NEWLINE);
            }
        }

        // Add charts
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
        MessageBox.Show($"PDF created but could not be opened automatically 😁😁: {ex.Message}");
    }
}


private void button1_Click(object sender, EventArgs e)
{var exportData = new List<(ListView, List<string>)>
    {
        (myView, new List<string> { "0", "1", "2" }) // using column indexes or names
    };
    if (radioButton2.Checked)
    {
        ExportToPDF(exportData, null, new List<string> { "This is a test report." });
    }
}
    }
}
