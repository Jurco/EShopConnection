using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace XMLtoCSV
{
    public partial class MainForm : Form
    {
        private string xmlFile = "";
        private DataSet xmlContent = new DataSet();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void butBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "XML Files (.xml)|*.xml|All Files (*.*)|*.*";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                xmlFile = ofd.FileName;
                txtXMLFile.Text = xmlFile;
                try
                {
                    xmlContent.ReadXml(xmlFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "XML Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            gridPanel.Top = 33;
            dataGrid.Top = 0;
        }

        
    }
}
