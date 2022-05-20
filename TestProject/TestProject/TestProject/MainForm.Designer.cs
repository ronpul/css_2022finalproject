namespace TestProject
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStrip toolStrip;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.playButton = new System.Windows.Forms.ToolStripButton();
            this.pauseButton = new System.Windows.Forms.ToolStripButton();
            this.stopButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.라이브러리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재생목록만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재생목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재생목록1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.동영상파일명ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.재생목록에추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.생성된재생목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배속재생ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제작자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.messageToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalTimeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.playTimeToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.canvasPanel = new System.Windows.Forms.Panel();
            toolStrip = new System.Windows.Forms.ToolStrip();
            toolStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            toolStrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            toolStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playButton,
            this.pauseButton,
            this.stopButton,
            this.toolStripProgressBar1,
            this.toolStripButton1});
            toolStrip.Location = new System.Drawing.Point(20, 490);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new System.Drawing.Size(767, 27);
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // playButton
            // 
            this.playButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playButton.Image = global::TestProject.Properties.Resources.play;
            this.playButton.ImageTransparentColor = System.Drawing.Color.Red;
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(29, 24);
            this.playButton.Text = "toolStripButton1";
            this.playButton.ToolTipText = "재생";
            this.playButton.Click += new System.EventHandler(this.playButton_Click_1);
            // 
            // pauseButton
            // 
            this.pauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pauseButton.Image = global::TestProject.Properties.Resources.pause;
            this.pauseButton.ImageTransparentColor = System.Drawing.Color.Red;
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(29, 24);
            this.pauseButton.Text = "toolStripButton2";
            this.pauseButton.ToolTipText = "일시정지";
            // 
            // stopButton
            // 
            this.stopButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.stopButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stopButton.Image = global::TestProject.Properties.Resources.stop;
            this.stopButton.ImageTransparentColor = System.Drawing.Color.Red;
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(29, 24);
            this.stopButton.Text = "toolStripButton3";
            this.stopButton.ToolTipText = "정지";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(636, 24);
            this.toolStripProgressBar1.Click += new System.EventHandler(this.toolStripProgressBar1_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.CheckOnClick = true;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "볼륨\r\n";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.PaleGreen;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.라이브러리ToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.도구ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(744, 33);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // 라이브러리ToolStripMenuItem
            // 
            this.라이브러리ToolStripMenuItem.BackgroundImage = global::TestProject.Properties.Resources.play;
            this.라이브러리ToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.라이브러리ToolStripMenuItem.Enabled = false;
            this.라이브러리ToolStripMenuItem.Image = global::TestProject.Properties.Resources.volume;
            this.라이브러리ToolStripMenuItem.Name = "라이브러리ToolStripMenuItem";
            this.라이브러리ToolStripMenuItem.Size = new System.Drawing.Size(34, 29);
            this.라이브러리ToolStripMenuItem.Text = " ";
            this.라이브러리ToolStripMenuItem.Click += new System.EventHandler(this.라이브러리ToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.toolStripMenuItem1,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.fileToolStripMenuItem.Text = "파일(&F)";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(173, 30);
            this.openMenuItem.Text = "열기(&O)...";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click_1);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(173, 30);
            this.exitMenuItem.Text = "종료(&X)";
            // 
            // 도구ToolStripMenuItem
            // 
            this.도구ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재생목록만들기ToolStripMenuItem,
            this.재생목록ToolStripMenuItem,
            this.재생목록에추가ToolStripMenuItem,
            this.배속재생ToolStripMenuItem});
            this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
            this.도구ToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.도구ToolStripMenuItem.Text = "도구";
            // 
            // 재생목록만들기ToolStripMenuItem
            // 
            this.재생목록만들기ToolStripMenuItem.Name = "재생목록만들기ToolStripMenuItem";
            this.재생목록만들기ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.재생목록만들기ToolStripMenuItem.Text = "재생목록 만들기";
            // 
            // 재생목록ToolStripMenuItem
            // 
            this.재생목록ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.재생목록1ToolStripMenuItem});
            this.재생목록ToolStripMenuItem.Name = "재생목록ToolStripMenuItem";
            this.재생목록ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.재생목록ToolStripMenuItem.Text = "재생목록";
            // 
            // 재생목록1ToolStripMenuItem
            // 
            this.재생목록1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.동영상파일명ToolStripMenuItem});
            this.재생목록1ToolStripMenuItem.Name = "재생목록1ToolStripMenuItem";
            this.재생목록1ToolStripMenuItem.Size = new System.Drawing.Size(169, 30);
            this.재생목록1ToolStripMenuItem.Text = "재생목록1";
            // 
            // 동영상파일명ToolStripMenuItem
            // 
            this.동영상파일명ToolStripMenuItem.Name = "동영상파일명ToolStripMenuItem";
            this.동영상파일명ToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.동영상파일명ToolStripMenuItem.Text = "동영상 파일명";
            // 
            // 재생목록에추가ToolStripMenuItem
            // 
            this.재생목록에추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.생성된재생목록ToolStripMenuItem});
            this.재생목록에추가ToolStripMenuItem.Name = "재생목록에추가ToolStripMenuItem";
            this.재생목록에추가ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.재생목록에추가ToolStripMenuItem.Text = "재생목록에 추가";
            // 
            // 생성된재생목록ToolStripMenuItem
            // 
            this.생성된재생목록ToolStripMenuItem.Name = "생성된재생목록ToolStripMenuItem";
            this.생성된재생목록ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.생성된재생목록ToolStripMenuItem.Text = "생성된 재생목록";
            // 
            // 배속재생ToolStripMenuItem
            // 
            this.배속재생ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.배속재생ToolStripMenuItem.Name = "배속재생ToolStripMenuItem";
            this.배속재생ToolStripMenuItem.Size = new System.Drawing.Size(208, 30);
            this.배속재생ToolStripMenuItem.Text = "배속재생";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 30);
            this.toolStripMenuItem3.Text = "0.5";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(125, 30);
            this.toolStripMenuItem4.Text = "1.0";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(125, 30);
            this.toolStripMenuItem5.Text = "1.5";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(125, 30);
            this.toolStripMenuItem6.Text = "2.0";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.제작자ToolStripMenuItem});
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // 제작자ToolStripMenuItem
            // 
            this.제작자ToolStripMenuItem.Name = "제작자ToolStripMenuItem";
            this.제작자ToolStripMenuItem.Size = new System.Drawing.Size(143, 30);
            this.제작자ToolStripMenuItem.Text = "제작자";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.messageToolStripStatusLabel,
            this.playTimeToolStripStatusLabel,
            this.totalTimeToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(20, 507);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(744, 31);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // messageToolStripStatusLabel
            // 
            this.messageToolStripStatusLabel.Name = "messageToolStripStatusLabel";
            this.messageToolStripStatusLabel.Size = new System.Drawing.Size(510, 25);
            this.messageToolStripStatusLabel.Spring = true;
            this.messageToolStripStatusLabel.Text = "준비중..";
            this.messageToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalTimeToolStripStatusLabel
            // 
            this.totalTimeToolStripStatusLabel.Name = "totalTimeToolStripStatusLabel";
            this.totalTimeToolStripStatusLabel.Size = new System.Drawing.Size(90, 25);
            this.totalTimeToolStripStatusLabel.Text = "00:00:00";
            // 
            // playTimeToolStripStatusLabel
            // 
            this.playTimeToolStripStatusLabel.Name = "playTimeToolStripStatusLabel";
            this.playTimeToolStripStatusLabel.Size = new System.Drawing.Size(90, 25);
            this.playTimeToolStripStatusLabel.Text = "00:00:00";
            // 
            // canvasPanel
            // 
            this.canvasPanel.BackColor = System.Drawing.Color.Black;
            this.canvasPanel.Location = new System.Drawing.Point(20, 91);
            this.canvasPanel.Name = "canvasPanel";
            this.canvasPanel.Size = new System.Drawing.Size(744, 397);
            this.canvasPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::TestProject.Properties.Resources.istockphoto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 558);
            this.Controls.Add(toolStrip);
            this.Controls.Add(this.canvasPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "C#프로그래밍 텀프로젝트";
            this.Load += new System.EventHandler(this.MainForm_Load);
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel messageToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel totalTimeToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel playTimeToolStripStatusLabel;
        private System.Windows.Forms.Panel canvasPanel;
        private System.Windows.Forms.ToolStripButton playButton;
        private System.Windows.Forms.ToolStripButton pauseButton;
        private System.Windows.Forms.ToolStripButton stopButton;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripMenuItem 라이브러리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재생목록만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재생목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재생목록1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 동영상파일명ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 재생목록에추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 생성된재생목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배속재생ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 제작자ToolStripMenuItem;
    }
}

