using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using CSV_To_SQLS.Classes;

namespace CSV_To_SQLS
{
    public partial class AddMovie : Form
    {
        public List<Movie> _movies;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_movies.Count <= 0)
            {                
                MessageBox.Show("You need to add movies", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(txtPdfName.Text))
            {
                MessageBox.Show("Enter THE name of the pdf", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPdfName.Focus();
                return;
            }

            try
            {
                Document document = new Document();
                string dtNow = DateTime.Now.ToString("dd.MM.yyyy");
                PdfWriter.GetInstance(document, new FileStream($"{Utils.FilePath+@"\PDF"}/{txtPdfName.Text}_{dtNow}.pdf", FileMode.Create));
                document.Open();
                Paragraph p = new Paragraph("Movies:");
                p.SpacingBefore = 10f; 
                p.SpacingAfter = 10f;
                p.Alignment = Element.ALIGN_CENTER; // Align table to center

                document.Add(p);


                PdfPTable table = new PdfPTable(3);
                table.WidthPercentage = 50; // Table width is 50% of the page
                table.HorizontalAlignment = Element.ALIGN_CENTER; // Align table to center

                // Add headers
                table.AddCell("Title");
                table.AddCell("Genre");
                table.AddCell("Release Date");

                // Add movie details
                foreach (var movie in _movies)
                {
                    table.AddCell(movie.Title);
                    table.AddCell(movie.Genre);
                    table.AddCell(movie.ReleaseDate.ToString());
                }

                document.Add(table);
                document.Close();
            }
            catch(Exception ex)
            {
               MessageBox.Show("Error:" + ex.Message,"Error", MessageBoxButtons.OK,MessageBoxIcon.Error); 
            }
        }                   
    }
}
