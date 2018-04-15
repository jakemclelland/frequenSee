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
    public partial class AnalisisView : Form
    {
        public AnalyzationResponse AnalyzationResponse { get; set; }

        public AnalisisView()
        {
            InitializeComponent();
        }

        public void BindDataSource(AnalyzationResponse response)
        {
            this.AnalyzationResponse = response;
            this.analyzationResponseBindingSource.DataSource = this.AnalyzationResponse;

            if (response?.ResultSet?.FoundSymbolFrequencyResultSet != null)
            {
                IList<CategorySymbolFrequency> symbolsList = response.ResultSet.FoundSymbolFrequencyResultSet.SymbolDictionary.Select(x => x.Value).OrderByDescending(x => x.Hits).ToList();
                this.FoundSymbolsGrid.DataSource = symbolsList;
            }

            if (response?.ResultSet?.FoundWordFrequencyResultSet != null)
            {
                IList<CategoryWordFrequency> wordList = response.ResultSet.FoundWordFrequencyResultSet.WordDictionary.Select(x => x.Value).OrderByDescending(x => x.Hits).ToList();
                this.FoundWordsGrid.DataSource = wordList;
            }
        }

        private void FoundWordsGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void FoundSymbolsGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
        }

        private void FoundWordsGrid_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void LabelRowNumbers(DataGridView grid)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }

        private void FoundWordsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.LabelRowNumbers(this.FoundWordsGrid);
        }

        private void FoundSymbolsGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.LabelRowNumbers(this.FoundSymbolsGrid);
        }
    }
}
