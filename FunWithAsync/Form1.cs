using System;
using System.Windows.Forms;

namespace FunWithAsync
{
    public partial class Form1 : Form
    {
        private const long MagicNumber = 39;

        private long _timesClicked;

        private DownloadService _downloadService;
        private ComputeService _computeService;

        public Form1()
        {
            InitializeComponent();
            _downloadService = new DownloadService();
            _computeService = new ComputeService();
        }

        // ===================== IO Bound =============================

        private void DownloadBlocking_Click(object sender, EventArgs e)
        {
            var result = _downloadService.GetSite("http://www.redarrowlabs.com/");
            ResultArea.Text = result;
        }

        private async void DownloadAsync_Click(object sender, EventArgs e)
        {
            var result = _downloadService.GetSiteAsync("http://www.redarrowlabs.com/");
            ResultArea.Text = await result;
        }

        // ===================== CPU Bound =============================

        private void ComputeBlocking_Click(object sender, EventArgs e)
        {
            var result = _computeService.Compute(MagicNumber);
            ResultArea.Text = "The result was: " + result;
        }

        private async void ComputeAsync_Click(object sender, EventArgs e)
        {
            
            var resultTask = _computeService.ComputeBackground(MagicNumber);
            var result = await resultTask;
            ResultArea.Text = "The result was: " + result;

            //Exceptions are handled the same way as synchronous code.
            //It will be fired upon awaiting the task.

            //try
            //{
            //    var resultTask = _computeService.ComputeBackground(MagicNumber);
            //    var result = await resultTask;
            //    ResultArea.Text = "The result was: " + result;
            //}
            //catch (Exception ex)
            //{
            //    ResultArea.Text = ex.Message;
            //}
        }

        // ===== Counter and clear =====

        private void CounterButton_Click(object sender, EventArgs e)
        {
            _timesClicked++;
            ClickTracker.Text = "Clicks: " + _timesClicked;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultArea.Text = string.Empty;
        }
    }
}