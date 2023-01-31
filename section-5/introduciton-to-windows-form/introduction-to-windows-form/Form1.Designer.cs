namespace introduction_to_windows_form
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
            this.firstbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtn1 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBtn1 = new System.Windows.Forms.Button();
            this.comboBoxIndexSel = new System.Windows.Forms.Button();
            this.comboBtnSelectItem = new System.Windows.Forms.Button();
            this.comboBtnSelectedVal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstbutton
            // 
            this.firstbutton.BackColor = System.Drawing.Color.Gainsboro;
            this.firstbutton.ForeColor = System.Drawing.Color.Black;
            this.firstbutton.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.firstbutton.Location = new System.Drawing.Point(291, 303);
            this.firstbutton.MaximumSize = new System.Drawing.Size(500, 500);
            this.firstbutton.MinimumSize = new System.Drawing.Size(70, 70);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(70, 70);
            this.firstbutton.TabIndex = 0;
            this.firstbutton.Text = "My first button";
            this.firstbutton.UseVisualStyleBackColor = false;
            this.firstbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button2_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(185, 50);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(83, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "labelcontrol";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(62, 83);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(473, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 64);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "first bit of info";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(39, 328);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 377);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 35);
            this.textBox2.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(496, 366);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 27);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(110, 608);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 190);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(9, 106);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(9, 62);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "label3";
            // 
            // radioBtn1
            // 
            this.radioBtn1.AutoSize = true;
            this.radioBtn1.ForeColor = System.Drawing.Color.Black;
            this.radioBtn1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioBtn1.Location = new System.Drawing.Point(234, 526);
            this.radioBtn1.Name = "radioBtn1";
            this.radioBtn1.Size = new System.Drawing.Size(85, 17);
            this.radioBtn1.TabIndex = 13;
            this.radioBtn1.TabStop = true;
            this.radioBtn1.Text = "radioButton1";
            this.radioBtn1.UseVisualStyleBackColor = true;
            this.radioBtn1.CheckedChanged += new System.EventHandler(this.radioBtn1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(647, 639);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(647, 714);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(779, 433);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBtn1
            // 
            this.comboBtn1.Location = new System.Drawing.Point(779, 389);
            this.comboBtn1.Name = "comboBtn1";
            this.comboBtn1.Size = new System.Drawing.Size(156, 38);
            this.comboBtn1.TabIndex = 17;
            this.comboBtn1.Text = "Combo Button 1";
            this.comboBtn1.UseVisualStyleBackColor = true;
            this.comboBtn1.Click += new System.EventHandler(this.comboBtn1_Click);
            // 
            // comboBoxIndexSel
            // 
            this.comboBoxIndexSel.Location = new System.Drawing.Point(779, 345);
            this.comboBoxIndexSel.Name = "comboBoxIndexSel";
            this.comboBoxIndexSel.Size = new System.Drawing.Size(156, 38);
            this.comboBoxIndexSel.TabIndex = 18;
            this.comboBoxIndexSel.Text = "ComboBox Index Select";
            this.comboBoxIndexSel.UseVisualStyleBackColor = true;
            this.comboBoxIndexSel.Click += new System.EventHandler(this.comboBoxIndexSel_Click);
            // 
            // comboBtnSelectItem
            // 
            this.comboBtnSelectItem.Location = new System.Drawing.Point(779, 257);
            this.comboBtnSelectItem.Name = "comboBtnSelectItem";
            this.comboBtnSelectItem.Size = new System.Drawing.Size(156, 38);
            this.comboBtnSelectItem.TabIndex = 19;
            this.comboBtnSelectItem.Text = "ComboBox Item Select";
            this.comboBtnSelectItem.UseVisualStyleBackColor = true;
            // 
            // comboBtnSelectedVal
            // 
            this.comboBtnSelectedVal.Location = new System.Drawing.Point(779, 301);
            this.comboBtnSelectedVal.Name = "comboBtnSelectedVal";
            this.comboBtnSelectedVal.Size = new System.Drawing.Size(156, 38);
            this.comboBtnSelectedVal.TabIndex = 20;
            this.comboBtnSelectedVal.Text = "Combo Box Value Select";
            this.comboBtnSelectedVal.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(787, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(787, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "label5";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(540, 465);
            this.dateTimePicker1.MinDate = new System.DateTime(1869, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 23;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimeBtn
            // 
            this.dateTimeBtn.Location = new System.Drawing.Point(600, 511);
            this.dateTimeBtn.Name = "dateTimeBtn";
            this.dateTimeBtn.Size = new System.Drawing.Size(75, 23);
            this.dateTimeBtn.TabIndex = 24;
            this.dateTimeBtn.Text = "Date Time Button";
            this.dateTimeBtn.UseVisualStyleBackColor = true;
            this.dateTimeBtn.Click += new System.EventHandler(this.dateTimeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 587);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(537, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeBtn);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBtnSelectedVal);
            this.Controls.Add(this.comboBtnSelectItem);
            this.Controls.Add(this.comboBoxIndexSel);
            this.Controls.Add(this.comboBtn1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioBtn1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstbutton);
            this.Name = "Form1";
            this.Text = "Test form 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button firstbutton;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button comboBtn1;
        private System.Windows.Forms.Button comboBoxIndexSel;
        private System.Windows.Forms.Button comboBtnSelectItem;
        private System.Windows.Forms.Button comboBtnSelectedVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button dateTimeBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

