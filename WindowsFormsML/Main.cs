using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsML.BE;
using WindowsFormsML.DAL;
using WindowsFormsML.DTO;

namespace WindowsFormsML
{
    public partial class Main : Form
    {
        private DAO dao = new DAO();
        private Selection selection;
        private InputDTO inputDTO;

        private const int minYear = 1920;
        private const int maxYear = 2013;

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
                cbSex.Items.Add(item.Name);
            }
            cbSex.SelectedIndex = 0;

            foreach (var item in selection.isClubMember)
            {
                cbClubMember.Items.Add(item.IsMember);
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
                if (val <= minYear || val >= maxYear)
                {
                    promptUser("Fejl!\nDet indtastede årstal er ikke gyldigt\nPrøv venligst igen...");
                }
                else
                {
                    inputDTO.BirthYear = Int32.Parse(tbBirthYear.Text);
                    inputDTO.Sex = cbSex.Text;
                    inputDTO.isClubMember = cbClubMember.Text;
                    inputDTO.Movie = cbMovie.Text;
                    inputDTO.Genre = cbGenre.Text;

                    var results = dao.GetPredictions(inputDTO);

                    JObject obj = JObject.Parse(results);

                    tbGenre.Text = beautifyText(obj.SelectToken("Results").First.ToString());
                    tbMovie.Text = beautifyText(obj.SelectToken("Results").Last.ToString());

 
                }
            }
            else
            {
                promptUser("Fejl!\nFeltet skal indeholde et gyldigt årstal\nPrøv venligst igen...");
            }
            tbBirthYear.Text = "";
        }

        private string beautifyText(string text)
        {
            var charsToRemove = new string[] { @"\", "\"", "[", "]", "{", "}", "Results", "Output (Genre):", "Output (Movie):" };
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

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
