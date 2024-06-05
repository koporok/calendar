namespace calendar
{
    partial class EventFrom
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
            this.date = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bynSave = new System.Windows.Forms.Button();
            this.Dateе = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(41, 55);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(346, 20);
            this.date.TabIndex = 0;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(41, 107);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(346, 46);
            this.description.TabIndex = 1;
            this.description.TextChanged += new System.EventHandler(this.description_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Event";
            // 
            // bynSave
            // 
            this.bynSave.Location = new System.Drawing.Point(312, 170);
            this.bynSave.Name = "bynSave";
            this.bynSave.Size = new System.Drawing.Size(75, 23);
            this.bynSave.TabIndex = 4;
            this.bynSave.Text = "Сохранить ";
            this.bynSave.UseVisualStyleBackColor = true;
            this.bynSave.Click += new System.EventHandler(this.bynSave_Click);
            // 
            // Dateе
            // 
            this.Dateе.AutoSize = true;
            this.Dateе.Location = new System.Drawing.Point(51, 65);
            this.Dateе.Name = "Dateе";
            this.Dateе.Size = new System.Drawing.Size(0, 13);
            this.Dateе.TabIndex = 5;
            this.Dateе.Click += new System.EventHandler(this.label3_Click);
            // 
            // EventFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 205);
            this.Controls.Add(this.Dateе);
            this.Controls.Add(this.bynSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.date);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EventFrom";
            this.Text = "EventFrom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bynSave;
        private System.Windows.Forms.Label Dateе;
    }
}