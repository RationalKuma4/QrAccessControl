using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ZXing;
using Rectangle = iTextSharp.text.Rectangle;

namespace QrAccessControl.Desktop
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in _filterInfoCollection)
                comboCamera.Items.Add(device.Name);
            comboCamera.SelectedIndex = 0;
            _videoCaptureDevice = new VideoCaptureDevice();
        }

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[comboCamera.SelectedIndex].MonikerString);
            _videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            _videoCaptureDevice.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var reader = new BarcodeReader();
            var result = reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
            {
                labelName.Text = result.ToString();
                var confirmation = new ConfirmationForm { ClientName = labelName.Text };
                confirmation.Show();
            }
            else
            {
                labelName.Text = "Preparado";
            }
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_videoCaptureDevice.IsRunning)
                _videoCaptureDevice.Stop();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            // Fondo
            var imageFilePath = @"C:\Users\Anselmo\source\repos\QrAccessControl\QrAccessControl.Desktop\bin\certificadoWebinarCeroDanfoss.png";
            var jpg = iTextSharp.text.Image.GetInstance(imageFilePath);
            jpg.ScaleToFit(200, 500);
            jpg.Alignment = iTextSharp.text.Image.UNDERLYING;
            jpg.SetAbsolutePosition(8, 70);

            using (var doc = new Document(PageSize.A7, 10f, 10f, 10f, 10f))
            using (var streamDoc = new FileStream($@"C:\Users\Anselmo\source\repos\QrAccessControl\QrAccessControl.Desktop\bin\Debug\{labelName.Text}.pdf",
                FileMode.Create))
            {
                PdfWriter.GetInstance(doc, streamDoc);
                doc.Open();
                var para = new Paragraph($"{labelName.Text}")
                {
                    SpacingBefore = 70f
                };
                doc.Add(jpg);
                doc.Add(para);
                doc.Close();
            }

            var pdfConfirmationPath = $@"C:\Users\Anselmo\source\repos\QrAccessControl\QrAccessControl.Desktop\bin\Debug\{labelName.Text}.pdf";

            var pdfView = new ConfirmationForm(pdfConfirmationPath);
            pdfView.Show();
        }
    }
}
