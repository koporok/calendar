namespace calendar
{
    partial class create_group
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
            this.обои_authorization = new System.Windows.Forms.Panel();
            this.description = new System.Windows.Forms.TextBox();
            this.nameID = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.обои_authorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // обои_authorization
            // 
            this.обои_authorization.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.обои_authorization.BackgroundImage = global::calendar.Properties.Resources.обои_ночь;
            this.обои_authorization.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.обои_authorization.Controls.Add(this.description);
            this.обои_authorization.Controls.Add(this.nameID);
            this.обои_authorization.Controls.Add(this.buttonLogin);
            this.обои_authorization.Controls.Add(this.name);
            this.обои_authorization.Controls.Add(this.label2);
            this.обои_authorization.Cursor = System.Windows.Forms.Cursors.Hand;
            this.обои_authorization.ForeColor = System.Drawing.Color.Transparent;
            this.обои_authorization.Location = new System.Drawing.Point(-331, -52);
            this.обои_authorization.Name = "обои_authorization";
            this.обои_authorization.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.обои_authorization.Size = new System.Drawing.Size(771, 562);
            this.обои_authorization.TabIndex = 1;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.description.Location = new System.Drawing.Point(386, 200);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(268, 51);
            this.description.TabIndex = 14;
            this.description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.description.Enter += new System.EventHandler(this.description_Enter);
            this.description.Leave += new System.EventHandler(this.description_Leave);
            // 
            // nameID
            // 
            this.nameID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.nameID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameID.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameID.Location = new System.Drawing.Point(387, 269);
            this.nameID.Name = "nameID";
            this.nameID.Size = new System.Drawing.Size(266, 29);
            this.nameID.TabIndex = 13;
            this.nameID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nameID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.nameID.Enter += new System.EventHandler(this.nameID_Enter);
            this.nameID.Leave += new System.EventHandler(this.nameID_Leave);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(182)))), ((int)(((byte)(79)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(136)))), ((int)(((byte)(79)))));
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(51)))));
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(136)))), ((int)(((byte)(79)))));
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLogin.Location = new System.Drawing.Point(388, 306);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(264, 39);
            this.buttonLogin.TabIndex = 8;
            this.buttonLogin.Text = "Создать ";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(388, 152);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(265, 29);
            this.name.TabIndex = 6;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.name.Enter += new System.EventHandler(this.loginField_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Niagara Solid", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(379, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Созданать свою группу ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // create_group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(371, 335);
            this.Controls.Add(this.обои_authorization);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "create_group";
            this.Text = "create_group";
            this.обои_authorization.ResumeLayout(false);
            this.обои_authorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel обои_authorization;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameID;
        private System.Windows.Forms.TextBox description;
    }
}