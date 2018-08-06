namespace Inflation_Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.ddlCountry = new System.Windows.Forms.ComboBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.ddlStartYear = new System.Windows.Forms.ComboBox();
            this.ddlEndYear = new System.Windows.Forms.ComboBox();
            this.txtStartYear = new System.Windows.Forms.TextBox();
            this.txtEndYear = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtResultTxt = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlCountry
            // 
            this.ddlCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCountry.FormattingEnabled = true;
            this.ddlCountry.Location = new System.Drawing.Point(365, 60);
            this.ddlCountry.Margin = new System.Windows.Forms.Padding(4);
            this.ddlCountry.Name = "ddlCountry";
            this.ddlCountry.Size = new System.Drawing.Size(179, 27);
            this.ddlCountry.TabIndex = 0;
            this.ddlCountry.SelectedIndexChanged += new System.EventHandler(this.ddlCountry_SelectedIndexChanged);
            // 
            // txtCountry
            // 
            this.txtCountry.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountry.Location = new System.Drawing.Point(365, 33);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(181, 19);
            this.txtCountry.TabIndex = 1;
            this.txtCountry.Text = "Country";
            this.txtCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ddlStartYear
            // 
            this.ddlStartYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlStartYear.FormattingEnabled = true;
            this.ddlStartYear.Location = new System.Drawing.Point(556, 60);
            this.ddlStartYear.Margin = new System.Windows.Forms.Padding(4);
            this.ddlStartYear.Name = "ddlStartYear";
            this.ddlStartYear.Size = new System.Drawing.Size(179, 27);
            this.ddlStartYear.TabIndex = 2;
            // 
            // ddlEndYear
            // 
            this.ddlEndYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEndYear.FormattingEnabled = true;
            this.ddlEndYear.Location = new System.Drawing.Point(743, 60);
            this.ddlEndYear.Margin = new System.Windows.Forms.Padding(4);
            this.ddlEndYear.Name = "ddlEndYear";
            this.ddlEndYear.Size = new System.Drawing.Size(179, 27);
            this.ddlEndYear.TabIndex = 3;
            // 
            // txtStartYear
            // 
            this.txtStartYear.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStartYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtStartYear.Location = new System.Drawing.Point(556, 33);
            this.txtStartYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartYear.Name = "txtStartYear";
            this.txtStartYear.Size = new System.Drawing.Size(181, 19);
            this.txtStartYear.TabIndex = 4;
            this.txtStartYear.Text = "Start Year";
            this.txtStartYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEndYear
            // 
            this.txtEndYear.BackColor = System.Drawing.SystemColors.Menu;
            this.txtEndYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEndYear.Location = new System.Drawing.Point(746, 33);
            this.txtEndYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtEndYear.Name = "txtEndYear";
            this.txtEndYear.Size = new System.Drawing.Size(181, 19);
            this.txtEndYear.TabIndex = 5;
            this.txtEndYear.Text = "End Year";
            this.txtEndYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(668, 125);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(258, 26);
            this.txtInput.TabIndex = 6;
            // 
            // txtInputText
            // 
            this.txtInputText.BackColor = System.Drawing.SystemColors.Menu;
            this.txtInputText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInputText.Location = new System.Drawing.Point(479, 128);
            this.txtInputText.Margin = new System.Windows.Forms.Padding(4);
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(181, 19);
            this.txtInputText.TabIndex = 7;
            this.txtInputText.Text = "Input";
            this.txtInputText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResultTxt
            // 
            this.txtResultTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.txtResultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultTxt.Location = new System.Drawing.Point(479, 187);
            this.txtResultTxt.Margin = new System.Windows.Forms.Padding(4);
            this.txtResultTxt.Name = "txtResultTxt";
            this.txtResultTxt.Size = new System.Drawing.Size(181, 19);
            this.txtResultTxt.TabIndex = 8;
            this.txtResultTxt.Text = "Result";
            this.txtResultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(668, 184);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(258, 26);
            this.txtResult.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(710, 262);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(181, 47);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(501, 262);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(201, 47);
            this.btnAdmin.TabIndex = 11;
            this.btnAdmin.Text = "Admin Area";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(317, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 346);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtResultTxt);
            this.Controls.Add(this.txtInputText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtEndYear);
            this.Controls.Add(this.txtStartYear);
            this.Controls.Add(this.ddlEndYear);
            this.Controls.Add(this.ddlStartYear);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.ddlCountry);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inflation Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlCountry;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.ComboBox ddlStartYear;
        private System.Windows.Forms.ComboBox ddlEndYear;
        private System.Windows.Forms.TextBox txtStartYear;
        private System.Windows.Forms.TextBox txtEndYear;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtResultTxt;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

