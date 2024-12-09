namespace openCV_6620301001
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            recStatus = new Label();
            camStatus = new Label();
            label2 = new Label();
            label1 = new Label();
            controlGroup = new GroupBox();
            FlipVer = new Button();
            FlipHor = new Button();
            Start = new Button();
            Connect = new Button();
            groupBoxLive = new GroupBox();
            imageBoxLive = new Emgu.CV.UI.ImageBox();
            groupBox1.SuspendLayout();
            controlGroup.SuspendLayout();
            groupBoxLive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(recStatus);
            groupBox1.Controls.Add(camStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(165, 562);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 52);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // recStatus
            // 
            recStatus.AutoSize = true;
            recStatus.Location = new Point(401, 24);
            recStatus.Name = "recStatus";
            recStatus.Size = new Size(0, 20);
            recStatus.TabIndex = 5;
            // 
            // camStatus
            // 
            camStatus.AutoSize = true;
            camStatus.Location = new Point(201, 24);
            camStatus.Name = "camStatus";
            camStatus.Size = new Size(0, 20);
            camStatus.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 24);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Recond :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 24);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 2;
            label1.Text = "Camara :";
            // 
            // controlGroup
            // 
            controlGroup.Anchor = AnchorStyles.None;
            controlGroup.Controls.Add(FlipVer);
            controlGroup.Controls.Add(FlipHor);
            controlGroup.Controls.Add(Start);
            controlGroup.Controls.Add(Connect);
            controlGroup.Location = new Point(165, 446);
            controlGroup.Name = "controlGroup";
            controlGroup.Size = new Size(567, 117);
            controlGroup.TabIndex = 5;
            controlGroup.TabStop = false;
            controlGroup.Text = "Control Panel";
            // 
            // FlipVer
            // 
            FlipVer.Location = new Point(401, 75);
            FlipVer.Name = "FlipVer";
            FlipVer.Size = new Size(123, 37);
            FlipVer.TabIndex = 5;
            FlipVer.Text = "FlipVertical";
            FlipVer.UseVisualStyleBackColor = true;
            FlipVer.Click += FlipVer_Click;
            // 
            // FlipHor
            // 
            FlipHor.Location = new Point(401, 27);
            FlipHor.Name = "FlipHor";
            FlipHor.Size = new Size(123, 41);
            FlipHor.TabIndex = 4;
            FlipHor.Text = "FlipHorizon";
            FlipHor.UseVisualStyleBackColor = true;
            FlipHor.Click += FlipHor_Click;
            // 
            // Start
            // 
            Start.Enabled = false;
            Start.Location = new Point(182, 36);
            Start.Name = "Start";
            Start.Size = new Size(139, 65);
            Start.TabIndex = 2;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // Connect
            // 
            Connect.Location = new Point(47, 36);
            Connect.Name = "Connect";
            Connect.Size = new Size(128, 65);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // groupBoxLive
            // 
            groupBoxLive.Anchor = AnchorStyles.None;
            groupBoxLive.Controls.Add(imageBoxLive);
            groupBoxLive.Location = new Point(155, 61);
            groupBoxLive.Name = "groupBoxLive";
            groupBoxLive.Size = new Size(570, 380);
            groupBoxLive.TabIndex = 4;
            groupBoxLive.TabStop = false;
            groupBoxLive.Text = "Live view";
            // 
            // imageBoxLive
            // 
            imageBoxLive.Anchor = AnchorStyles.None;
            imageBoxLive.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            imageBoxLive.Location = new Point(10, 16);
            imageBoxLive.Name = "imageBoxLive";
            imageBoxLive.Size = new Size(558, 348);
            imageBoxLive.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBoxLive.TabIndex = 2;
            imageBoxLive.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 674);
            Controls.Add(groupBox1);
            Controls.Add(controlGroup);
            Controls.Add(groupBoxLive);
            Name = "FormMain";
            Text = "FormMain";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            controlGroup.ResumeLayout(false);
            groupBoxLive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imageBoxLive).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label recStatus;
        private Label camStatus;
        private Label label2;
        private Label label1;
        private GroupBox controlGroup;
        private Button FlipVer;
        private Button FlipHor;
        private Button Start;
        private Button Connect;
        private GroupBox groupBoxLive;
        private Emgu.CV.UI.ImageBox imageBoxLive;
    }
}
