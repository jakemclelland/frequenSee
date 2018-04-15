namespace frequenSee.Client
{
    partial class InputView
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.analyzationRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.RunAnalisis = new System.Windows.Forms.Button();
            this.AnalyzeLetters = new System.Windows.Forms.CheckBox();
            this.AnalyzeWords = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputFilePath = new System.Windows.Forms.TextBox();
            this.BrowseInputFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.analyzationRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.analyzationRequestBindingSource, "InputText", true));
            this.InputText.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputText.Location = new System.Drawing.Point(12, 176);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(1063, 462);
            this.InputText.TabIndex = 0;
            this.InputText.TextChanged += new System.EventHandler(this.InputText_TextChanged);
            // 
            // analyzationRequestBindingSource
            // 
            this.analyzationRequestBindingSource.DataSource = typeof(frequenSee.Models.AnalyzationRequest);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Text";
            // 
            // RunAnalisis
            // 
            this.RunAnalisis.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunAnalisis.Location = new System.Drawing.Point(1102, 568);
            this.RunAnalisis.Name = "RunAnalisis";
            this.RunAnalisis.Size = new System.Drawing.Size(142, 48);
            this.RunAnalisis.TabIndex = 4;
            this.RunAnalisis.Text = "Analyze Text";
            this.RunAnalisis.UseVisualStyleBackColor = true;
            this.RunAnalisis.Click += new System.EventHandler(this.RunAnalisis_Click);
            // 
            // AnalyzeLetters
            // 
            this.AnalyzeLetters.AutoSize = true;
            this.AnalyzeLetters.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyzeLetters.Location = new System.Drawing.Point(1099, 383);
            this.AnalyzeLetters.Name = "AnalyzeLetters";
            this.AnalyzeLetters.Size = new System.Drawing.Size(169, 32);
            this.AnalyzeLetters.TabIndex = 12;
            this.AnalyzeLetters.Text = "Analyze Letters";
            this.AnalyzeLetters.UseVisualStyleBackColor = true;
            this.AnalyzeLetters.CheckedChanged += new System.EventHandler(this.AnalyzeLetters_CheckedChanged);
            // 
            // AnalyzeWords
            // 
            this.AnalyzeWords.AutoSize = true;
            this.AnalyzeWords.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyzeWords.Location = new System.Drawing.Point(1099, 414);
            this.AnalyzeWords.Name = "AnalyzeWords";
            this.AnalyzeWords.Size = new System.Drawing.Size(168, 32);
            this.AnalyzeWords.TabIndex = 13;
            this.AnalyzeWords.Text = "Analyze Words";
            this.AnalyzeWords.UseVisualStyleBackColor = true;
            this.AnalyzeWords.CheckedChanged += new System.EventHandler(this.AnalyzeWords_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Input File";
            // 
            // InputFilePath
            // 
            this.InputFilePath.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.analyzationRequestBindingSource, "InputFilePath", true));
            this.InputFilePath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputFilePath.Location = new System.Drawing.Point(12, 45);
            this.InputFilePath.Name = "InputFilePath";
            this.InputFilePath.Size = new System.Drawing.Size(1026, 34);
            this.InputFilePath.TabIndex = 15;
            this.InputFilePath.TextChanged += new System.EventHandler(this.InputFilePath_TextChanged);
            // 
            // BrowseInputFile
            // 
            this.BrowseInputFile.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseInputFile.Location = new System.Drawing.Point(1037, 42);
            this.BrowseInputFile.Name = "BrowseInputFile";
            this.BrowseInputFile.Size = new System.Drawing.Size(43, 43);
            this.BrowseInputFile.TabIndex = 16;
            this.BrowseInputFile.Text = "...";
            this.BrowseInputFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BrowseInputFile.UseVisualStyleBackColor = true;
            this.BrowseInputFile.Click += new System.EventHandler(this.BrowseInputFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // OR
            // 
            this.OR.AutoSize = true;
            this.OR.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OR.Location = new System.Drawing.Point(13, 99);
            this.OR.Name = "OR";
            this.OR.Size = new System.Drawing.Size(39, 28);
            this.OR.TabIndex = 17;
            this.OR.Text = "OR";
            // 
            // InputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 650);
            this.Controls.Add(this.OR);
            this.Controls.Add(this.BrowseInputFile);
            this.Controls.Add(this.InputFilePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AnalyzeWords);
            this.Controls.Add(this.AnalyzeLetters);
            this.Controls.Add(this.RunAnalisis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InputText);
            this.Name = "InputView";
            this.Text = "Input";
            ((System.ComponentModel.ISupportInitialize)(this.analyzationRequestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button RunAnalisis;
        private System.Windows.Forms.BindingSource analyzationRequestBindingSource;
        private System.Windows.Forms.CheckBox AnalyzeLetters;
        private System.Windows.Forms.CheckBox AnalyzeWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputFilePath;
        private System.Windows.Forms.Button BrowseInputFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label OR;
    }
}

