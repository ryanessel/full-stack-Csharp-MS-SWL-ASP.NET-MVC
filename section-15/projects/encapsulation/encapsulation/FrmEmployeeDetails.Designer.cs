namespace encapsulation
{
	partial class FrmEmployeeDetails
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(24, 112);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 49);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(12, 61);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(156, 20);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Employee Position";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(138, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Employee Name";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(12, 9);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(124, 20);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Employee Age";
            // 
            // FrmEmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 226);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAge);
            this.Name = "FrmEmployeeDetails";
            this.Text = "FrmEmployeeDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Button btnClose;
		public System.Windows.Forms.Label lblPosition;
		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Label lblAge;
	}
}