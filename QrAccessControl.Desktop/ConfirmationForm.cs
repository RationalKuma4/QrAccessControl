using System.Windows.Forms;

namespace QrAccessControl.Desktop
{
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm()
        {
            InitializeComponent();
        }

        public string ClientName { get; set; }
    }
}
