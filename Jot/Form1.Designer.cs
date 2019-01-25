namespace Jot
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToolBar = new System.Windows.Forms.Panel();
            this.docViewer = new System.Windows.Forms.Panel();
            this.docPadPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textAreaPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.docViewer.SuspendLayout();
            this.docPadPanel.SuspendLayout();
            this.textAreaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(51, 561);
            this.ToolBar.TabIndex = 0;
            // 
            // docViewer
            // 
            this.docViewer.AutoScroll = true;
            this.docViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.docViewer.Controls.Add(this.docPadPanel);
            this.docViewer.Controls.Add(this.label1);
            this.docViewer.Dock = System.Windows.Forms.DockStyle.Left;
            this.docViewer.Location = new System.Drawing.Point(51, 0);
            this.docViewer.MaximumSize = new System.Drawing.Size(1000, 0);
            this.docViewer.Name = "docViewer";
            this.docViewer.Padding = new System.Windows.Forms.Padding(10);
            this.docViewer.Size = new System.Drawing.Size(200, 561);
            this.docViewer.TabIndex = 1;
            // 
            // docPadPanel
            // 
            this.docPadPanel.Controls.Add(this.listBox1);
            this.docPadPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docPadPanel.Location = new System.Drawing.Point(10, 25);
            this.docPadPanel.Name = "docPadPanel";
            this.docPadPanel.Padding = new System.Windows.Forms.Padding(5);
            this.docPadPanel.Size = new System.Drawing.Size(180, 526);
            this.docPadPanel.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(48)))), ((int)(((byte)(53)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "saccsda",
            "csc",
            "asdcas",
            "casc"});
            this.listBox1.Location = new System.Drawing.Point(5, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(170, 516);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPLORER";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(251, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 561);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // textAreaPanel
            // 
            this.textAreaPanel.Controls.Add(this.richTextBox1);
            this.textAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textAreaPanel.Location = new System.Drawing.Point(254, 0);
            this.textAreaPanel.Name = "textAreaPanel";
            this.textAreaPanel.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.textAreaPanel.Size = new System.Drawing.Size(530, 561);
            this.textAreaPanel.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(10, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(510, 537);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.textAreaPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.docViewer);
            this.Controls.Add(this.ToolBar);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "mainForm";
            this.Text = "Jot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.docViewer.ResumeLayout(false);
            this.docViewer.PerformLayout();
            this.docPadPanel.ResumeLayout(false);
            this.textAreaPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ToolBar;
        private System.Windows.Forms.Panel docViewer;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel textAreaPanel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel docPadPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

