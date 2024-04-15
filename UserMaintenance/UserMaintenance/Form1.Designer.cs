namespace UserMaintenance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            RaktarButton = new Button();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            panel3 = new Panel();
            MentesButton = new Button();
            Db_helperLabel = new Label();
            Ar_helperLabel = new Label();
            Termekleiras_textBox = new RichTextBox();
            Keszlet_textBox = new TextBox();
            Termekar_textBox = new TextBox();
            Termeknev_textBox = new TextBox();
            KeszletLabel = new Label();
            TermekarLabel = new Label();
            TermekleirasLabel = new Label();
            TermeknevLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkTurquoise;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(RaktarButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 461);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.CadetBlue;
            pictureBox2.Image = Properties.Resources.output_onlinepngtools__1_;
            pictureBox2.Location = new Point(55, 140);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.MicrosoftTeams_image__1_;
            pictureBox1.Location = new Point(64, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 80);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // RaktarButton
            // 
            RaktarButton.BackColor = Color.CadetBlue;
            RaktarButton.FlatAppearance.BorderSize = 0;
            RaktarButton.FlatStyle = FlatStyle.Flat;
            RaktarButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            RaktarButton.ForeColor = SystemColors.ControlText;
            RaktarButton.Location = new Point(0, 133);
            RaktarButton.Margin = new Padding(0);
            RaktarButton.Name = "RaktarButton";
            RaktarButton.Size = new Size(250, 45);
            RaktarButton.TabIndex = 0;
            RaktarButton.Text = "Raktár";
            RaktarButton.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 461);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 231);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(488, 227);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.ForeColor = SystemColors.ControlDark;
            textBox1.Location = new Point(6, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(488, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Keresés...";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkTurquoise;
            panel3.Controls.Add(MentesButton);
            panel3.Controls.Add(Db_helperLabel);
            panel3.Controls.Add(Ar_helperLabel);
            panel3.Controls.Add(Termekleiras_textBox);
            panel3.Controls.Add(Keszlet_textBox);
            panel3.Controls.Add(Termekar_textBox);
            panel3.Controls.Add(Termeknev_textBox);
            panel3.Controls.Add(KeszletLabel);
            panel3.Controls.Add(TermekarLabel);
            panel3.Controls.Add(TermekleirasLabel);
            panel3.Controls.Add(TermeknevLabel);
            panel3.Location = new Point(750, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(239, 461);
            panel3.TabIndex = 1;
            // 
            // MentesButton
            // 
            MentesButton.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MentesButton.Location = new Point(63, 382);
            MentesButton.Name = "MentesButton";
            MentesButton.Size = new Size(121, 45);
            MentesButton.TabIndex = 11;
            MentesButton.Text = "Mentés";
            MentesButton.UseVisualStyleBackColor = true;
            // 
            // Db_helperLabel
            // 
            Db_helperLabel.AutoSize = true;
            Db_helperLabel.BackColor = SystemColors.Window;
            Db_helperLabel.Location = new Point(167, 313);
            Db_helperLabel.Name = "Db_helperLabel";
            Db_helperLabel.Size = new Size(21, 15);
            Db_helperLabel.TabIndex = 10;
            Db_helperLabel.Text = "db";
            // 
            // Ar_helperLabel
            // 
            Ar_helperLabel.AutoSize = true;
            Ar_helperLabel.BackColor = SystemColors.Window;
            Ar_helperLabel.Location = new Point(167, 237);
            Ar_helperLabel.Name = "Ar_helperLabel";
            Ar_helperLabel.Size = new Size(17, 15);
            Ar_helperLabel.TabIndex = 9;
            Ar_helperLabel.Text = "Ft";
            // 
            // Termekleiras_textBox
            // 
            Termekleiras_textBox.Location = new Point(24, 105);
            Termekleiras_textBox.Name = "Termekleiras_textBox";
            Termekleiras_textBox.Size = new Size(169, 96);
            Termekleiras_textBox.TabIndex = 8;
            Termekleiras_textBox.Text = "";
            // 
            // Keszlet_textBox
            // 
            Keszlet_textBox.Location = new Point(24, 310);
            Keszlet_textBox.Name = "Keszlet_textBox";
            Keszlet_textBox.Size = new Size(169, 23);
            Keszlet_textBox.TabIndex = 7;
            // 
            // Termekar_textBox
            // 
            Termekar_textBox.Location = new Point(24, 234);
            Termekar_textBox.Name = "Termekar_textBox";
            Termekar_textBox.Size = new Size(169, 23);
            Termekar_textBox.TabIndex = 6;
            // 
            // Termeknev_textBox
            // 
            Termeknev_textBox.Location = new Point(24, 52);
            Termeknev_textBox.Name = "Termeknev_textBox";
            Termeknev_textBox.Size = new Size(169, 23);
            Termeknev_textBox.TabIndex = 4;
            // 
            // KeszletLabel
            // 
            KeszletLabel.AutoSize = true;
            KeszletLabel.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            KeszletLabel.Location = new Point(24, 292);
            KeszletLabel.Name = "KeszletLabel";
            KeszletLabel.Size = new Size(63, 17);
            KeszletLabel.TabIndex = 3;
            KeszletLabel.Text = "Készlet";
            // 
            // TermekarLabel
            // 
            TermekarLabel.AutoSize = true;
            TermekarLabel.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TermekarLabel.Location = new Point(24, 216);
            TermekarLabel.Name = "TermekarLabel";
            TermekarLabel.Size = new Size(96, 17);
            TermekarLabel.TabIndex = 2;
            TermekarLabel.Text = "Termék ára";
            // 
            // TermekleirasLabel
            // 
            TermekleirasLabel.AutoSize = true;
            TermekleirasLabel.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TermekleirasLabel.Location = new Point(24, 87);
            TermekleirasLabel.Name = "TermekleirasLabel";
            TermekleirasLabel.Size = new Size(107, 17);
            TermekleirasLabel.TabIndex = 1;
            TermekleirasLabel.Text = "Termékleírás";
            // 
            // TermeknevLabel
            // 
            TermeknevLabel.AutoSize = true;
            TermeknevLabel.Font = new Font("Verdana", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TermeknevLabel.Location = new Point(24, 34);
            TermeknevLabel.Name = "TermeknevLabel";
            TermeknevLabel.Size = new Size(94, 17);
            TermeknevLabel.TabIndex = 0;
            TermeknevLabel.Text = "Terméknév";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(984, 461);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button RaktarButton;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private TextBox Keszlet_textBox;
        private TextBox Termekar_textBox;
        private TextBox textBox3;
        private TextBox Termeknev_textBox;
        private Label KeszletLabel;
        private Label TermekarLabel;
        private Label TermekleirasLabel;
        private Label TermeknevLabel;
        private RichTextBox Termekleiras_textBox;
        private Label Ar_helperLabel;
        private Label Db_helperLabel;
        private Button MentesButton;
        private PictureBox pictureBox2;
    }
}