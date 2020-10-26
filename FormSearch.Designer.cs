
namespace SearchString
{
    partial class FormSearch
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSubString = new System.Windows.Forms.Label();
            this.lblString = new System.Windows.Forms.Label();
            this.txtSubString = new System.Windows.Forms.TextBox();
            this.txtString = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblTag = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblSubString);
            this.grpSearch.Controls.Add(this.lblString);
            this.grpSearch.Controls.Add(this.txtSubString);
            this.grpSearch.Controls.Add(this.txtString);
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(420, 126);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search SubString in String";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(88, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSubString
            // 
            this.lblSubString.AutoSize = true;
            this.lblSubString.Location = new System.Drawing.Point(9, 59);
            this.lblSubString.Name = "lblSubString";
            this.lblSubString.Size = new System.Drawing.Size(50, 13);
            this.lblSubString.TabIndex = 3;
            this.lblSubString.Text = "Sub Text";
            // 
            // lblString
            // 
            this.lblString.AutoSize = true;
            this.lblString.Location = new System.Drawing.Point(7, 25);
            this.lblString.Name = "lblString";
            this.lblString.Size = new System.Drawing.Size(54, 13);
            this.lblString.TabIndex = 2;
            this.lblString.Text = "Main Text";
            // 
            // txtSubString
            // 
            this.txtSubString.Location = new System.Drawing.Point(88, 55);
            this.txtSubString.Name = "txtSubString";
            this.txtSubString.Size = new System.Drawing.Size(100, 20);
            this.txtSubString.TabIndex = 1;
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(88, 19);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(100, 20);
            this.txtString.TabIndex = 0;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(438, 51);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(43, 16);
            this.lblResults.TabIndex = 2;
            this.lblResults.Text = "Results";
            // 
            // lblTag
            // 
            this.lblTag.AutoSize = true;
            this.lblTag.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTag.Location = new System.Drawing.Point(438, 21);
            this.lblTag.Name = "lblTag";
            this.lblTag.Size = new System.Drawing.Size(270, 16);
            this.lblTag.TabIndex = 3;
            this.lblTag.Text = "Subtext Found At Positions (zero based indexes):";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 196);
            this.Controls.Add(this.lblTag);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.grpSearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSearch";
            this.Text = "Search Subtext";
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSubString;
        private System.Windows.Forms.Label lblString;
        private System.Windows.Forms.TextBox txtSubString;
        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblTag;
    }
}

