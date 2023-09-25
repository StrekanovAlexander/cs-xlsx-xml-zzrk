using System.Text;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelToXml
{
    public partial class FormMain : Form
    {
        private string outputFileName = "32000000191218J0104706100000000151220203200.xml";
        private string initialDirectory = Path.GetDirectoryName(Application.ExecutablePath)!;
        private int rowFirst, rowLast;
        private int colFirst, colLast;
        private int sheetId;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = initialDirectory;

                openFileDialog.Filter = "Excel files |*.xls;*.xlsx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFile.Text = openFileDialog.FileName;
                    buttonExport.Enabled = true;
                }
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            rowFirst = Int32.Parse(textBoxRowFirst.Text);
            rowLast = Int32.Parse(textBoxRowLast.Text);
            colFirst = Int32.Parse(textBoxColFirst.Text);
            colLast = Int32.Parse(textBoxColLast.Text);
            sheetId = Int32.Parse(textBoxPageNumber.Text);

            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Open(textBoxFile.Text);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[sheetId];
            
            StringBuilder sb = new StringBuilder();

            string progress = ".";

            for (int j = colFirst; j <= colLast; j++)
            {
                textBoxLog.Text = $"Handling column {j} of {colLast} {progress}";
                progress += ".";

                int i = rowFirst;
                int r = rowFirst - (rowFirst - 1);

                while (i <= rowLast)
                {
                    if (worksheet.Cells[i, j].Value2 == null)
                    {
                        XMLDoc.AddNode(sb, j, r);
                    }
                    else
                    {
                        string cellValue = XMLDoc.RepairNode(Convert.ToString(worksheet.Cells[i, j].Value2));
                        XMLDoc.AddNode(sb, j, r, cellValue);
                    }

                    i = i + 1;
                    r = i - (rowFirst - 1);
                }
            }

            buildOutputFile(sb.ToString());

            textBoxLog.Text = "Export was done!";

            workbook.Close();
            app.Quit();
        }

        private void buildOutputFile(string body)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var path = Path.Combine(initialDirectory, outputFileName);

            using (StreamWriter outputFile = new StreamWriter(path, false, Encoding.GetEncoding(1251)))
            {
                string header = XMLDoc.getHeader(outputFileName);
                outputFile.Write(header);
                outputFile.Write(body);
            }
        }
    }
}