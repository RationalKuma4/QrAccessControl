using System.Windows.Forms;

namespace QrAccessControl.Desktop
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        public ConfirmationForm(string pdfPath)
        {
            PdfPath = pdfPath;

            InitializeComponent();

            axAcroPDF1.src = PdfPath;
        }

        public string ClientName { get; set; }
        public string PdfPath { get; set; }

        private void button1_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
