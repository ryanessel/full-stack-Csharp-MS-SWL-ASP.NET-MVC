namespace drag_drop_test
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
            this.lblDragDrop = new System.Windows.Forms.Label();
            this.lblDataReadout = new System.Windows.Forms.Label();
            this.lbDroppedFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblDragDrop
            // 
            this.lblDragDrop.AutoSize = true;
            this.lblDragDrop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDragDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDragDrop.Location = new System.Drawing.Point(212, 147);
            this.lblDragDrop.Name = "lblDragDrop";
            this.lblDragDrop.Size = new System.Drawing.Size(307, 35);
            this.lblDragDrop.TabIndex = 0;
            this.lblDragDrop.Text = "Drop File on this text";
            this.lblDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lblDragDrop_DragDrop);
            this.lblDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lblDragDrop_DragEnter);
            // 
            // lblDataReadout
            // 
            this.lblDataReadout.AutoSize = true;
            this.lblDataReadout.Location = new System.Drawing.Point(243, 263);
            this.lblDataReadout.Name = "lblDataReadout";
            this.lblDataReadout.Size = new System.Drawing.Size(174, 13);
            this.lblDataReadout.TabIndex = 1;
            this.lblDataReadout.Text = "Drop item string should appear here";
            // 
            // lbDroppedFiles
            // 
            this.lbDroppedFiles.FormattingEnabled = true;
            this.lbDroppedFiles.Location = new System.Drawing.Point(114, 287);
            this.lbDroppedFiles.Name = "lbDroppedFiles";
            this.lbDroppedFiles.Size = new System.Drawing.Size(497, 95);
            this.lbDroppedFiles.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDroppedFiles);
            this.Controls.Add(this.lblDataReadout);
            this.Controls.Add(this.lblDragDrop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDragDrop;
        private System.Windows.Forms.Label lblDataReadout;
        private System.Windows.Forms.ListBox lbDroppedFiles;
    }
}

