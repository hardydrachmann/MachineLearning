using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsML
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbGenre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbMovie = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbClubMember = new System.Windows.Forms.ComboBox();
            this.cbMovie = new System.Windows.Forms.ComboBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.cbIncludeMovies = new System.Windows.Forms.CheckBox();
            this.panelMovie = new System.Windows.Forms.Panel();
            this.panelGenre = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGenre = new System.Windows.Forms.PictureBox();
            this.pbMovie = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelMovie.SuspendLayout();
            this.panelGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(98, 140);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(211, 21);
            this.cbSex.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machine Learning";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Køn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fødselsår";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Film";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Klubmedlem";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(315, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(576, 472);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelGenre);
            this.tabPage1.Controls.Add(this.pbGenre);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genre";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGenre.Location = new System.Drawing.Point(3, 0);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(0, 20);
            this.lbGenre.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelMovie);
            this.tabPage2.Controls.Add(this.pbMovie);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 446);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Film";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbMovie
            // 
            this.lbMovie.AutoSize = true;
            this.lbMovie.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMovie.Location = new System.Drawing.Point(3, 0);
            this.lbMovie.Name = "lbMovie";
            this.lbMovie.Size = new System.Drawing.Size(0, 20);
            this.lbMovie.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(732, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "Sandsynligheder";
            // 
            // cbClubMember
            // 
            this.cbClubMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClubMember.FormattingEnabled = true;
            this.cbClubMember.Location = new System.Drawing.Point(98, 175);
            this.cbClubMember.Name = "cbClubMember";
            this.cbClubMember.Size = new System.Drawing.Size(211, 21);
            this.cbClubMember.TabIndex = 13;
            // 
            // cbMovie
            // 
            this.cbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMovie.FormattingEnabled = true;
            this.cbMovie.Location = new System.Drawing.Point(98, 210);
            this.cbMovie.Name = "cbMovie";
            this.cbMovie.Size = new System.Drawing.Size(211, 21);
            this.cbMovie.TabIndex = 14;
            // 
            // cbGenre
            // 
            this.cbGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(98, 266);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(211, 21);
            this.cbGenre.TabIndex = 15;
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.Location = new System.Drawing.Point(98, 104);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(211, 20);
            this.tbBirthYear.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 2);
            this.panel1.TabIndex = 19;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SkyBlue;
            this.btnReset.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(144, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "Nulstil";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.Location = new System.Drawing.Point(234, 316);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 30);
            this.btnCalculate.TabIndex = 26;
            this.btnCalculate.Text = "Beregn";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cbIncludeMovies
            // 
            this.cbIncludeMovies.AutoSize = true;
            this.cbIncludeMovies.Checked = true;
            this.cbIncludeMovies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeMovies.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIncludeMovies.Location = new System.Drawing.Point(98, 237);
            this.cbIncludeMovies.Name = "cbIncludeMovies";
            this.cbIncludeMovies.Size = new System.Drawing.Size(87, 20);
            this.cbIncludeMovies.TabIndex = 28;
            this.cbIncludeMovies.Text = "Inkluder Film";
            this.cbIncludeMovies.UseVisualStyleBackColor = true;
            this.cbIncludeMovies.CheckedChanged += new System.EventHandler(this.cbIncludeMovies_CheckedChanged);
            // 
            // panelMovie
            // 
            this.panelMovie.AutoScroll = true;
            this.panelMovie.Controls.Add(this.lbMovie);
            this.panelMovie.Location = new System.Drawing.Point(6, 6);
            this.panelMovie.Name = "panelMovie";
            this.panelMovie.Size = new System.Drawing.Size(556, 434);
            this.panelMovie.TabIndex = 4;
            // 
            // panelGenre
            // 
            this.panelGenre.AutoScroll = true;
            this.panelGenre.Controls.Add(this.lbGenre);
            this.panelGenre.Location = new System.Drawing.Point(6, 6);
            this.panelGenre.Name = "panelGenre";
            this.panelGenre.Size = new System.Drawing.Size(556, 434);
            this.panelGenre.TabIndex = 5;
            // 
            // pbMinimize
            // 
            this.pbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.pbMinimize.BackgroundImage = global::WindowsFormsML.Properties.Resources.Minimize;
            this.pbMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMinimize.Location = new System.Drawing.Point(845, 9);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(20, 20);
            this.pbMinimize.TabIndex = 18;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.BackgroundImage = global::WindowsFormsML.Properties.Resources.Close;
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbClose.Location = new System.Drawing.Point(871, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(20, 20);
            this.pbClose.TabIndex = 17;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsML.Properties.Resources.Main;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(11, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 157);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbGenre
            // 
            this.pbGenre.BackgroundImage = global::WindowsFormsML.Properties.Resources.CalculateWithOpacity;
            this.pbGenre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGenre.Location = new System.Drawing.Point(6, 6);
            this.pbGenre.Name = "pbGenre";
            this.pbGenre.Size = new System.Drawing.Size(556, 434);
            this.pbGenre.TabIndex = 3;
            this.pbGenre.TabStop = false;
            // 
            // pbMovie
            // 
            this.pbMovie.BackgroundImage = global::WindowsFormsML.Properties.Resources.CalculateWithOpacity;
            this.pbMovie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMovie.Location = new System.Drawing.Point(6, 6);
            this.pbMovie.Name = "pbMovie";
            this.pbMovie.Size = new System.Drawing.Size(556, 434);
            this.pbMovie.TabIndex = 2;
            this.pbMovie.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 564);
            this.Controls.Add(this.cbIncludeMovies);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbMinimize);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.cbGenre);
            this.Controls.Add(this.cbMovie);
            this.Controls.Add(this.cbClubMember);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Machine Learning";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelMovie.ResumeLayout(false);
            this.panelMovie.PerformLayout();
            this.panelGenre.ResumeLayout(false);
            this.panelGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbClubMember;
        private System.Windows.Forms.ComboBox cbMovie;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox tbBirthYear;
        private PictureBox pictureBox1;
        private PictureBox pbClose;
        private PictureBox pbMinimize;
        private Panel panel1;
        private PictureBox pbMovie;
        private Button btnReset;
        private Button btnCalculate;
        private PictureBox pbGenre;
        private Label lbGenre;
        private Label lbMovie;
        private CheckBox cbIncludeMovies;
        private Panel panelMovie;
        private Panel panelGenre;
    }
}