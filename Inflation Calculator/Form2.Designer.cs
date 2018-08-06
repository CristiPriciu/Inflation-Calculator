namespace Inflation_Calculator
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.txtCountryTxt = new System.Windows.Forms.TextBox();
            this.txtYearInput = new System.Windows.Forms.TextBox();
            this.txtPercentageInput = new System.Windows.Forms.TextBox();
            this.txtYearTxt = new System.Windows.Forms.TextBox();
            this.txtPercentageTxt = new System.Windows.Forms.TextBox();
            this.btnSendData = new System.Windows.Forms.Button();
            this.ddlCountryInput = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCountryTxt
            // 
            this.txtCountryTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCountryTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCountryTxt.Location = new System.Drawing.Point(37, 30);
            this.txtCountryTxt.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountryTxt.Name = "txtCountryTxt";
            this.txtCountryTxt.Size = new System.Drawing.Size(150, 19);
            this.txtCountryTxt.TabIndex = 0;
            this.txtCountryTxt.Text = "Country";
            this.txtCountryTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtYearInput
            // 
            this.txtYearInput.Location = new System.Drawing.Point(253, 58);
            this.txtYearInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearInput.Name = "txtYearInput";
            this.txtYearInput.Size = new System.Drawing.Size(148, 26);
            this.txtYearInput.TabIndex = 2;
            // 
            // txtPercentageInput
            // 
            this.txtPercentageInput.Location = new System.Drawing.Point(413, 58);
            this.txtPercentageInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentageInput.Name = "txtPercentageInput";
            this.txtPercentageInput.Size = new System.Drawing.Size(286, 26);
            this.txtPercentageInput.TabIndex = 3;
            // 
            // txtYearTxt
            // 
            this.txtYearTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.txtYearTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtYearTxt.Location = new System.Drawing.Point(253, 30);
            this.txtYearTxt.Margin = new System.Windows.Forms.Padding(4);
            this.txtYearTxt.Name = "txtYearTxt";
            this.txtYearTxt.Size = new System.Drawing.Size(150, 19);
            this.txtYearTxt.TabIndex = 4;
            this.txtYearTxt.Text = "Year";
            this.txtYearTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPercentageTxt
            // 
            this.txtPercentageTxt.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPercentageTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPercentageTxt.Location = new System.Drawing.Point(494, 30);
            this.txtPercentageTxt.Margin = new System.Windows.Forms.Padding(4);
            this.txtPercentageTxt.Name = "txtPercentageTxt";
            this.txtPercentageTxt.Size = new System.Drawing.Size(150, 19);
            this.txtPercentageTxt.TabIndex = 5;
            this.txtPercentageTxt.Text = "Percentage";
            this.txtPercentageTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSendData
            // 
            this.btnSendData.Location = new System.Drawing.Point(240, 102);
            this.btnSendData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(183, 63);
            this.btnSendData.TabIndex = 6;
            this.btnSendData.Text = "Send Data";
            this.btnSendData.UseVisualStyleBackColor = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // ddlCountryInput
            // 
            this.ddlCountryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCountryInput.FormattingEnabled = true;
            this.ddlCountryInput.Location = new System.Drawing.Point(18, 58);
            this.ddlCountryInput.Margin = new System.Windows.Forms.Padding(4);
            this.ddlCountryInput.Name = "ddlCountryInput";
            this.ddlCountryInput.Size = new System.Drawing.Size(224, 27);
            this.ddlCountryInput.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(681, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ddlCountryInput);
            this.Controls.Add(this.btnSendData);
            this.Controls.Add(this.txtPercentageTxt);
            this.Controls.Add(this.txtYearTxt);
            this.Controls.Add(this.txtPercentageInput);
            this.Controls.Add(this.txtYearInput);
            this.Controls.Add(this.txtCountryTxt);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminForm";
            this.Text = "Admin Area";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountryTxt;
        private System.Windows.Forms.TextBox txtYearInput;
        private System.Windows.Forms.TextBox txtPercentageInput;
        private System.Windows.Forms.TextBox txtYearTxt;
        private System.Windows.Forms.TextBox txtPercentageTxt;
        private System.Windows.Forms.Button btnSendData;
        private System.Windows.Forms.ComboBox ddlCountryInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}