namespace polymorphism
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
            this.btn1Params = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn2Params = new System.Windows.Forms.Button();
            this.btn3Params = new System.Windows.Forms.Button();
            this.btn4Params = new System.Windows.Forms.Button();
            this.btnVirtual = new System.Windows.Forms.Button();
            this.btnOverride = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1Params
            // 
            this.btn1Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Params.Location = new System.Drawing.Point(253, 12);
            this.btn1Params.Name = "btn1Params";
            this.btn1Params.Size = new System.Drawing.Size(105, 58);
            this.btn1Params.TabIndex = 0;
            this.btn1Params.Text = "1 Param";
            this.btn1Params.UseVisualStyleBackColor = true;
            this.btn1Params.Click += new System.EventHandler(this.btn1Params_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 391);
            this.textBox1.TabIndex = 1;
            // 
            // btn2Params
            // 
            this.btn2Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Params.Location = new System.Drawing.Point(253, 76);
            this.btn2Params.Name = "btn2Params";
            this.btn2Params.Size = new System.Drawing.Size(105, 58);
            this.btn2Params.TabIndex = 0;
            this.btn2Params.Text = "2 Params";
            this.btn2Params.UseVisualStyleBackColor = true;
            this.btn2Params.Click += new System.EventHandler(this.btn2Params_Click);
            // 
            // btn3Params
            // 
            this.btn3Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Params.Location = new System.Drawing.Point(253, 140);
            this.btn3Params.Name = "btn3Params";
            this.btn3Params.Size = new System.Drawing.Size(105, 58);
            this.btn3Params.TabIndex = 0;
            this.btn3Params.Text = "3 Params";
            this.btn3Params.UseVisualStyleBackColor = true;
            this.btn3Params.Click += new System.EventHandler(this.btn3Params_Click);
            // 
            // btn4Params
            // 
            this.btn4Params.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Params.Location = new System.Drawing.Point(253, 204);
            this.btn4Params.Name = "btn4Params";
            this.btn4Params.Size = new System.Drawing.Size(105, 58);
            this.btn4Params.TabIndex = 0;
            this.btn4Params.Text = "4 Params";
            this.btn4Params.UseVisualStyleBackColor = true;
            this.btn4Params.Click += new System.EventHandler(this.btn4Params_Click);
            // 
            // btnVirtual
            // 
            this.btnVirtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirtual.Location = new System.Drawing.Point(364, 12);
            this.btnVirtual.Name = "btnVirtual";
            this.btnVirtual.Size = new System.Drawing.Size(105, 58);
            this.btnVirtual.TabIndex = 0;
            this.btnVirtual.Text = "Virtual";
            this.btnVirtual.UseVisualStyleBackColor = true;
            this.btnVirtual.Click += new System.EventHandler(this.btnVirtual_Click);
            // 
            // btnOverride
            // 
            this.btnOverride.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOverride.Location = new System.Drawing.Point(364, 76);
            this.btnOverride.Name = "btnOverride";
            this.btnOverride.Size = new System.Drawing.Size(105, 58);
            this.btnOverride.TabIndex = 0;
            this.btnOverride.Text = "Override";
            this.btnOverride.UseVisualStyleBackColor = true;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn4Params);
            this.Controls.Add(this.btn3Params);
            this.Controls.Add(this.btn2Params);
            this.Controls.Add(this.btnOverride);
            this.Controls.Add(this.btnVirtual);
            this.Controls.Add(this.btn1Params);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button btn1Params;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn2Params;
		private System.Windows.Forms.Button btn3Params;
		private System.Windows.Forms.Button btn4Params;
		private System.Windows.Forms.Button btnVirtual;
		private System.Windows.Forms.Button btnOverride;
	}
}

