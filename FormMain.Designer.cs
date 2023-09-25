namespace ExcelToXml
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelFile = new Label();
            textBoxFile = new TextBox();
            buttonBrowse = new Button();
            buttonExport = new Button();
            labelRowsRange = new Label();
            textBoxRowFirst = new TextBox();
            textBoxRowLast = new TextBox();
            textBoxColLast = new TextBox();
            textBoxColFirst = new TextBox();
            labelColumnsRange = new Label();
            textBoxLog = new TextBox();
            labelPageNumber = new Label();
            textBoxPageNumber = new TextBox();
            SuspendLayout();
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Location = new Point(12, 9);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(25, 15);
            labelFile.TabIndex = 0;
            labelFile.Text = "File";
            // 
            // textBoxFile
            // 
            textBoxFile.Enabled = false;
            textBoxFile.Location = new Point(12, 27);
            textBoxFile.Name = "textBoxFile";
            textBoxFile.Size = new Size(614, 23);
            textBoxFile.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            buttonBrowse.Location = new Point(632, 26);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 23);
            buttonBrowse.TabIndex = 2;
            buttonBrowse.Text = "Browse...";
            buttonBrowse.UseVisualStyleBackColor = true;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonExport
            // 
            buttonExport.Enabled = false;
            buttonExport.Location = new Point(713, 26);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(75, 23);
            buttonExport.TabIndex = 3;
            buttonExport.Text = "Export";
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // labelRowsRange
            // 
            labelRowsRange.AutoSize = true;
            labelRowsRange.Location = new Point(12, 68);
            labelRowsRange.Name = "labelRowsRange";
            labelRowsRange.Size = new Size(68, 15);
            labelRowsRange.TabIndex = 4;
            labelRowsRange.Text = "Rows range";
            // 
            // textBoxRowFirst
            // 
            textBoxRowFirst.Location = new Point(12, 86);
            textBoxRowFirst.Name = "textBoxRowFirst";
            textBoxRowFirst.Size = new Size(100, 23);
            textBoxRowFirst.TabIndex = 5;
            textBoxRowFirst.Text = "8";
            textBoxRowFirst.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxRowLast
            // 
            textBoxRowLast.Location = new Point(118, 86);
            textBoxRowLast.Name = "textBoxRowLast";
            textBoxRowLast.Size = new Size(100, 23);
            textBoxRowLast.TabIndex = 6;
            textBoxRowLast.Text = "8";
            textBoxRowLast.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxColLast
            // 
            textBoxColLast.Location = new Point(347, 86);
            textBoxColLast.Name = "textBoxColLast";
            textBoxColLast.Size = new Size(100, 23);
            textBoxColLast.TabIndex = 9;
            textBoxColLast.Text = "27";
            textBoxColLast.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxColFirst
            // 
            textBoxColFirst.Location = new Point(241, 86);
            textBoxColFirst.Name = "textBoxColFirst";
            textBoxColFirst.Size = new Size(100, 23);
            textBoxColFirst.TabIndex = 8;
            textBoxColFirst.Text = "2";
            textBoxColFirst.TextAlign = HorizontalAlignment.Center;
            // 
            // labelColumnsRange
            // 
            labelColumnsRange.AutoSize = true;
            labelColumnsRange.Location = new Point(241, 68);
            labelColumnsRange.Name = "labelColumnsRange";
            labelColumnsRange.Size = new Size(88, 15);
            labelColumnsRange.TabIndex = 7;
            labelColumnsRange.Text = "Columns range";
            // 
            // textBoxLog
            // 
            textBoxLog.Location = new Point(12, 375);
            textBoxLog.Multiline = true;
            textBoxLog.Name = "textBoxLog";
            textBoxLog.ScrollBars = ScrollBars.Vertical;
            textBoxLog.Size = new Size(776, 63);
            textBoxLog.TabIndex = 10;
            // 
            // labelPageNumber
            // 
            labelPageNumber.AutoSize = true;
            labelPageNumber.Location = new Point(526, 68);
            labelPageNumber.Name = "labelPageNumber";
            labelPageNumber.Size = new Size(78, 15);
            labelPageNumber.TabIndex = 11;
            labelPageNumber.Text = "Page number";
            // 
            // textBoxPageNumber
            // 
            textBoxPageNumber.Location = new Point(526, 86);
            textBoxPageNumber.Name = "textBoxPageNumber";
            textBoxPageNumber.Size = new Size(100, 23);
            textBoxPageNumber.TabIndex = 12;
            textBoxPageNumber.Text = "1";
            textBoxPageNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPageNumber);
            Controls.Add(labelPageNumber);
            Controls.Add(textBoxLog);
            Controls.Add(textBoxColLast);
            Controls.Add(textBoxColFirst);
            Controls.Add(labelColumnsRange);
            Controls.Add(textBoxRowLast);
            Controls.Add(textBoxRowFirst);
            Controls.Add(labelRowsRange);
            Controls.Add(buttonExport);
            Controls.Add(buttonBrowse);
            Controls.Add(textBoxFile);
            Controls.Add(labelFile);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Excel To Xml 2023";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFile;
        private TextBox textBoxFile;
        private Button buttonBrowse;
        private Button buttonExport;
        private Label labelRowsRange;
        private TextBox textBoxRowFirst;
        private TextBox textBoxRowLast;
        private TextBox textBoxColLast;
        private TextBox textBoxColFirst;
        private Label labelColumnsRange;
        private TextBox textBoxLog;
        private Label labelPageNumber;
        private TextBox textBoxPageNumber;
    }
}