using CodeeloUI.Components;
using cxapi;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace FinjectorV2
{
    public partial class Form1 : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Form1()
        {
            InitializeComponent();
            LoadWebViewContent("Monaco/index.html");

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            
            pbStatusRed.Visible = true;
            pbStatusGreen.Visible = false;

            CoreFunctions.setconfig("Finjector", "2.0", "Finjector Injected!");
        }




        private async void LoadWebViewContent(string htmlFile)
        {
            this.Controls.Add(codeEditor);

            await codeEditor.EnsureCoreWebView2Async(null);

            string htmlPath = Path.Combine(Application.StartupPath, htmlFile);
            codeEditor.CoreWebView2.Navigate($"file:///{htmlPath}");
        }

        private async void SetEditorContent(string value)
        {
            try
            {
                string serializedValue = JsonConvert.SerializeObject(value);
                string script = $"setEditorContent({serializedValue})";
                await codeEditor.ExecuteScriptAsync(script);
            }
            catch (Exception ex)
            {
                NotificationManager.ShowErrorNotification(ex.Message);
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            if (CoreFunctions.IsRobloxOpen() && !CoreFunctions.IsInjected())
            {
                CoreFunctions.Inject(false);
                pbStatusRed.Visible = false;
                pbStatusGreen.Visible = true;
                NotificationManager.ShowSuccessNotification("Injected!");
            }
            else if (!CoreFunctions.IsRobloxOpen())
                {NotificationManager.ShowErrorNotification("Roblox NOT found!");}
            else if (CoreFunctions.IsInjected())
                {NotificationManager.ShowErrorNotification("Already Injected!");}
        }

        private async void btnExecute_Click(object sender, EventArgs e)
        {
            string script = "getEditorContent();";
            var result = await codeEditor.ExecuteScriptAsync(script);
            string editorContent = JsonConvert.DeserializeObject<string>(result);

            if (CoreFunctions.IsInjected())
            {
                CoreFunctions.ExecuteScript(editorContent);
                NotificationManager.ShowSuccessNotification("Script Executed!");
            }
            else
            {
                NotificationManager.ShowErrorNotification("Inject please!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetEditorContent("");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!CoreFunctions.IsInjected())
            {
                pbStatusRed.Visible = true;
                pbStatusGreen.Visible = false;
            }
            else
            {
                pbStatusRed.Visible = false;
                pbStatusGreen.Visible = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}