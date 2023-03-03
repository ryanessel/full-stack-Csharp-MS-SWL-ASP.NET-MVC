namespace directory_and_directory_info
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMoveFolder = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnPathSetter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentDirBox = new System.Windows.Forms.TextBox();
            this.btnCurrDirCheck = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMoveFolder
            // 
            this.btnMoveFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoveFolder.Location = new System.Drawing.Point(158, 26);
            this.btnMoveFolder.Name = "btnMoveFolder";
            this.btnMoveFolder.Size = new System.Drawing.Size(119, 41);
            this.btnMoveFolder.TabIndex = 0;
            this.btnMoveFolder.Text = "Move folder";
            this.btnMoveFolder.UseVisualStyleBackColor = true;
            this.btnMoveFolder.Click += new System.EventHandler(this.btnMoveFolder_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(305, 26);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(119, 41);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate2
            // 
            this.btnCreate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate2.Location = new System.Drawing.Point(12, 108);
            this.btnCreate2.Name = "btnCreate2";
            this.btnCreate2.Size = new System.Drawing.Size(119, 41);
            this.btnCreate2.TabIndex = 0;
            this.btnCreate2.Text = "Create 2";
            this.btnCreate2.UseVisualStyleBackColor = true;
            this.btnCreate2.Click += new System.EventHandler(this.btnCreate2_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // btnPathSetter
            // 
            this.btnPathSetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPathSetter.Location = new System.Drawing.Point(12, 181);
            this.btnPathSetter.Name = "btnPathSetter";
            this.btnPathSetter.Size = new System.Drawing.Size(172, 65);
            this.btnPathSetter.TabIndex = 0;
            this.btnPathSetter.Text = "Choose Path";
            this.btnPathSetter.UseVisualStyleBackColor = true;
            this.btnPathSetter.Click += new System.EventHandler(this.btnPathSetter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Name";
            // 
            // txtCurrentDirBox
            // 
            this.txtCurrentDirBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentDirBox.Location = new System.Drawing.Point(12, 340);
            this.txtCurrentDirBox.Name = "txtCurrentDirBox";
            this.txtCurrentDirBox.Size = new System.Drawing.Size(809, 21);
            this.txtCurrentDirBox.TabIndex = 2;
            this.txtCurrentDirBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCurrDirCheck
            // 
            this.btnCurrDirCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrDirCheck.Location = new System.Drawing.Point(218, 181);
            this.btnCurrDirCheck.Name = "btnCurrDirCheck";
            this.btnCurrDirCheck.Size = new System.Drawing.Size(172, 65);
            this.btnCurrDirCheck.TabIndex = 0;
            this.btnCurrDirCheck.Text = "Check Selected Path";
            this.btnCurrDirCheck.UseVisualStyleBackColor = true;
            this.btnCurrDirCheck.Click += new System.EventHandler(this.btnCurrDirCheck_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(326, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Create Folder at Current Directory";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(405, 403);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(100, 20);
            this.txtFolderName.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 450);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.txtCurrentDirBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnMoveFolder);
            this.Controls.Add(this.btnCurrDirCheck);
            this.Controls.Add(this.btnPathSetter);
            this.Controls.Add(this.btnCreate2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMoveFolder;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnPathSetter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentDirBox;
        private System.Windows.Forms.Button btnCurrDirCheck;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtFolderName;
    }
}

