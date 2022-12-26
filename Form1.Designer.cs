
namespace courseWork
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tbDirection = new System.Windows.Forms.TrackBar();
            this.lb1Direction = new System.Windows.Forms.Label();
            this.tbSpreading = new System.Windows.Forms.TrackBar();
            this.lbSpreading = new System.Windows.Forms.Label();
            this.tbPerTic = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPerTic = new System.Windows.Forms.Label();
            this.lbSpeed = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPerTic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(2, 2);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(800, 446);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            this.picDisplay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picDisplay_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tbDirection
            // 
            this.tbDirection.Location = new System.Drawing.Point(808, 42);
            this.tbDirection.Maximum = 359;
            this.tbDirection.Name = "tbDirection";
            this.tbDirection.Size = new System.Drawing.Size(275, 56);
            this.tbDirection.TabIndex = 1;
            this.tbDirection.Scroll += new System.EventHandler(this.tbDirection_Scroll);
            // 
            // lb1Direction
            // 
            this.lb1Direction.AutoSize = true;
            this.lb1Direction.Location = new System.Drawing.Point(1089, 59);
            this.lb1Direction.Name = "lb1Direction";
            this.lb1Direction.Size = new System.Drawing.Size(0, 17);
            this.lb1Direction.TabIndex = 2;
            // 
            // tbSpreading
            // 
            this.tbSpreading.Location = new System.Drawing.Point(814, 128);
            this.tbSpreading.Maximum = 100;
            this.tbSpreading.Name = "tbSpreading";
            this.tbSpreading.Size = new System.Drawing.Size(275, 56);
            this.tbSpreading.TabIndex = 3;
            this.tbSpreading.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbSpreading
            // 
            this.lbSpreading.AutoSize = true;
            this.lbSpreading.Location = new System.Drawing.Point(1089, 139);
            this.lbSpreading.Name = "lbSpreading";
            this.lbSpreading.Size = new System.Drawing.Size(0, 17);
            this.lbSpreading.TabIndex = 4;
            // 
            // tbPerTic
            // 
            this.tbPerTic.Location = new System.Drawing.Point(814, 227);
            this.tbPerTic.Maximum = 1000;
            this.tbPerTic.Name = "tbPerTic";
            this.tbPerTic.Size = new System.Drawing.Size(275, 56);
            this.tbPerTic.TabIndex = 5;
            this.tbPerTic.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(826, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Направление";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Разброс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(826, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Количество ";
            // 
            // lbPerTic
            // 
            this.lbPerTic.AutoSize = true;
            this.lbPerTic.Location = new System.Drawing.Point(1089, 240);
            this.lbPerTic.Name = "lbPerTic";
            this.lbPerTic.Size = new System.Drawing.Size(0, 17);
            this.lbPerTic.TabIndex = 9;
            // 
            // lbSpeed
            // 
            this.lbSpeed.AutoSize = true;
            this.lbSpeed.Location = new System.Drawing.Point(1089, 327);
            this.lbSpeed.Name = "lbSpeed";
            this.lbSpeed.Size = new System.Drawing.Size(0, 17);
            this.lbSpeed.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(826, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Скорость";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(814, 316);
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(275, 56);
            this.tbSpeed.TabIndex = 10;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 510);
            this.Controls.Add(this.lbSpeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSpeed);
            this.Controls.Add(this.lbPerTic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPerTic);
            this.Controls.Add(this.lbSpreading);
            this.Controls.Add(this.tbSpreading);
            this.Controls.Add(this.lb1Direction);
            this.Controls.Add(this.tbDirection);
            this.Controls.Add(this.picDisplay);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpreading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPerTic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar tbDirection;
        private System.Windows.Forms.Label lb1Direction;
        private System.Windows.Forms.TrackBar tbSpreading;
        private System.Windows.Forms.Label lbSpreading;
        private System.Windows.Forms.TrackBar tbPerTic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbPerTic;
        private System.Windows.Forms.Label lbSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar tbSpeed;
    }
}

