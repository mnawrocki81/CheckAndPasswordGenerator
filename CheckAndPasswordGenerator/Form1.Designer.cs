namespace CheckAndPasswordGenerator
{
    partial class PasswordForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HowMuchSignTextBox = new System.Windows.Forms.TextBox();
            this.EnterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.GeneratorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxBCD = new System.Windows.Forms.CheckBox();
            this.checkBoxSign = new System.Windows.Forms.CheckBox();
            this.checkBox123 = new System.Windows.Forms.CheckBox();
            this.checkBoxabc = new System.Windows.Forms.CheckBox();
            this.CheckButton = new System.Windows.Forms.Button();
            this.GoodPasswordLabel = new System.Windows.Forms.Label();
            this.YourPasswordLabel = new System.Windows.Forms.Label();
            this.pictureBoxOK = new System.Windows.Forms.PictureBox();
            this.pictureBoxNotOK = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotOK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(58, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ile znaków ma mieć Twoje hasło?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(209, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "lub wpisz Hasło!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HowMuchSignTextBox
            // 
            this.HowMuchSignTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HowMuchSignTextBox.Location = new System.Drawing.Point(370, 47);
            this.HowMuchSignTextBox.Name = "HowMuchSignTextBox";
            this.HowMuchSignTextBox.Size = new System.Drawing.Size(35, 26);
            this.HowMuchSignTextBox.TabIndex = 2;
            this.HowMuchSignTextBox.TextChanged += new System.EventHandler(this.HowMuchSignTextBox_TextChanged);
            // 
            // EnterPasswordTextBox
            // 
            this.EnterPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EnterPasswordTextBox.Location = new System.Drawing.Point(370, 119);
            this.EnterPasswordTextBox.Name = "EnterPasswordTextBox";
            this.EnterPasswordTextBox.Size = new System.Drawing.Size(185, 26);
            this.EnterPasswordTextBox.TabIndex = 3;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Sitka Text", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TitleLabel.Location = new System.Drawing.Point(57, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(328, 30);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Generator i Sprawdzacz Haseł!";
            this.TitleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // GeneratorButton
            // 
            this.GeneratorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GeneratorButton.Location = new System.Drawing.Point(62, 112);
            this.GeneratorButton.Name = "GeneratorButton";
            this.GeneratorButton.Size = new System.Drawing.Size(126, 33);
            this.GeneratorButton.TabIndex = 5;
            this.GeneratorButton.Text = "Generuj";
            this.GeneratorButton.UseVisualStyleBackColor = true;
            this.GeneratorButton.Click += new System.EventHandler(this.GeneratorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(436, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Czy ma mieć?";
            // 
            // checkBoxBCD
            // 
            this.checkBoxBCD.AutoSize = true;
            this.checkBoxBCD.Checked = true;
            this.checkBoxBCD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBCD.Location = new System.Drawing.Point(574, 72);
            this.checkBoxBCD.Name = "checkBoxBCD";
            this.checkBoxBCD.Size = new System.Drawing.Size(56, 17);
            this.checkBoxBCD.TabIndex = 7;
            this.checkBoxBCD.Text = "ABC...";
            this.checkBoxBCD.UseVisualStyleBackColor = true;
            // 
            // checkBoxSign
            // 
            this.checkBoxSign.AutoSize = true;
            this.checkBoxSign.Checked = true;
            this.checkBoxSign.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSign.Location = new System.Drawing.Point(655, 72);
            this.checkBoxSign.Name = "checkBoxSign";
            this.checkBoxSign.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSign.TabIndex = 8;
            this.checkBoxSign.Text = "{![;@_?;,.";
            this.checkBoxSign.UseVisualStyleBackColor = true;
            // 
            // checkBox123
            // 
            this.checkBox123.AutoSize = true;
            this.checkBox123.Checked = true;
            this.checkBox123.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox123.Location = new System.Drawing.Point(574, 33);
            this.checkBox123.Name = "checkBox123";
            this.checkBox123.Size = new System.Drawing.Size(53, 17);
            this.checkBox123.TabIndex = 9;
            this.checkBox123.Text = "123...";
            this.checkBox123.UseVisualStyleBackColor = true;
            this.checkBox123.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBoxabc
            // 
            this.checkBoxabc.AutoSize = true;
            this.checkBoxabc.Checked = true;
            this.checkBoxabc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxabc.Location = new System.Drawing.Point(655, 33);
            this.checkBoxabc.Name = "checkBoxabc";
            this.checkBoxabc.Size = new System.Drawing.Size(53, 17);
            this.checkBoxabc.TabIndex = 10;
            this.checkBoxabc.Text = "abc...";
            this.checkBoxabc.UseVisualStyleBackColor = true;
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CheckButton.Location = new System.Drawing.Point(289, 212);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(219, 43);
            this.CheckButton.TabIndex = 11;
            this.CheckButton.Text = "Sprawdź swoje Hasło!";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // GoodPasswordLabel
            // 
            this.GoodPasswordLabel.AutoSize = true;
            this.GoodPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GoodPasswordLabel.Location = new System.Drawing.Point(59, 294);
            this.GoodPasswordLabel.Name = "GoodPasswordLabel";
            this.GoodPasswordLabel.Size = new System.Drawing.Size(355, 96);
            this.GoodPasswordLabel.TabIndex = 12;
            this.GoodPasswordLabel.Text = "Dobre hasło ma:\r\n-conajmniej  7 znaków, \r\n-minimum jedną małą literę, \r\n-minimum " +
    "jedną dużą literę;\r\n-minimum jedną cyfrę,\r\n-minimum jedne znak specjalny lub int" +
    "erpunkcyjny.\r\n";
            // 
            // YourPasswordLabel
            // 
            this.YourPasswordLabel.AutoSize = true;
            this.YourPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.YourPasswordLabel.Location = new System.Drawing.Point(597, 277);
            this.YourPasswordLabel.Name = "YourPasswordLabel";
            this.YourPasswordLabel.Size = new System.Drawing.Size(143, 20);
            this.YourPasswordLabel.TabIndex = 13;
            this.YourPasswordLabel.Text = "Twoje hasło jest:";
            this.YourPasswordLabel.Visible = false;
            // 
            // pictureBoxOK
            // 
            this.pictureBoxOK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOK.Image")));
            this.pictureBoxOK.Location = new System.Drawing.Point(628, 300);
            this.pictureBoxOK.Name = "pictureBoxOK";
            this.pictureBoxOK.Size = new System.Drawing.Size(80, 98);
            this.pictureBoxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOK.TabIndex = 14;
            this.pictureBoxOK.TabStop = false;
            this.pictureBoxOK.Visible = false;
            this.pictureBoxOK.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxNotOK
            // 
            this.pictureBoxNotOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxNotOK.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNotOK.Image")));
            this.pictureBoxNotOK.Location = new System.Drawing.Point(637, 300);
            this.pictureBoxNotOK.Name = "pictureBoxNotOK";
            this.pictureBoxNotOK.Size = new System.Drawing.Size(80, 98);
            this.pictureBoxNotOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNotOK.TabIndex = 15;
            this.pictureBoxNotOK.TabStop = false;
            this.pictureBoxNotOK.Visible = false;
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 419);
            this.Controls.Add(this.pictureBoxNotOK);
            this.Controls.Add(this.pictureBoxOK);
            this.Controls.Add(this.YourPasswordLabel);
            this.Controls.Add(this.GoodPasswordLabel);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.checkBoxabc);
            this.Controls.Add(this.checkBox123);
            this.Controls.Add(this.checkBoxSign);
            this.Controls.Add(this.checkBoxBCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GeneratorButton);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.EnterPasswordTextBox);
            this.Controls.Add(this.HowMuchSignTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PasswordForm";
            this.Text = "Hasło!!!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNotOK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HowMuchSignTextBox;
        private System.Windows.Forms.TextBox EnterPasswordTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button GeneratorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxBCD;
        private System.Windows.Forms.CheckBox checkBoxSign;
        private System.Windows.Forms.CheckBox checkBox123;
        private System.Windows.Forms.CheckBox checkBoxabc;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label GoodPasswordLabel;
        private System.Windows.Forms.Label YourPasswordLabel;
        private System.Windows.Forms.PictureBox pictureBoxOK;
        private System.Windows.Forms.PictureBox pictureBoxNotOK;
    }
}

