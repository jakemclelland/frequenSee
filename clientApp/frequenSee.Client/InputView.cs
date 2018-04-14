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
    }
}
