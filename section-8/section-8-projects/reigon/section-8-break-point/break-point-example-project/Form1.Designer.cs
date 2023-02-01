namespace break_point_example_project
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
            this.lblMidtermExam = new System.Windows.Forms.Label();
            this.lblFinalExam = new System.Windows.Forms.Label();
            this.lblGPT = new System.Windows.Forms.Label();
            this.txtBoxMidtermExam = new System.Windows.Forms.TextBox();
            this.txtBoxFinalExam = new System.Windows.Forms.TextBox();
            this.txtBoxGPT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMidtermExam
            // 
            this.lblMidtermExam.AutoSize = true;
            this.lblMidtermExam.Location = new System.Drawing.Point(84, 58);
            this.lblMidtermExam.Name = "lblMidtermExam";
            this.lblMidtermExam.Size = new System.Drawing.Size(73, 13);
            this.lblMidtermExam.TabIndex = 0;
            this.lblMidtermExam.Text = "Midterm Exam";
            // 
            // lblFinalExam
            // 
            this.lblFinalExam.AutoSize = true;
            this.lblFinalExam.Location = new System.Drawing.Point(84, 87);
            this.lblFinalExam.Name = "lblFinalExam";
            this.lblFinalExam.Size = new System.Drawing.Size(59, 13);
            this.lblFinalExam.TabIndex = 1;
            this.lblFinalExam.Text = "FInal Exam";
            // 
            // lblGPT
            // 
            this.lblGPT.AutoSize = true;
            this.lblGPT.Location = new System.Drawing.Point(84, 161);
            this.lblGPT.Name = "lblGPT";
            this.lblGPT.Size = new System.Drawing.Size(29, 13);
            this.lblGPT.TabIndex = 2;
            this.lblGPT.Text = "GPT";
            // 
            // txtBoxMidtermExam
            // 
            this.txtBoxMidtermExam.Location = new System.Drawing.Point(175, 51);
            this.txtBoxMidtermExam.Name = "txtBoxMidtermExam";
            this.txtBoxMidtermExam.Size = new System.Drawing.Size(100, 20);
            this.txtBoxMidtermExam.TabIndex = 3;
            this.txtBoxMidtermExam.TextChanged += new System.EventHandler(this.txtBoxMidtermExam_TextChanged);
            // 
            // txtBoxFinalExam
            // 
            this.txtBoxFinalExam.Location = new System.Drawing.Point(175, 80);
            this.txtBoxFinalExam.Name = "txtBoxFinalExam";
            this.txtBoxFinalExam.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFinalExam.TabIndex = 4;
            // 
            // txtBoxGPT
            // 
            this.txtBoxGPT.Location = new System.Drawing.Point(175, 158);
            this.txtBoxGPT.Name = "txtBoxGPT";
            this.txtBoxGPT.Size = new System.Drawing.Size(100, 20);
            this.txtBoxGPT.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(175, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxGPT);
            this.Controls.Add(this.txtBoxFinalExam);
            this.Controls.Add(this.txtBoxMidtermExam);
            this.Controls.Add(this.lblGPT);
            this.Controls.Add(this.lblFinalExam);
            this.Controls.Add(this.lblMidtermExam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMidtermExam;
        private System.Windows.Forms.Label lblFinalExam;
        private System.Windows.Forms.Label lblGPT;
        private System.Windows.Forms.TextBox txtBoxMidtermExam;
        private System.Windows.Forms.TextBox txtBoxFinalExam;
        private System.Windows.Forms.TextBox txtBoxGPT;
        private System.Windows.Forms.Button button1;
    }
}

