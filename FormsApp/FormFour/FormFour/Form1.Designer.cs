namespace FormFour
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.firstNameID = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.lastNameID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countries = new System.Windows.Forms.ComboBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.phoneID = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(509, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // firstNameID
            // 
            this.firstNameID.AutoSize = true;
            this.firstNameID.Location = new System.Drawing.Point(209, 160);
            this.firstNameID.Name = "firstNameID";
            this.firstNameID.Size = new System.Drawing.Size(72, 16);
            this.firstNameID.TabIndex = 1;
            this.firstNameID.Text = "First Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(314, 153);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(234, 22);
            this.firstNameText.TabIndex = 2;
            this.firstNameText.Text = "Enter your first name";
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(314, 193);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(234, 22);
            this.lastNameText.TabIndex = 4;
            this.lastNameText.Text = "Enter your last name";
            // 
            // lastNameID
            // 
            this.lastNameID.AutoSize = true;
            this.lastNameID.Location = new System.Drawing.Point(209, 200);
            this.lastNameID.Name = "lastNameID";
            this.lastNameID.Size = new System.Drawing.Size(72, 16);
            this.lastNameID.TabIndex = 3;
            this.lastNameID.Text = "Last Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Country";
            // 
            // countries
            // 
            this.countries.FormattingEnabled = true;
            this.countries.Items.AddRange(new object[] {
            "South Africa",
            "Angola",
            "Zimbabwe",
            "Zambia",
            "Botswana",
            "Mozambique",
            "Swaziland",
            "Lesotho",
            "Botswana"});
            this.countries.Location = new System.Drawing.Point(314, 238);
            this.countries.Name = "countries";
            this.countries.Size = new System.Drawing.Size(234, 24);
            this.countries.TabIndex = 6;
            this.countries.Text = "Select countries";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(314, 281);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(234, 22);
            this.phoneText.TabIndex = 8;
            this.phoneText.Text = "Enter your phone";
            // 
            // phoneID
            // 
            this.phoneID.AutoSize = true;
            this.phoneID.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.phoneID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.phoneID.Location = new System.Drawing.Point(209, 287);
            this.phoneID.Name = "phoneID";
            this.phoneID.Size = new System.Drawing.Size(46, 16);
            this.phoneID.TabIndex = 7;
            this.phoneID.Text = "Phone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(613, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(536, 317);
            this.dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(212, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "VIEW";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Red;
            this.buttonUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(408, 422);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(140, 48);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(212, 345);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 48);
            this.button3.TabIndex = 12;
            this.button3.Text = "ADD";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(408, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 48);
            this.button4.TabIndex = 13;
            this.button4.Text = "REMOVE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 575);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.phoneID);
            this.Controls.Add(this.countries);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.lastNameID);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.firstNameID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label firstNameID;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label lastNameID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox countries;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label phoneID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

