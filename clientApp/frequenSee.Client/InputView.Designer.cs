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
            this.CategoryType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContentSource = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AnalyzeLetters = new System.Windows.Forms.CheckBox();
            this.AnalyzeWords = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.analyzationRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.analyzationRequestBindingSource, "InputText", true));
            this.InputText.Location = new System.Drawing.Point(12, 32);
            this.InputText.Multiline = true;
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(791, 606);
            this.InputText.TabIndex = 0;
            // 
            // analyzationRequestBindingSource
            // 
            this.analyzationRequestBindingSource.DataSource = typeof(frequenSee.Models.AnalyzationRequest);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Input Text";
            // 
            // RunAnalisis
            // 
            this.RunAnalisis.Location = new System.Drawing.Point(977, 490);
            this.RunAnalisis.Name = "RunAnalisis";
            this.RunAnalisis.Size = new System.Drawing.Size(142, 48);
            this.RunAnalisis.TabIndex = 4;
            this.RunAnalisis.Text = "Analyze Text";
            this.RunAnalisis.UseVisualStyleBackColor = true;
            this.RunAnalisis.Click += new System.EventHandler(this.RunAnalisis_Click);
            // 
            // CategoryType
            // 
            this.CategoryType.FormattingEnabled = true;
            this.CategoryType.Location = new System.Drawing.Point(854, 58);
            this.CategoryType.Name = "CategoryType";
            this.CategoryType.Size = new System.Drawing.Size(121, 28);
            this.CategoryType.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(850, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // ContentSource
            // 
            this.ContentSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.analyzationRequestBindingSource, "ContentSource", true));
            this.ContentSource.Location = new System.Drawing.Point(854, 140);
            this.ContentSource.Name = "ContentSource";
            this.ContentSource.Size = new System.Drawing.Size(400, 26);
            this.ContentSource.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(850, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Content Source";
            // 
            // AnalyzeLetters
            // 
            this.AnalyzeLetters.AutoSize = true;
            this.AnalyzeLetters.Location = new System.Drawing.Point(854, 243);
            this.AnalyzeLetters.Name = "AnalyzeLetters";
            this.AnalyzeLetters.Size = new System.Drawing.Size(145, 24);
            this.AnalyzeLetters.TabIndex = 12;
            this.AnalyzeLetters.Text = "Analyze Letters";
            this.AnalyzeLetters.UseVisualStyleBackColor = true;
            this.AnalyzeLetters.CheckedChanged += new System.EventHandler(this.AnalyzeLetters_CheckedChanged);
            // 
            // AnalyzeWords
            // 
            this.AnalyzeWords.AutoSize = true;
            this.AnalyzeWords.Location = new System.Drawing.Point(854, 274);
            this.AnalyzeWords.Name = "AnalyzeWords";
            this.AnalyzeWords.Size = new System.Drawing.Size(141, 24);
            this.AnalyzeWords.TabIndex = 13;
            this.AnalyzeWords.Text = "Analyze Words";
            this.AnalyzeWords.UseVisualStyleBackColor = true;
            this.AnalyzeWords.CheckedChanged += new System.EventHandler(this.AnalyzeWords_CheckedChanged);
            // 
            // InputView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 650);
            this.Controls.Add(this.AnalyzeWords);
            this.Controls.Add(this.AnalyzeLetters);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ContentSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryType);
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
        private System.Windows.Forms.ComboBox CategoryType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource analyzationRequestBindingSource;
        private System.Windows.Forms.TextBox ContentSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox AnalyzeLetters;
        private System.Windows.Forms.CheckBox AnalyzeWords;
    }
}

