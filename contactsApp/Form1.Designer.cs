namespace contactsApp
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.lastnameInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searchName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.nameDetails = new System.Windows.Forms.TextBox();
            this.checkedBox = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lastnameInput, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.phoneInput, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.emailInput, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 126);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 33);
            this.label4.TabIndex = 3;
            this.label4.Text = "email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameInput
            // 
            this.nameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameInput.Location = new System.Drawing.Point(96, 3);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(276, 20);
            this.nameInput.TabIndex = 4;
            // 
            // lastnameInput
            // 
            this.lastnameInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastnameInput.Location = new System.Drawing.Point(96, 34);
            this.lastnameInput.Name = "lastnameInput";
            this.lastnameInput.Size = new System.Drawing.Size(276, 20);
            this.lastnameInput.TabIndex = 5;
            // 
            // phoneInput
            // 
            this.phoneInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneInput.Location = new System.Drawing.Point(96, 65);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(276, 20);
            this.phoneInput.TabIndex = 6;
            // 
            // emailInput
            // 
            this.emailInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailInput.Location = new System.Drawing.Point(96, 96);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(276, 20);
            this.emailInput.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(276, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "click to insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(96, 272);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(276, 23);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "click to search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchName
            // 
            this.searchName.Location = new System.Drawing.Point(96, 246);
            this.searchName.Name = "searchName";
            this.searchName.Size = new System.Drawing.Size(276, 20);
            this.searchName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "search for name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 246);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 20);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // nameDetails
            // 
            this.nameDetails.Location = new System.Drawing.Point(403, 246);
            this.nameDetails.Name = "nameDetails";
            this.nameDetails.ReadOnly = true;
            this.nameDetails.Size = new System.Drawing.Size(323, 20);
            this.nameDetails.TabIndex = 6;
            this.nameDetails.Text = "name details";
            // 
            // checkedBox
            // 
            this.checkedBox.AutoSize = true;
            this.checkedBox.Location = new System.Drawing.Point(12, 321);
            this.checkedBox.Name = "checkedBox";
            this.checkedBox.Size = new System.Drawing.Size(136, 17);
            this.checkedBox.TabIndex = 7;
            this.checkedBox.Text = "name details in text box";
            this.checkedBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedBox);
            this.Controls.Add(this.nameDetails);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.searchName);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox lastnameInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox searchName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox nameDetails;
        private System.Windows.Forms.CheckBox checkedBox;
    }
}

