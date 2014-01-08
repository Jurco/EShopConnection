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
            this.gridPanel = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.butExportToCsv = new System.Windows.Forms.Button();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labXML
            // 
            this.labXML.AutoSize = true;
            this.labXML.Location = new System.Drawing.Point(13, 9);
            this.labXML.Name = "labXML";
            this.labXML.Size = new System.Drawing.Size(48, 13);
            this.labXML.TabIndex = 0;
            this.labXML.Text = "XML File";
            // 
            // txtXMLFile
            // 
            this.txtXMLFile.Location = new System.Drawing.Point(82, 6);
            this.txtXMLFile.Name = "txtXMLFile";
            this.txtXMLFile.Size = new System.Drawing.Size(280, 20);
            this.txtXMLFile.TabIndex = 1;
            // 
            // butBrowse
            // 
            this.butBrowse.Location = new System.Drawing.Point(375, 4);
            this.butBrowse.Name = "butBrowse";
            this.butBrowse.Size = new System.Drawing.Size(43, 23);
            this.butBrowse.TabIndex = 2;
            this.butBrowse.Text = "...";
            this.butBrowse.UseVisualStyleBackColor = true;
            this.butBrowse.Click += new System.EventHandler(this.butBrowse_Click);
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.dataGrid);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPanel.Location = new System.Drawing.Point(0, 76);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(602, 225);
            this.gridPanel.TabIndex = 3;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(602, 225);
            this.dataGrid.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.butExportToCsv);
            this.menuPanel.Controls.Add(this.txtXMLFile);
            this.menuPanel.Controls.Add(this.labXML);
            this.menuPanel.Controls.Add(this.butBrowse);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(602, 76);
            this.menuPanel.TabIndex = 4;
            // 
            // butExportToCsv
            // 
            this.butExportToCsv.Location = new System.Drawing.Point(12, 32);
            this.butExportToCsv.Name = "butExportToCsv";
            this.butExportToCsv.Size = new System.Drawing.Size(116, 34);
            this.butExportToCsv.TabIndex = 3;
            this.butExportToCsv.Text = "EXPORT to CSV";
            this.butExportToCsv.UseVisualStyleBackColor = true;
            this.butExportToCsv.Click += new System.EventHandler(this.butExportToCsv_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 301);
            this.Controls.Add(this.gridPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.Text = "XMLtoCSV";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labXML;
        private System.Windows.Forms.TextBox txtXMLFile;
        private System.Windows.Forms.Button butBrowse;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button butExportToCsv;
    }
}

