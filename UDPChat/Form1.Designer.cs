namespace UDPChat
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
            this.NUPort = new System.Windows.Forms.NumericUpDown();
            this.textBoxAllmess = new System.Windows.Forms.TextBox();
            this.textBoxMess = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.MTIPadress = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUPort)).BeginInit();
            this.SuspendLayout();
            // 
            // NUPort
            // 
            this.NUPort.Location = new System.Drawing.Point(184, 29);
            this.NUPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUPort.Name = "NUPort";
            this.NUPort.Size = new System.Drawing.Size(120, 20);
            this.NUPort.TabIndex = 1;
            this.NUPort.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // textBoxAllmess
            // 
            this.textBoxAllmess.Location = new System.Drawing.Point(37, 75);
            this.textBoxAllmess.Multiline = true;
            this.textBoxAllmess.Name = "textBoxAllmess";
            this.textBoxAllmess.Size = new System.Drawing.Size(714, 293);
            this.textBoxAllmess.TabIndex = 2;
            // 
            // textBoxMess
            // 
            this.textBoxMess.Location = new System.Drawing.Point(37, 397);
            this.textBoxMess.Multiline = true;
            this.textBoxMess.Name = "textBoxMess";
            this.textBoxMess.Size = new System.Drawing.Size(606, 27);
            this.textBoxMess.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(659, 397);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(92, 27);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(378, 27);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(127, 23);
            this.buttonConnect.TabIndex = 5;
            this.buttonConnect.Text = "подключение";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // MTIPadress
            // 
            this.MTIPadress.Location = new System.Drawing.Point(37, 28);
            this.MTIPadress.Name = "MTIPadress";
            this.MTIPadress.Size = new System.Drawing.Size(100, 20);
            this.MTIPadress.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MTIPadress);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMess);
            this.Controls.Add(this.textBoxAllmess);
            this.Controls.Add(this.NUPort);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.NUPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NUPort;
        private System.Windows.Forms.TextBox textBoxAllmess;
        private System.Windows.Forms.TextBox textBoxMess;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.TextBox MTIPadress;
    }
}

