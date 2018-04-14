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
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,

                LineAlignment = StringAlignment.Center
            };
            //get the size of the string
            Size textSize = TextRenderer.MeasureText(rowIdx, this.Font);
            //if header width lower then string width then resize
            if (grid.RowHeadersWidth < textSize.Width + 40)
            {
                grid.RowHeadersWidth = textSize.Width + 40;
            }
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }

        private void FoundSymbolsGrid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            var grid = sender as DataGridView;
            var rowIdx = (e.RowIndex + 1).ToString();

            var centerFormat = new StringFormat()
            {
                // right alignment might actually make more sense for numbers
                Alignment = StringAlignment.Center,

                LineAlignment = StringAlignment.Center
            };
            //get the size of the string
            Size textSize = TextRenderer.MeasureText(rowIdx, this.Font);
            //if header width lower then string width then resize
            if (grid.RowHeadersWidth < textSize.Width + 40)
            {
                grid.RowHeadersWidth = textSize.Width + 40;
            }
            var headerBounds = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, grid.RowHeadersWidth, e.RowBounds.Height);
            e.Graphics.DrawString(rowIdx, this.Font, SystemBrushes.ControlText, headerBounds, centerFormat);
        }
    }
}
