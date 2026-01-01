namespace PhotoDrop2;

partial class MainForm
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
        pictureBoxQRCode = new PictureBox();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).BeginInit();
        SuspendLayout();
        // 
        // pictureBoxQRCode
        // 
        pictureBoxQRCode.Dock = DockStyle.Top;
        pictureBoxQRCode.Location = new Point(0, 0);
        pictureBoxQRCode.Name = "pictureBoxQRCode";
        pictureBoxQRCode.Size = new Size(847, 676);
        pictureBoxQRCode.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBoxQRCode.TabIndex = 0;
        pictureBoxQRCode.TabStop = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Yu Gothic UI", 20F);
        label1.Location = new Point(208, 689);
        label1.Name = "label1";
        label1.Size = new Size(0, 46);
        label1.TabIndex = 1;
        label1.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(847, 756);
        Controls.Add(label1);
        Controls.Add(pictureBoxQRCode);
        Name = "MainForm";
        Text = "PhotoDrop";
        FormClosing += MainForm_Closing;
        ((System.ComponentModel.ISupportInitialize)pictureBoxQRCode).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxQRCode;
    private Label label1;
}
