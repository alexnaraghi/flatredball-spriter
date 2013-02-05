using System;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace OfficialPlugins.FrbUpdater
{
    public partial class FrbUpdaterPluginForm : Form
    {
        const bool ShowCurrent = false;

        private FrbUpdaterSettings _settings;
        private readonly FrbUpdaterPlugin _plugin;

        public FrbUpdaterPluginForm(FrbUpdaterPlugin plugin)
        {
            StartPosition = FormStartPosition.Manual;

            InitializeComponent();
            _plugin = plugin;
        }

        private void BuildMenu()
        {
            cbSyncTo.Items.Clear();

            cbSyncTo.Items.Add("Daily Build");

            // Current is now the daily build:
            if (ShowCurrent)
            {
                cbSyncTo.Items.Add("Current");
            }
            var date = DateTime.Now;

            for (var i = 0; i < 7; i++)
            {
                AddMonth(date.AddMonths(-i));
            }
        }

        private void AddMonth(DateTime date)
        {
            const string path = "http://www.flatredball.com/content/FrbXnaTemplates/";

            try
            {
                //This Month
                var curPath = path + date.ToString("yyyy") + "/" + date.ToString("MMMM") + "/FRBDK.zip";
                var url = new Uri(curPath);
                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = (HttpWebResponse)request.GetResponse();
                response.Close();

                cbSyncTo.Items.Add(date.ToString("MMMM") + " " + date.ToString("yyyy"));
            }
            catch (Exception)
            {
            }
        }

        private void FrbUpdaterPluginForm_Load(object sender, EventArgs e)
        {
            BuildMenu();
            _settings = FrbUpdaterSettings.LoadSettings();
            cbSyncTo.Text = _settings.SelectedSource;
            if (!ShowCurrent && cbSyncTo.Text == "Current")
            {
                cbSyncTo.Text = "Daily Build";
            }
            chkAutoUpdate.Checked = _settings.AutoUpdate;
        }

        private void chkAutoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            _settings.AutoUpdate = chkAutoUpdate.Checked;
        }

        private void btnUpdater_Click(object sender, EventArgs e)
        {
            var inList = false;
            foreach (var item in cbSyncTo.Items.Cast<string>().Where(item => cbSyncTo.Text == item))
            {
                inList = true;
            }

            if (!inList)
            {
                MessageBox.Show(@"Must pick source to sync to.");
                return;
            }

            _settings.SelectedSource = cbSyncTo.Text;
            _settings.AutoUpdate = chkAutoUpdate.Checked;
            _settings.SaveSettings();

            var window = new UpdateWindow(_plugin);

            _plugin.GlueCommands.DialogCommands.SetFormOwner(window);
            if (window.Owner == null)
                window.TopMost = true;
            window.Show();
            Close();
        }

        private void FrbUpdaterPluginForm_Shown(object sender, EventArgs e)
        {

            // This will be set in OnShow after all controls 
            // have been added because we want to center the control 
            // where the mouse is.
            Location = new Point(FrbUpdaterPluginForm.MousePosition.X - this.Width/2, FrbUpdaterPluginForm.MousePosition.Y - this.Height/2);
        }
    }
}
