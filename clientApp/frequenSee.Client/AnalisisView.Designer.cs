namespace frequenSee.Client
{
    partial class AnalisisView
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
            this.components = new System.ComponentModel.Container();
            this.FoundSymbolsGrid = new System.Windows.Forms.DataGridView();
            this.analyzationResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FoundWordsGrid = new System.Windows.Forms.DataGridView();
            this.categorySymbolFrequencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryWordFrequencyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hitsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayTextDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hitsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FoundSymbolsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzationResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoundWordsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySymbolFrequencyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWordFrequencyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FoundSymbolsGrid
            // 
            this.FoundSymbolsGrid.AllowUserToAddRows = false;
            this.FoundSymbolsGrid.AllowUserToDeleteRows = false;
            this.FoundSymbolsGrid.AllowUserToOrderColumns = true;
            this.FoundSymbolsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.FoundSymbolsGrid.AutoGenerateColumns = false;
            this.FoundSymbolsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoundSymbolsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hitsDataGridViewTextBoxColumn,
            this.displayTextDataGridViewTextBoxColumn});
            this.FoundSymbolsGrid.DataSource = this.categorySymbolFrequencyBindingSource;
            this.FoundSymbolsGrid.Location = new System.Drawing.Point(12, 12);
            this.FoundSymbolsGrid.Name = "FoundSymbolsGrid";
            this.FoundSymbolsGrid.ReadOnly = true;
            this.FoundSymbolsGrid.RowTemplate.Height = 28;
            this.FoundSymbolsGrid.Size = new System.Drawing.Size(394, 535);
            this.FoundSymbolsGrid.TabIndex = 0;
            this.FoundSymbolsGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.FoundSymbolsGrid_RowPostPaint);
            // 
            // analyzationResponseBindingSource
            // 
            this.analyzationResponseBindingSource.DataSource = typeof(frequenSee.Models.AnalyzationResponse);
            // 
            // FoundWordsGrid
            // 
            this.FoundWordsGrid.AllowUserToAddRows = false;
            this.FoundWordsGrid.AllowUserToDeleteRows = false;
            this.FoundWordsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FoundWordsGrid.AutoGenerateColumns = false;
            this.FoundWordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoundWordsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hitsDataGridViewTextBoxColumn1,
            this.displayTextDataGridViewTextBoxColumn1});
            this.FoundWordsGrid.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.categoryWordFrequencyBindingSource, "DisplayText", true));
            this.FoundWordsGrid.DataSource = this.categoryWordFrequencyBindingSource;
            this.FoundWordsGrid.Location = new System.Drawing.Point(425, 12);
            this.FoundWordsGrid.Name = "FoundWordsGrid";
            this.FoundWordsGrid.ReadOnly = true;
            this.FoundWordsGrid.RowTemplate.Height = 28;
            this.FoundWordsGrid.Size = new System.Drawing.Size(424, 535);
            this.FoundWordsGrid.TabIndex = 0;
            this.FoundWordsGrid.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.FoundWordsGrid_RowPostPaint);
            // 
            // categorySymbolFrequencyBindingSource
            // 
            this.categorySymbolFrequencyBindingSource.DataSource = typeof(frequenSee.Models.CategorySymbolFrequency);
            // 
            // categoryWordFrequencyBindingSource
            // 
            this.categoryWordFrequencyBindingSource.DataSource = typeof(frequenSee.Models.CategoryWordFrequency);
            // 
            // hitsDataGridViewTextBoxColumn1
            // 
            this.hitsDataGridViewTextBoxColumn1.DataPropertyName = "Hits";
            this.hitsDataGridViewTextBoxColumn1.HeaderText = "Hits";
            this.hitsDataGridViewTextBoxColumn1.Name = "hitsDataGridViewTextBoxColumn1";
            this.hitsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // displayTextDataGridViewTextBoxColumn1
            // 
            this.displayTextDataGridViewTextBoxColumn1.DataPropertyName = "DisplayText";
            this.displayTextDataGridViewTextBoxColumn1.HeaderText = "Word";
            this.displayTextDataGridViewTextBoxColumn1.Name = "displayTextDataGridViewTextBoxColumn1";
            this.displayTextDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hitsDataGridViewTextBoxColumn
            // 
            this.hitsDataGridViewTextBoxColumn.DataPropertyName = "Hits";
            this.hitsDataGridViewTextBoxColumn.HeaderText = "Hits";
            this.hitsDataGridViewTextBoxColumn.Name = "hitsDataGridViewTextBoxColumn";
            this.hitsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displayTextDataGridViewTextBoxColumn
            // 
            this.displayTextDataGridViewTextBoxColumn.DataPropertyName = "DisplayText";
            this.displayTextDataGridViewTextBoxColumn.HeaderText = "Letter";
            this.displayTextDataGridViewTextBoxColumn.Name = "displayTextDataGridViewTextBoxColumn";
            this.displayTextDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AnalisisView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 559);
            this.Controls.Add(this.FoundWordsGrid);
            this.Controls.Add(this.FoundSymbolsGrid);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.analyzationResponseBindingSource, "ResultSet", true));
            this.Name = "AnalisisView";
            this.Text = "AnalisisView";
            ((System.ComponentModel.ISupportInitialize)(this.FoundSymbolsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analyzationResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FoundWordsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categorySymbolFrequencyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryWordFrequencyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView FoundSymbolsGrid;
        private System.Windows.Forms.DataGridView FoundWordsGrid;
        private System.Windows.Forms.BindingSource analyzationResponseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categorySymbolFrequencyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn hitsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayTextDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource categoryWordFrequencyBindingSource;
    }
}