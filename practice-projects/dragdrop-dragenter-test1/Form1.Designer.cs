namespace dragdrop_dragenter_test1
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
            this.btnTextToDrag = new System.Windows.Forms.Button();
            this.txtBoxToReceiveDrop = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTextToDrag
            // 
            this.btnTextToDrag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTextToDrag.Location = new System.Drawing.Point(269, 97);
            this.btnTextToDrag.Name = "btnTextToDrag";
            this.btnTextToDrag.Size = new System.Drawing.Size(348, 29);
            this.btnTextToDrag.TabIndex = 0;
            this.btnTextToDrag.Text = "text from this button will be dragged ";
            this.btnTextToDrag.UseVisualStyleBackColor = true;
            this.btnTextToDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTextToDrag_MouseDown);
            // 
            // txtBoxToReceiveDrop
            // 
            this.txtBoxToReceiveDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxToReceiveDrop.Location = new System.Drawing.Point(269, 170);
            this.txtBoxToReceiveDrop.Name = "txtBoxToReceiveDrop";
            this.txtBoxToReceiveDrop.Size = new System.Drawing.Size(348, 26);
            this.txtBoxToReceiveDrop.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxToReceiveDrop);
            this.Controls.Add(this.btnTextToDrag);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTextToDrag;
        private System.Windows.Forms.TextBox txtBoxToReceiveDrop;
    }
}

