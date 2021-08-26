using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using ZXing;
using ZXing.Client.Result;
using System.Linq;
using System.Drawing.Drawing2D;

namespace CameraScanner
{
    public partial class FMain : Form
    {
        private VideoCaptureDevice videoCaptureDevice;
        private FilterInfoCollection filterInfoCollection;
        private BarcodeReader barcodeReader;
        private ParsedResult resultParsed;
        private Result result;

        private SoundPlayer player;

        private string barcodeValue;
        private Bitmap barcodeBitmap;

        private bool isBarcodeAcquired;
       

        public FMain()
        {
            InitializeComponent();

            LoadVideoDevices();

            isBarcodeAcquired = false;

            player = new SoundPlayer();
            player.SoundLocation = "beep.wav";

            barcodeReader = new BarcodeReader();
            barcodeReader.ResultFound += BarcodeReader_ResultFound;
            barcodeReader.Options.AssumeGS1 = true;
            //barcodeReader.Options.PossibleFormats = new BarcodeFormat[] { BarcodeFormat.CODE_128 };

        }

        private void BarcodeReader_ResultFound(Result obj)
        {
           
        }

        private void LoadVideoDevices()
        {
            ddlCamera.Items.Add("Seleziona Camera");
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in this.filterInfoCollection)
            {
                ddlCamera.Items.Add(info.Name);
            }
            ddlCamera.SelectedIndex = 0;
        }


        private void p_main_Paint(object sender, PaintEventArgs e)
        {
            Control c = (Control)sender;

            LinearGradientBrush b = new LinearGradientBrush(c.ClientRectangle, Color.White, Color.LightSteelBlue, LinearGradientMode.ForwardDiagonal);

            e.Graphics.FillRectangle(b, c.ClientRectangle);

            b.Dispose();
        }

        private void bStart_Click(object sender, System.EventArgs e)
        {
            if (this.ddlCamera.SelectedIndex == 0)
            {
                MessageBox.Show("Seleziona una videocamera");
                return;
            }

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[ddlCamera.SelectedIndex - 1].MonikerString);
            videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
            videoCaptureDevice.Start();

            bStart.Visible = false;
            bStop.Visible = true;
            bStateScanOn.Visible = true;
            bStateScanOff.Visible = false;
            bReset.Visible = true;
            isBarcodeAcquired = false;

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            barcodeBitmap = (Bitmap)eventArgs.Frame.Clone();
            result = barcodeReader.Decode(barcodeBitmap);

            if (result != null && !isBarcodeAcquired)
            {
                
                tbBarcode.Invoke(new MethodInvoker(delegate
                {
                    resultParsed = ResultParser.parseResult(result);
                    barcodeValue = resultParsed.DisplayResult.Replace("]C1", string.Empty);

                    int x = barcodeValue.Count(c => char.IsControl(c));

                    tbBarcode.Text = barcodeValue;
                    lFormat.Text = result.BarcodeFormat.ToString();
                    lLength.Text = barcodeValue.Length.ToString() + " [" + x + "]";
                    bStateScanOn.Visible = false;
                    bStateScanOff.Visible = true;
                }));

                player.Play();

                isBarcodeAcquired = true;
                

            }
            
            pb.Image = barcodeBitmap;
        }

        private void bStop_Click(object sender, System.EventArgs e)
        {
            CloseCamera();
            ResetBarcode();
            pb.Image = null;
            ddlCamera.SelectedIndex = 0;

            bStart.Visible = true;
            bStop.Visible = false;
            bStateScanOn.Visible = bStateScanOff.Visible = bReset.Visible = false;
        }

        private void CloseCamera()
        {
            if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();
        }

        private void ResetBarcode()
        {
            tbBarcode.Text = string.Empty;
            lLength.Text = "0";
            lFormat.Text = "---";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseCamera();
        }

        private void bReset_Click(object sender, System.EventArgs e)
        {
            ResetBarcode();
        }

        private void bStateScanOff_Click(object sender, System.EventArgs e)
        {
            if (isBarcodeAcquired)
            {
                isBarcodeAcquired = false;
                ResetBarcode();
                bStateScanOn.Visible = true;
                bStateScanOff.Visible = false;
            }
        }
    }
}
