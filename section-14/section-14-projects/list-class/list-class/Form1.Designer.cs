namespace list_class
{
    partial class btnFillList
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnFillListToTextBox = new System.Windows.Forms.Button();
            this.btnForEachTxtFill = new System.Windows.Forms.Button();
            this.btnAddEmployeetToList = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(210, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Fill List ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(43, 101);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 186);
            this.txtNumber.TabIndex = 1;
            // 
            // btnFillListToTextBox
            // 
            this.btnFillListToTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillListToTextBox.Location = new System.Drawing.Point(210, 90);
            this.btnFillListToTextBox.Name = "btnFillListToTextBox";
            this.btnFillListToTextBox.Size = new System.Drawing.Size(125, 130);
            this.btnFillListToTextBox.TabIndex = 2;
            this.btnFillListToTextBox.Text = "Fill List (To Text Box) FOR  LOOP";
            this.btnFillListToTextBox.UseVisualStyleBackColor = true;
            this.btnFillListToTextBox.Click += new System.EventHandler(this.btnFillListToTextBox_Click);
            // 
            // btnForEachTxtFill
            // 
            this.btnForEachTxtFill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForEachTxtFill.Location = new System.Drawing.Point(210, 243);
            this.btnForEachTxtFill.Name = "btnForEachTxtFill";
            this.btnForEachTxtFill.Size = new System.Drawing.Size(125, 116);
            this.btnForEachTxtFill.TabIndex = 3;
            this.btnForEachTxtFill.Text = "Fill List ( to text box ) FOR EACH LOOP";
            this.btnForEachTxtFill.UseVisualStyleBackColor = true;
            this.btnForEachTxtFill.Click += new System.EventHandler(this.btnForEachTxtFill_Click);
            // 
            // btnAddEmployeetToList
            // 
            this.btnAddEmployeetToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployeetToList.Location = new System.Drawing.Point(382, 12);
            this.btnAddEmployeetToList.Name = "btnAddEmployeetToList";
            this.btnAddEmployeetToList.Size = new System.Drawing.Size(123, 84);
            this.btnAddEmployeetToList.TabIndex = 4;
            this.btnAddEmployeetToList.Text = "Add Employees";
            this.btnAddEmployeetToList.UseVisualStyleBackColor = true;
            this.btnAddEmployeetToList.Click += new System.EventHandler(this.btnAddEmployeetToList_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(382, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 64);
            this.button3.TabIndex = 4;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(382, 243);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 64);
            this.button4.TabIndex = 4;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnFillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAddEmployeetToList);
            this.Controls.Add(this.btnForEachTxtFill);
            this.Controls.Add(this.btnFillListToTextBox);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.button1);
            this.Name = "btnFillList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtNumber;
		private System.Windows.Forms.Button btnFillListToTextBox;
		private System.Windows.Forms.Button btnForEachTxtFill;
		private System.Windows.Forms.Button btnAddEmployeetToList;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

