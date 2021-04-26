
namespace LibraryApplication
{
    partial class uxMainWindow
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
            this.uxMainWindowTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxAssetManageButton = new System.Windows.Forms.Button();
            this.uxUserManageButton = new System.Windows.Forms.Button();
            this.uxCreatorManageButton = new System.Windows.Forms.Button();
            this.uxCheckOutAssetManageButton = new System.Windows.Forms.Button();
            this.uxReportQueryButton = new System.Windows.Forms.Button();
            this.uxQuitButton = new System.Windows.Forms.Button();
            this.uxLibrarianManageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxMainWindowTitle
            // 
            this.uxMainWindowTitle.AutoSize = true;
            this.uxMainWindowTitle.Location = new System.Drawing.Point(626, 58);
            this.uxMainWindowTitle.Name = "uxMainWindowTitle";
            this.uxMainWindowTitle.Size = new System.Drawing.Size(261, 32);
            this.uxMainWindowTitle.TabIndex = 0;
            this.uxMainWindowTitle.Text = "Main Manage Page";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 1;
            // 
            // uxAssetManageButton
            // 
            this.uxAssetManageButton.Location = new System.Drawing.Point(200, 338);
            this.uxAssetManageButton.Name = "uxAssetManageButton";
            this.uxAssetManageButton.Size = new System.Drawing.Size(470, 118);
            this.uxAssetManageButton.TabIndex = 2;
            this.uxAssetManageButton.Text = "Manage Asset";
            this.uxAssetManageButton.UseVisualStyleBackColor = true;
            this.uxAssetManageButton.Click += new System.EventHandler(this.uxAssetManageButton_Click);
            // 
            // uxUserManageButton
            // 
            this.uxUserManageButton.Location = new System.Drawing.Point(200, 151);
            this.uxUserManageButton.Name = "uxUserManageButton";
            this.uxUserManageButton.Size = new System.Drawing.Size(470, 118);
            this.uxUserManageButton.TabIndex = 3;
            this.uxUserManageButton.Text = "Manage User";
            this.uxUserManageButton.UseVisualStyleBackColor = true;
            this.uxUserManageButton.Click += new System.EventHandler(this.uxUserManageButton_Click);
            // 
            // uxCreatorManageButton
            // 
            this.uxCreatorManageButton.Location = new System.Drawing.Point(859, 151);
            this.uxCreatorManageButton.Name = "uxCreatorManageButton";
            this.uxCreatorManageButton.Size = new System.Drawing.Size(470, 118);
            this.uxCreatorManageButton.TabIndex = 4;
            this.uxCreatorManageButton.Text = "Manage Creator";
            this.uxCreatorManageButton.UseVisualStyleBackColor = true;
            this.uxCreatorManageButton.Click += new System.EventHandler(this.uxCreatorManageButton_Click);
            // 
            // uxCheckOutAssetManageButton
            // 
            this.uxCheckOutAssetManageButton.Location = new System.Drawing.Point(859, 338);
            this.uxCheckOutAssetManageButton.Name = "uxCheckOutAssetManageButton";
            this.uxCheckOutAssetManageButton.Size = new System.Drawing.Size(470, 118);
            this.uxCheckOutAssetManageButton.TabIndex = 5;
            this.uxCheckOutAssetManageButton.Text = "Manage Check Out Asset";
            this.uxCheckOutAssetManageButton.UseVisualStyleBackColor = true;
            this.uxCheckOutAssetManageButton.Click += new System.EventHandler(this.uxCheckOutAssetManageButton_Click);
            // 
            // uxReportQueryButton
            // 
            this.uxReportQueryButton.Location = new System.Drawing.Point(859, 550);
            this.uxReportQueryButton.Name = "uxReportQueryButton";
            this.uxReportQueryButton.Size = new System.Drawing.Size(470, 118);
            this.uxReportQueryButton.TabIndex = 6;
            this.uxReportQueryButton.Text = "Report Quries";
            this.uxReportQueryButton.UseVisualStyleBackColor = true;
            // 
            // uxQuitButton
            // 
            this.uxQuitButton.Location = new System.Drawing.Point(531, 788);
            this.uxQuitButton.Name = "uxQuitButton";
            this.uxQuitButton.Size = new System.Drawing.Size(470, 118);
            this.uxQuitButton.TabIndex = 7;
            this.uxQuitButton.Text = "Quit Application";
            this.uxQuitButton.UseVisualStyleBackColor = true;
            this.uxQuitButton.Click += new System.EventHandler(this.uxQuitButton_Click);
            // 
            // uxLibrarianManageButton
            // 
            this.uxLibrarianManageButton.Location = new System.Drawing.Point(200, 550);
            this.uxLibrarianManageButton.Name = "uxLibrarianManageButton";
            this.uxLibrarianManageButton.Size = new System.Drawing.Size(470, 118);
            this.uxLibrarianManageButton.TabIndex = 8;
            this.uxLibrarianManageButton.Text = "Manage Librarian";
            this.uxLibrarianManageButton.UseVisualStyleBackColor = true;
            this.uxLibrarianManageButton.Click += new System.EventHandler(this.uxLibrarianManageButton_Click);
            // 
            // uxMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1583, 959);
            this.Controls.Add(this.uxLibrarianManageButton);
            this.Controls.Add(this.uxQuitButton);
            this.Controls.Add(this.uxReportQueryButton);
            this.Controls.Add(this.uxCheckOutAssetManageButton);
            this.Controls.Add(this.uxCreatorManageButton);
            this.Controls.Add(this.uxUserManageButton);
            this.Controls.Add(this.uxAssetManageButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxMainWindowTitle);
            this.Name = "uxMainWindow";
            this.Text = "Librarian Manage System";
            this.Load += new System.EventHandler(this.uxMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxMainWindowTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uxAssetManageButton;
        private System.Windows.Forms.Button uxUserManageButton;
        private System.Windows.Forms.Button uxCreatorManageButton;
        private System.Windows.Forms.Button uxCheckOutAssetManageButton;
        private System.Windows.Forms.Button uxReportQueryButton;
        private System.Windows.Forms.Button uxQuitButton;
        private System.Windows.Forms.Button uxLibrarianManageButton;
    }
}

