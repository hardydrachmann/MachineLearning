using Newtonsoft.Json.Linq;
using System;
using System.Windows.Forms;
using WindowsFormsML.DAL;
using WindowsFormsML.Models;
using WindowsFormsML.Properties;

namespace WindowsFormsML
{
    public partial class Main : Form
    {
        private DAO dao = new DAO();
        private Selection selection;
        private InputDTO inputDTO;

        private const int MIN_YEAR = 1920;
        private const int MAX_YEAR = 2013;

        public Main()
        {
            InitializeComponent();
            Load += new EventHandler(Main_Load);
        }

        private void Main_Load(object sender, System.EventArgs e)
        {
            populate();
        }

        public void populate()
        {
            selection = dao.GetSelections();

            foreach (var item in selection.Sex)
            {
                cbSex.Items.Add(item);
            }
            cbSex.SelectedIndex = 0;

            foreach (var item in selection.ClubMember)
            {
                cbClubMember.Items.Add(item);
            }
            cbClubMember.SelectedIndex = 0;

            foreach (var item in selection.Movie)
            {
                cbMovie.Items.Add(item);
            }
            cbMovie.SelectedIndex = 0;

            foreach (var item in selection.Genre)
            {
                cbGenre.Items.Add(item);
            }
            cbGenre.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            inputDTO = new InputDTO();

            int val;
            if (int.TryParse(tbBirthYear.Text, out val))
            {
                if (val <= MIN_YEAR || val >= MAX_YEAR)
                {
                    promptUser("Fejl!\nDet indtastede årstal er ikke gyldigt\nPrøv venligst igen...");
                }
                else
                {
                    inputDTO.BirthYear = Int32.Parse(tbBirthYear.Text);
                    inputDTO.Sex = cbSex.Text;
                    inputDTO.isClubMember = cbClubMember.Text;
                    if (!cbIncludeMovies.Checked)
                    {
                        inputDTO.Movie = "";
                    }
                    else
                    {
                        inputDTO.Movie = cbMovie.Text;
                    }
                    inputDTO.Genre = cbGenre.Text;

                    var results = dao.GetPredictions(inputDTO);

                    JObject obj = JObject.Parse(results);

                    lbGenre.Text = beautifyText(obj.SelectToken("Results").First.ToString());
                    lbMovie.Text = beautifyText(obj.SelectToken("Results").Last.ToString());
                }
            }
            else
            {
                promptUser("Fejl!\nFeltet skal indeholde et gyldigt årstal\nPrøv venligst igen...");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbGenre.Text = "Ingen data er sendt til modellen endnu...";
            lbMovie.Text = "Ingen data er sendt til modellen endnu...";
            tbBirthYear.Text = "";
        }

        private string beautifyText(string text)
        {
            var charsToRemove = new string[] { @"\", "\"", "[", "]", "{", "}", "Results", "Class", "Output (Genre):", "Output (Movie):" };
            foreach (var character in charsToRemove)
            {
                text = text.Replace(character, string.Empty);
            }
            return text;
        }

        private void promptUser(string input)
        {
            MessageBox.Show(input);
        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pbClose_MouseEnter(object sender, EventArgs e)
        {
            pbClose.BackgroundImage = Resources.Close_Red;
        }

        private void pbClose_MouseLeave(object sender, EventArgs e)
        {
            pbClose.BackgroundImage = Resources.Close;
        }

        private void pbMinimize_MouseEnter(object sender, EventArgs e)
        {
            pbMinimize.BackgroundImage = Resources.Minimize_Red;
        }

        private void pbMinimize_MouseLeave(object sender, EventArgs e)
        {
            pbMinimize.BackgroundImage = Resources.Minimize;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbIncludeMovies_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbIncludeMovies.Checked)
            {
                cbMovie.Enabled = false;
            }
            else
            {
                cbMovie.Enabled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cbSex.Items.Clear();
            cbClubMember.Items.Clear();
            cbMovie.Items.Clear();
            cbGenre.Items.Clear();
            populate();
        }

    }
}
