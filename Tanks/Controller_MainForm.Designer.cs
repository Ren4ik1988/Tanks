namespace Tanks
{
    partial class Controller_MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Controller_MainForm));
            this.StartStop_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartStop_btn
            // 
            this.StartStop_btn.Location = new System.Drawing.Point(397, 30);
            this.StartStop_btn.Name = "StartStop_btn";
            this.StartStop_btn.Size = new System.Drawing.Size(75, 23);
            this.StartStop_btn.TabIndex = 0;
            this.StartStop_btn.Text = "Start/Stop";
            this.StartStop_btn.UseVisualStyleBackColor = true;
            this.StartStop_btn.Click += new System.EventHandler(this.StartStop_btn_Click);
            // 
            // Controller_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.StartStop_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Controller_MainForm";
            this.Text = "Танки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Controller_MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartStop_btn;
    }
}

