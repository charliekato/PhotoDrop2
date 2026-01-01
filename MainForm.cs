using System.Diagnostics;

namespace PhotoDrop2;

public partial class MainForm : Form
{
    const int Port = 5540;
    Process serverProcess;
    public MainForm()
    {
        InitializeComponent();
#pragma warning disable CS8622 // パラメーターの型における参照型の NULL 値の許容が、ターゲット デリゲートと一致しません。おそらく、NULL 値の許容の属性が原因です。
        this.Load += MainForm_Load;
#pragma warning restore CS8622 // パラメーターの型における参照型の NULL 値の許容が、ターゲット デリゲートと一致しません。おそらく、NULL 値の許容の属性が原因です。
    }
    private void MainForm_Load(object sender, EventArgs e)
    {
        string ip = NetworkUtil.GetLocalIP();
        string url = $"http://{ip}:{Port}/";

        pictureBoxQRCode.Image = QrUtil.Generate(url);
        label1.Text = url;
	if (Process.GetProcessesByName("PhotoUploader").Any())
	{
	    MessageBox.Show("Web server is already running.");
	    return;
	}


        StartServer();


    }

    void StartServer()
    {
        serverProcess = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "PhotoUpLoader.exe",
                UseShellExecute = false,
            }
        };
        serverProcess.Start();
    }

    private void MainForm_Closing(object sender, FormClosingEventArgs e)
    {
        /*

        if (serverProcess != null && !serverProcess.HasExited)
        {
            serverProcess.CloseMainWindow(); // ← 正常終了要求
            serverProcess.WaitForExit(300);

            if (!serverProcess.HasExited)
            {
                serverProcess.Kill(); // 最終手段
            }
        }
        */

    }
}
