using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CSV_To_SQLS.Classes;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using Image = iTextSharp.text.Image;
using Rectangle = iTextSharp.text.Rectangle;
using System.Diagnostics;
using System.Xml.Linq;

namespace CSV_To_SQLS
{
    public partial class AddMovie : Form
    {
        public List<Movie> _movies;
        readonly string DateTimeNow = DateTime.Now.ToString("dd.MM.yyyy");
        public AddMovie(List<Movie> movies)
        {
            InitializeComponent();
            dtReleaseDate.MinDate = DateTime.Now.AddDays(-1);
            _movies = movies;
            labelCount.Text = _movies.Count.ToString();
        }

        #region "Close this form"
        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTile.Text))
            {
                MessageBox.Show("Plese fill the Title field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusFirstTxtBox();
                return;
            }
            if (string.IsNullOrEmpty(txtGenre.Text))
            {
                MessageBox.Show("Plese fill the Genre field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGenre.Focus();
                return;
            }

            if (DateTime.Parse(dtReleaseDate.Text) < DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy")))
            {
                MessageBox.Show("Please select other date because you select a wrong date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtReleaseDate.Focus();
                return;
            }

            _movies.Add(new Movie
               {
                   Title = txtTile.Text,
                   Genre = txtGenre.Text,
                   ReleaseDate = DateTime.Parse(dtReleaseDate.Text),
               });

            ResetAllComponents();
            labelCount.Text = _movies.Count.ToString();
        }

        #region "Reset all components"
        void ResetAllComponents()
        {
            txtTile.Text = String.Empty;
            txtGenre.Text = String.Empty;
            dtReleaseDate.Text = DateTime.Now.ToString("dd.MM.yyyy");

            FocusFirstTxtBox();
        }
        #endregion

        #region "Focus fist text after save"
        void FocusFirstTxtBox()
        {
            txtTile.Focus();
        }
        #endregion

        #region "Hover and Leave"
        private void button1_MouseHover(object sender, EventArgs e)
        {
            //btnSaveMovie.ForeColor = Color.FromArgb(254, 254, 254);
            //btnSaveMovie.BackColor = Color.FromArgb(76, 111, 192);
        }
        private void btnSaveMovie_MouseLeave(object sender, EventArgs e)
        {
            //btnSaveMovie.ForeColor = Color.FromArgb(89, 92, 102);
            //btnSaveMovie.BackColor = Color.White;
        }
        #endregion  

        #region "Save to JSON FILE"
        private void button2_Click(object sender, EventArgs e)
        {
            string jsonFileName = txtPdfName.Text;

            if (_movies.Count <= 0)
            {
                MessageBox.Show("You need to add movies", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(jsonFileName)) 
            {
                MessageBox.Show("Enter the name of the json file", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPdfName.Focus();
                return;
            }
            
            string jsonFilePath = Utils.FilePath + $@"\JSON\{jsonFileName}_{DateTimeNow}.json";
            try
            {
                string json = JsonConvert.SerializeObject(_movies, Formatting.Indented);
                File.WriteAllText(jsonFilePath, json);
                MessageBox.Show("File saved successfully:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //byte[] bJson = File.ReadAllBytes(jsonFilePath);
                //var stream = new MemoryStream(bJson);

                //string decodeString = System.Text.Encoding.UTF8.GetString(bJson);
                //byte[] convertFromBase64StringToBytes = Convert.FromBase64String(decodeString);

                txtPdfName.Text = String.Empty;

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                    
        }
        #endregion

        #region "creating a pdf based on the data in the json file"
        private void btnJSONPDF_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    InitialDirectory = Utils.FilePath + @"\JSON",
                    Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                    RestoreDirectory = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = File.ReadAllText(openFileDialog.FileName);
                    _movies = JsonConvert.DeserializeObject<List<Movie>>(json);

                    MessageBox.Show("Movies loaded successfully!", "Infomration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region "Image path"
        private string GetPdfImagePath(string sImageName)
        {
            return Utils.GetFullResourcesPath(sImageName);
        }
        #endregion

        #region "Font path"
        private string GetRegularFontForPdf()
        {
            return Utils.GetFullFontPath("Poppins-Regular.ttf");

        }
        #endregion
        #region "Font path"
        private string GetBoldFontForPdf()
        {
            return Utils.GetFullFontPath("Poppins-Bold.ttf");

        }
        #endregion

        #region "Create pdf with values from movie json"
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_movies.Count <= 0)
            {
                MessageBox.Show("You need to add movies", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(txtPdfName.Text))
            {
                MessageBox.Show("Enter the name of the pdf file", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPdfName.Focus();
                return;
            }

            try
            {
                Document document = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                document.AddAuthor("@ME");
                document.AddCreator("Saple app using iTextSharp");
                document.AddKeywords("Template pdf");
                document.AddSubject("Documnet subject - Steps for creating this pdf...");
                document.AddTitle("Document title - Learning to create pdf");

                BaseFont poppinsRegular = BaseFont.CreateFont(GetRegularFontForPdf(), "Identity-H", BaseFont.EMBEDDED);
                BaseFont poppinsBold = BaseFont.CreateFont(GetBoldFontForPdf(), "Identity-H", BaseFont.EMBEDDED);

                iTextSharp.text.Font poppinsFontRegular = new iTextSharp.text.Font(poppinsRegular, 12);
                iTextSharp.text.Font poppinsFontBold = new iTextSharp.text.Font(poppinsBold, 12);

                PdfWriter.GetInstance(document, new FileStream($"{Utils.FilePath + @"\PDF"}/{txtPdfName.Text}_{DateTimeNow}.pdf", FileMode.Create));
                document.Open();

                // Header
                PdfPTable headerTable = new PdfPTable(2);
                headerTable.TotalWidth = 500;
                headerTable.DefaultCell.Border = Rectangle.NO_BORDER;

                // Image cell
                Image image = Image.GetInstance(GetPdfImagePath("pdf_red_16.png")); // Provide path to your image
                //Resize image depend upon your need
                image.ScaleToFit(50,50);

                //PdfPCell imageCell = new PdfPCell(image, true);
                //imageCell.Border = Rectangle.NO_BORDER;                
                //imageCell.HorizontalAlignment = Element.ALIGN_CENTER;
                
                headerTable.AddCell(image);

                //  Text cell
                PdfPCell textCell = new PdfPCell(new Phrase("Generate pdf exmple", poppinsFontBold));
                textCell.HorizontalAlignment = Element.ALIGN_CENTER;
                textCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                textCell.Border = Rectangle.NO_BORDER;
                headerTable.AddCell(textCell);

                headerTable.HorizontalAlignment = Element.ALIGN_CENTER;
                
                document.Add(headerTable);

                // Add space
                document.Add(new Paragraph(" "));

                // Movies
                PdfPTable moviesTable = new PdfPTable(3);
                moviesTable.WidthPercentage = 70; // Table width is 70% of the page

                // Add headers
                PdfPCell titleHeaderCell = new PdfPCell(new Phrase("Title", poppinsFontRegular));
                titleHeaderCell.HorizontalAlignment = Element.ALIGN_CENTER;
                titleHeaderCell.Border = Rectangle.BOTTOM_BORDER;
                moviesTable.AddCell(titleHeaderCell);

                PdfPCell genreHeaderCell = new PdfPCell(new Phrase("Genre", poppinsFontRegular));
                genreHeaderCell.HorizontalAlignment = Element.ALIGN_CENTER;
                genreHeaderCell.Border = Rectangle.BOTTOM_BORDER;
                moviesTable.AddCell(genreHeaderCell);

                PdfPCell releaseDateHeaderCell = new PdfPCell(new Phrase("Release Date", poppinsFontRegular));
                releaseDateHeaderCell.HorizontalAlignment = Element.ALIGN_CENTER;
                releaseDateHeaderCell.Border = Rectangle.BOTTOM_BORDER;
                moviesTable.AddCell(releaseDateHeaderCell);

                // Add movie details
                foreach (var movie in _movies)
                {
                    PdfPCell titleCell = new PdfPCell(new Phrase(movie.Title));
                    titleCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    titleCell.Border = Rectangle.NO_BORDER;
                    moviesTable.AddCell(titleCell);

                    PdfPCell genreCell = new PdfPCell(new Phrase(movie.Genre));
                    genreCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    genreCell.Border = Rectangle.NO_BORDER;
                    moviesTable.AddCell(genreCell);

                    PdfPCell releaseDateCell = new PdfPCell(new Phrase(movie.ReleaseDate.ToString("dd.MM.yyyy"), poppinsFontRegular));
                    releaseDateCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    releaseDateCell.Border = Rectangle.NO_BORDER;
                    moviesTable.AddCell(releaseDateCell);
                }

                document.Add(moviesTable);

                // Add space
                document.Add(new Paragraph(" "));

                // Button
                PdfPTable buttonTable = new PdfPTable(1);
                buttonTable.WidthPercentage = 100;
                buttonTable.DefaultCell.Border = Rectangle.NO_BORDER;

                PdfPCell buttonCell = new PdfPCell(new Phrase($"{DateTime.Now:dd.MM.yyyy}", poppinsFontBold));
                buttonCell.HorizontalAlignment = Element.ALIGN_CENTER;
                buttonCell.VerticalAlignment = Element.ALIGN_MIDDLE;
                buttonCell.Border = Rectangle.NO_BORDER;
                buttonTable.AddCell(buttonCell);

                buttonTable.HorizontalAlignment = Element.ALIGN_CENTER;
                document.Add(buttonTable);

                document.Close();

                MessageBox.Show("File saved successfully:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPdfName.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region "Back to select module form"
        private void pbBack_Click(object sender, EventArgs e)
        {
            //SelecModule selecModule = new SelecModule();
            //this.Hide();
            //selecModule.ShowDialog();
            this.Close();
        }
        #endregion

        #region""
        private void btnCustomPDF_Click(object sender, EventArgs e)
        {
            Document document = new Document(PageSize.A4, 20f, 20f, 20f, 20f);
            try
            {
                //Create custom PDF
                document.AddAuthor("@ME");
                document.AddCreator("Saple app using iTextSharp");
                document.AddKeywords("Template pdf");
                document.AddSubject("Documnet subject - Steps for creating this pdf...");
                document.AddTitle("Document title - Learning to create pdf");

                BaseFont poppinsRegular = BaseFont.CreateFont(GetRegularFontForPdf(), "Identity-H", BaseFont.EMBEDDED);
                BaseFont poppinsBold = BaseFont.CreateFont(GetBoldFontForPdf(), "Identity-H", BaseFont.EMBEDDED);

                iTextSharp.text.Font poppinsFontRegular = new iTextSharp.text.Font(poppinsRegular, 12);
                iTextSharp.text.Font poppinsFontBold = new iTextSharp.text.Font(poppinsBold, 12);

                PdfWriter.GetInstance(document, new FileStream($"{Utils.FilePath + @"\PDF"}/{txtPdfName.Text}_{DateTimeNow}.pdf", FileMode.Create));
                document.Open();

                //Header 
                PdfPTable headerTable = new PdfPTable(3);
                float[] columnWidths = { 2f, 2f, 1f }; 
                headerTable.SetWidths(columnWidths);
                headerTable.WidthPercentage = 90;


                PdfPTable cell1header = new PdfPTable(2);
                float[] columnWidths2 = { 0.5f, 0.5f }; 
                cell1header.SetWidths(columnWidths2);

                //Row1
                PdfPCell r1c1 = new PdfPCell(new Phrase("S.P", poppinsFontBold));
                r1c1.Padding = 5f;
                r1c1.Border = Rectangle.NO_BORDER;
                PdfPCell r1c2 = new PdfPCell(new Phrase("TEXT X", poppinsFontRegular));                
                r1c2.Padding = 5f;
                r1c2.Border = Rectangle.BOTTOM_BORDER;

                //Row2 
                PdfPTable pt1 = new PdfPTable(2);
                float[] columnWidths3 = { 0.5f, 0.5f };
                pt1.SetWidths(columnWidths3);
                PdfPCell pNr = new PdfPCell(new Phrase("Nr.", poppinsFontBold));              
                pNr.Border = Rectangle.NO_BORDER;
                PdfPCell pGetNr = new PdfPCell(new Phrase("4041", poppinsFontRegular));
                pGetNr.Border = Rectangle.BOTTOM_BORDER;
                pt1.AddCell(pNr);
                pt1.AddCell(pGetNr);

                PdfPTable pt2 = new PdfPTable(2);
                float[] columnWidths4 = { 0.5f, 0.5f }; // For example: 1:2:3 ratio
                pt2.SetWidths(columnWidths3);
                PdfPCell pDin = new PdfPCell(new Phrase("Din.", poppinsFontBold));
                pDin.Border = Rectangle.NO_BORDER;
                PdfPCell pGetDate = new PdfPCell(new Phrase($"{DateTime.Today.ToString("dd.MM.yyyy")}", poppinsFontRegular));
                pGetDate.Border = Rectangle.BOTTOM_BORDER;
                
                pt2.AddCell(pDin);
                pt2.AddCell(pGetDate);
                

                PdfPCell r2c1 = new PdfPCell(pt1);
               // r2c1.Padding = 5f;
                r2c1.Border = Rectangle.NO_BORDER;

                PdfPCell r2c2 = new PdfPCell(pt2);
                //r2c2.Padding = 5f;
                r2c2.Border = Rectangle.NO_BORDER;

                //row3
                PdfPCell r3c1 = new PdfPCell(new Phrase("Utilizator", poppinsFontBold));
                r3c1.Padding = 5f;
                r3c1.Border = Rectangle.NO_BORDER;

                PdfPCell r3c2 = new PdfPCell(new Phrase("TEXT X", poppinsFontRegular));
                r3c2.Padding = 5f;
                r3c2.Border = Rectangle.BOTTOM_BORDER;

                cell1header.AddCell(r1c1);
                cell1header.AddCell(r1c2);

                cell1header.AddCell(r2c1);
                cell1header.AddCell(r2c2);

                cell1header.AddCell(r3c1);
                cell1header.AddCell(r3c2);

                PdfPCell pdfCELL1 = new PdfPCell(cell1header);
                pdfCELL1.HorizontalAlignment = Element.ALIGN_LEFT;
                pdfCELL1.VerticalAlignment = Element.ALIGN_MIDDLE;
                //pdfCELL1.BackgroundColor = BaseColor.WHITE;

                //Cell 2 from header
                PdfPCell textCell = new PdfPCell();
                // Create a Paragraph to contain the phrases
                Paragraph paragraph = new Paragraph();
                paragraph.Alignment = Element.ALIGN_CENTER; // Set the alignment of the paragraph
                                                            // Add phrases to the paragraph
                Phrase phrase1 = new Phrase("AVIZAT", poppinsFontBold);
                Phrase phrase2 = new Phrase("TEXT X,", poppinsFontBold);
                paragraph.Add(phrase1);
                paragraph.Add(Chunk.NEWLINE); // Add a newline between phrases
                paragraph.Add(phrase2);

                // Add the paragraph to the cell
                textCell.AddElement(paragraph);

                // Set vertical alignment of the cell
                textCell.VerticalAlignment = Element.ALIGN_MIDDLE;

                //Cell 3 from header
                Image image2 = Image.GetInstance(GetPdfImagePath("pdf_red_512.png"));
                image2.ScaleToFit(15, 15);
                image2.SetAbsolutePosition(0, 0);

                PdfPCell imageCell2 = new PdfPCell(image2, true);
                //imageCell2.Width = 25;
                imageCell2.HorizontalAlignment = Element.ALIGN_RIGHT;
                imageCell2.VerticalAlignment = Element.ALIGN_MIDDLE;


                headerTable.HorizontalAlignment = Element.ALIGN_CENTER;

                headerTable.AddCell(pdfCELL1);
                headerTable.AddCell(textCell);
                headerTable.AddCell(image2);

                


                //Body
                //to do
                PdfPTable pBodyTitle= new PdfPTable(1);
                pBodyTitle.WidthPercentage = 90;
                
                string sBodyText = "TEXT X";
                
                PdfPCell pdfCell = new PdfPCell();
                pdfCell.Padding = 10f;
                pdfCell.Border = Rectangle.NO_BORDER;
                Paragraph parag = new Paragraph();
                parag.Alignment = Element.ALIGN_CENTER;
                
                Phrase phrase = new Phrase(sBodyText, poppinsFontBold);
                
                parag.Add(phrase);
                pdfCell.AddElement(parag);
                pBodyTitle.AddCell(pdfCell);

                //Buttom
                //to do


                document.Add(headerTable);
                document.Add(pBodyTitle);
                MessageBox.Show("File saved successfully:", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                document.Close();
            }
            

        }
        #endregion
    }
}
