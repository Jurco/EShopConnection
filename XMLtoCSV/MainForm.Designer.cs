namespace XMLtoCSV
{
    partial class MainForm
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
            this.labXML = new System.Windows.Forms.Label();
            this.txtXMLFile = new System.Windows.Forms.TextBox();
            this.butBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labXML
            // 
            this.labXML.AutoSize = true;
            this.labXML.Location = new System.Drawing.Point(12, 9);
            this.labXML.Name = "labXML";
            this.labXML.Size = new System.Drawing.Size(48, 13);
            this.labXML.TabIndex = 0;
            this.labXML.Text = "XML File";
            // 
            // txtXMLFile
            // 
            this.txtXMLFile.Location = new System.Drawing.Point(81, 6);
            this.txtXMLFile.Name = "txtXMLFile";
            this.txtXMLFile.Size = new System.Drawing.Size(280, 20);
            this.txtXMLFile.TabIndex = 1;
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(374, 4);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(43, 23);
            this.butBrowse.TabIndex = 2;
            this.butBrowse.Text = "...";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 160);
            this.Controls.Add(this.butBrowse);
            this.Controls.Add(this.txtXMLFile);
            this.Controls.Add(this.labXML);
            this.Name = "MainForm";
            this.Text = "XMLtoCSV";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labXML;
        private System.Windows.Forms.TextBox txtXMLFile;
        private System.Windows.Forms.Button butBrowse;
    }
}

