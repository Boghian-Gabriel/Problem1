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
using iTextSharp.text.pdf.parser;
using Path = System.IO.Path;
using Font = iTextSharp.text.Font;

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
            if (String.IsNullOrEmpty(txtTile.Text))
            {
                MessageBox.Show("Plese fill the Title field", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FocusFirstTxtBox();
                return;
            }
            if (String.IsNullOrEmpty(txtGenre.Text))
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
            btnSaveMovie.ForeColor = Color.FromArgb(254, 254, 254);
            btnSaveMovie.BackColor = Color.FromArgb(76, 111, 192);
        }
        private void btnSaveMovie_MouseLeave(object sender, EventArgs e)
        {
            btnSaveMovie.ForeColor = Color.FromArgb(89, 92, 102);
            btnSaveMovie.BackColor = Color.White;
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
        private string GetPdfImagePath()
        {
            return Utils.GetFullResourcesPath("pdf_red_512.png");
        }
        #endregion

        #region "Font path"
        private string GetFontForPdf()
        {
            return Utils.GetFullFontPath("Poppins-Regular.ttf");

        }
        #endregion


        #region " Crete pdf"
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

                var ASD = GetFontForPdf();

                BaseFont baseFont = BaseFont.CreateFont(GetFontForPdf(), "Identity-H", BaseFont.EMBEDDED);

                iTextSharp.text.Font poppinsFont = new iTextSharp.text.Font(baseFont, 12);
                PdfWriter.GetInstance(document, new FileStream($"{Utils.FilePath + @"\PDF"}/{txtPdfName.Text}_{DateTimeNow}.pdf", FileMode.Create));
                document.Open();

                // Header
                PdfPTable headerTable = new PdfPTable(2);
                headerTable.TotalWidth = 500;
                headerTable.DefaultCell.Border = Rectangle.NO_BORDER;

                // Image cell
                Image image = Image.GetInstance(GetPdfImagePath()); // Provide path to your image
                //Resize image depend upon your need
                image.ScaleToFit(140f, 120f);

                PdfPCell imageCell = new PdfPCell(image, true);
                imageCell.Border = Rectangle.NO_BORDER;
                imageCell.HorizontalAlignment = Element.ALIGN_CENTER;
                
                headerTable.AddCell(imageCell);

                // Text cell
                PdfPCell textCell = new PdfPCell(new Phrase("Generate pdf exmple", poppinsFont));
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
                PdfPCell titleHeaderCell = new PdfPCell(new Phrase("Title", poppinsFont));
                titleHeaderCell.HorizontalAlignment = Element.ALIGN_CENTER;
                titleHeaderCell.Border = Rectangle.BOTTOM_BORDER;
                moviesTable.AddCell(titleHeaderCell);

                PdfPCell genreHeaderCell = new PdfPCell(new Phrase("Genre", poppinsFont));
                genreHeaderCell.HorizontalAlignment = Element.ALIGN_CENTER;
                genreHeaderCell.Border = Rectangle.BOTTOM_BORDER;
                moviesTable.AddCell(genreHeaderCell);

                PdfPCell releaseDateHeaderCell = new PdfPCell(new Phrase("Release Date", poppinsFont));
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

                    PdfPCell releaseDateCell = new PdfPCell(new Phrase(movie.ReleaseDate.ToString("dd.MM.yyyy"),poppinsFont));
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

                PdfPCell buttonCell = new PdfPCell(new Phrase($"{DateTime.Now:dd.MM.yyyy}"));
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
    }
}
