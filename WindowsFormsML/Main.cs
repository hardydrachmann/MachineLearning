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
                inputDTO.BirthYear = Int32.Parse(tbBirthYear.Text);
                inputDTO.Sex = cbSex.Text;
                inputDTO.isClubMember = cbClubMember.Text;
                inputDTO.Movie = cbMovie.Text;
                inputDTO.Genre = cbGenre.Text;

                // TEST skal bruge en DTO på web apiet i stedet
                Prediction prediction = dao.GetPredictions(inputDTO);
            }
            else
            {
                MessageBox.Show("Der kan kun indtastes tal!\nPrøv venligst igen...");
            }
            tbBirthYear.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

    }
}
