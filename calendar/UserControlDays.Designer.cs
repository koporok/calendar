﻿namespace calendar
{
    partial class UserControlDays
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ibdays = new System.Windows.Forms.Label();
            this.Ibevent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Ibdays
            // 
            this.Ibdays.AutoSize = true;
            this.Ibdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ibdays.Location = new System.Drawing.Point(12, 10);
            this.Ibdays.Name = "Ibdays";
            this.Ibdays.Size = new System.Drawing.Size(24, 18);
            this.Ibdays.TabIndex = 0;
            this.Ibdays.Text = "00";
            // 
            // Ibevent
            // 
            this.Ibevent.Location = new System.Drawing.Point(12, 41);
            this.Ibevent.Name = "Ibevent";
            this.Ibevent.Size = new System.Drawing.Size(96, 44);
            this.Ibevent.TabIndex = 1;
            this.Ibevent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.Ibevent);
            this.Controls.Add(this.Ibdays);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(114, 85);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.Click += new System.EventHandler(this.UserControlDays_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Ibdays;
        private System.Windows.Forms.Label Ibevent;
        private System.Windows.Forms.Timer timer1;
    }
}
