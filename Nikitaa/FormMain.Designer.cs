namespace ScreenSaverApp
{
    partial class FormMain
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
            this.pctMain = new System.Windows.Forms.PictureBox();
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pctMain
            // 
            this.pctMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctMain.Location = new System.Drawing.Point(0, 0);
            this.pctMain.Name = "pctMain";
            this.pctMain.Size = new System.Drawing.Size(800, 450);
            this.pctMain.TabIndex = 0;
            this.pctMain.TabStop = false;
            this.pctMain.Click += new System.EventHandler(this.FormMain_Click);
            this.pctMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pctMain_Paint);
            // 
            // tmrMove
            // 
            this.tmrMove.Interval = 24;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pctMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.Click += new System.EventHandler(this.FormMain_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pctMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMain;
        private System.Windows.Forms.Timer tmrMove;
    }
}

