namespace RunGame
{
    partial class FormGame
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonAddGamer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.counttt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1150, 698);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // buttonAddGamer
            // 
            this.buttonAddGamer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddGamer.Location = new System.Drawing.Point(1099, 14);
            this.buttonAddGamer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddGamer.Name = "buttonAddGamer";
            this.buttonAddGamer.Size = new System.Drawing.Size(39, 25);
            this.buttonAddGamer.TabIndex = 1;
            this.buttonAddGamer.Text = "+";
            this.buttonAddGamer.UseVisualStyleBackColor = true;
            this.buttonAddGamer.Click += new System.EventHandler(this.buttonAddGamer_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(1049, 14);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(44, 25);
            this.button10.TabIndex = 2;
            this.button10.Text = "+10";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // counttt
            // 
            this.counttt.Location = new System.Drawing.Point(813, 16);
            this.counttt.Name = "counttt";
            this.counttt.Size = new System.Drawing.Size(230, 23);
            this.counttt.TabIndex = 3;
            this.counttt.Text = "button1";
            this.counttt.UseVisualStyleBackColor = true;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 698);
            this.Controls.Add(this.counttt);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonAddGamer);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonAddGamer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button counttt;
    }
}

