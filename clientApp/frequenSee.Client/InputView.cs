using frequenSee.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frequenSee.Client
{
    public partial class InputView : Form
    {
        
        public InputView()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.analyzationRequestBindingSource.DataSource = new AnalyzationRequest();
            this.SetDefaults();
        }

        private void SetDefaults()
        {
            this.AnalyzeLetters.Checked = true;
            this.AnalyzeWords.Checked = true;
        }

        private void RunAnalisis_Click(object sender, EventArgs e)
        {
            AnalyzationRequest request = (AnalyzationRequest)this.analyzationRequestBindingSource.DataSource;

            AnalyzationManager manager = new AnalyzationManager();

            AnalyzationResponse response = manager.RunAnalisis(request);

            AnalisisView analisisView = new AnalisisView();

            analisisView.BindDataSource(response);
            analisisView.Show();
        }

        private void AnalyzeLetters_CheckedChanged(object sender, EventArgs e)
        {
            AnalyzationRequest request = (AnalyzationRequest)this.analyzationRequestBindingSource.DataSource;
            request.AnalyzationType = request.AnalyzationType | DigestType.Symbols;
        }

        private void AnalyzeWords_CheckedChanged(object sender, EventArgs e)
        {
            AnalyzationRequest request = (AnalyzationRequest)this.analyzationRequestBindingSource.DataSource;
            request.AnalyzationType = request.AnalyzationType | DigestType.Words;
        }

        private void InputFilePath_TextChanged(object sender, EventArgs e)
        {
            this.InputText.Clear();
        }

        private void InputText_TextChanged(object sender, EventArgs e)
        {
            this.InputFilePath.Clear();
        }

        private void BrowseInputFile_Click(object sender, EventArgs e)
        {
            DialogResult res = this.openFileDialog1.ShowDialog();
            this.InputFilePath.Text = this.openFileDialog1.FileName;
            ((AnalyzationRequest)this.analyzationRequestBindingSource.DataSource).InputFilePath = this.openFileDialog1.FileName;
        }
    }
}
