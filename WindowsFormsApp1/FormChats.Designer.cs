namespace WindowsFormsApp1
{
    partial class FormChats
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
            this.components = new System.ComponentModel.Container();
            this.panelChatTitulo = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.labelChatNombre = new System.Windows.Forms.Label();
            this.cpbChat = new WindowsFormsApp1.CircularPictureBox();
            this.panelChatInfo = new System.Windows.Forms.Panel();
            this.labelChatInfoNombre = new System.Windows.Forms.Label();
            this.cpbChatInfo = new WindowsFormsApp1.CircularPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPerfilClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.timerAbrir = new System.Windows.Forms.Timer(this.components);
            this.timerCerrar = new System.Windows.Forms.Timer(this.components);
            this.panelChatTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbChat)).BeginInit();
            this.panelChatInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbChatInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelChatTitulo
            // 
            this.panelChatTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelChatTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChatTitulo.Controls.Add(this.iconButton1);
            this.panelChatTitulo.Controls.Add(this.iconButton2);
            this.panelChatTitulo.Controls.Add(this.labelChatNombre);
            this.panelChatTitulo.Controls.Add(this.cpbChat);
            this.panelChatTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChatTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelChatTitulo.Name = "panelChatTitulo";
            this.panelChatTitulo.Size = new System.Drawing.Size(944, 75);
            this.panelChatTitulo.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(821, 20);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(42, 33);
            this.iconButton1.TabIndex = 13;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.EllipsisV;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 25;
            this.iconButton2.Location = new System.Drawing.Point(869, 20);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 33);
            this.iconButton2.TabIndex = 12;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // labelChatNombre
            // 
            this.labelChatNombre.AutoSize = true;
            this.labelChatNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatNombre.ForeColor = System.Drawing.Color.White;
            this.labelChatNombre.Location = new System.Drawing.Point(72, 24);
            this.labelChatNombre.Name = "labelChatNombre";
            this.labelChatNombre.Size = new System.Drawing.Size(55, 21);
            this.labelChatNombre.TabIndex = 3;
            this.labelChatNombre.Text = "Pekke";
            // 
            // cpbChat
            // 
            this.cpbChat.BackColor = System.Drawing.Color.White;
            this.cpbChat.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cpbChat.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cpbChat.BorderColor2 = System.Drawing.Color.HotPink;
            this.cpbChat.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cpbChat.BorderSize = 2;
            this.cpbChat.GradientAngle = 50F;
            this.cpbChat.Image = global::WindowsFormsApp1.Properties.Resources.pp__1_;
            this.cpbChat.Location = new System.Drawing.Point(4, 4);
            this.cpbChat.Name = "cpbChat";
            this.cpbChat.Size = new System.Drawing.Size(62, 62);
            this.cpbChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbChat.TabIndex = 7;
            this.cpbChat.TabStop = false;
            // 
            // panelChatInfo
            // 
            this.panelChatInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChatInfo.Controls.Add(this.labelChatInfoNombre);
            this.panelChatInfo.Controls.Add(this.cpbChatInfo);
            this.panelChatInfo.Controls.Add(this.panel2);
            this.panelChatInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelChatInfo.Location = new System.Drawing.Point(944, 0);
            this.panelChatInfo.Name = "panelChatInfo";
            this.panelChatInfo.Size = new System.Drawing.Size(0, 596);
            this.panelChatInfo.TabIndex = 1;
            // 
            // labelChatInfoNombre
            // 
            this.labelChatInfoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelChatInfoNombre.AutoSize = true;
            this.labelChatInfoNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatInfoNombre.ForeColor = System.Drawing.Color.White;
            this.labelChatInfoNombre.Location = new System.Drawing.Point(125, 335);
            this.labelChatInfoNombre.Name = "labelChatInfoNombre";
            this.labelChatInfoNombre.Size = new System.Drawing.Size(73, 21);
            this.labelChatInfoNombre.TabIndex = 15;
            this.labelChatInfoNombre.Text = "Nombre";
            // 
            // cpbChatInfo
            // 
            this.cpbChatInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpbChatInfo.BackColor = System.Drawing.Color.White;
            this.cpbChatInfo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cpbChatInfo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cpbChatInfo.BorderColor2 = System.Drawing.Color.HotPink;
            this.cpbChatInfo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cpbChatInfo.BorderSize = 2;
            this.cpbChatInfo.GradientAngle = 50F;
            this.cpbChatInfo.Location = new System.Drawing.Point(72, 110);
            this.cpbChatInfo.Name = "cpbChatInfo";
            this.cpbChatInfo.Size = new System.Drawing.Size(0, 0);
            this.cpbChatInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbChatInfo.TabIndex = 14;
            this.cpbChatInfo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnPerfilClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 75);
            this.panel2.TabIndex = 0;
            // 
            // btnPerfilClose
            // 
            this.btnPerfilClose.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfilClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfilClose.FlatAppearance.BorderSize = 0;
            this.btnPerfilClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPerfilClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPerfilClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPerfilClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnPerfilClose.IconColor = System.Drawing.Color.White;
            this.btnPerfilClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfilClose.IconSize = 25;
            this.btnPerfilClose.Location = new System.Drawing.Point(5, 20);
            this.btnPerfilClose.Name = "btnPerfilClose";
            this.btnPerfilClose.Size = new System.Drawing.Size(35, 33);
            this.btnPerfilClose.TabIndex = 14;
            this.btnPerfilClose.UseVisualStyleBackColor = false;
            this.btnPerfilClose.Click += new System.EventHandler(this.btnPerfilClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(67, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Info del Contacto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.iconButton5);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.rjTextBox1);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 550);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 46);
            this.panel1.TabIndex = 2;
            // 
            // iconButton5
            // 
            this.iconButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton5.BackColor = System.Drawing.Color.Transparent;
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 25;
            this.iconButton5.Location = new System.Drawing.Point(885, 8);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(48, 33);
            this.iconButton5.TabIndex = 16;
            this.iconButton5.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(-1, 7);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(55, 33);
            this.iconButton3.TabIndex = 15;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rjTextBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjTextBox1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(95, 7);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.SlateBlue;
            this.rjTextBox1.PlaceholderText = "Escribe un mensaje aquí";
            this.rjTextBox1.Size = new System.Drawing.Size(787, 31);
            this.rjTextBox1.TabIndex = 1;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.Location = new System.Drawing.Point(47, 7);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(48, 33);
            this.iconButton4.TabIndex = 14;
            this.iconButton4.UseVisualStyleBackColor = false;
            // 
            // timerAbrir
            // 
            this.timerAbrir.Interval = 10;
            this.timerAbrir.Tick += new System.EventHandler(this.timerAbrir_Tick);
            // 
            // timerCerrar
            // 
            this.timerCerrar.Interval = 10;
            this.timerCerrar.Tick += new System.EventHandler(this.timerCerrar_Tick_1);
            // 
            // FormChats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(944, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelChatTitulo);
            this.Controls.Add(this.panelChatInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormChats";
            this.Text = "FormChats";
            this.panelChatTitulo.ResumeLayout(false);
            this.panelChatTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbChat)).EndInit();
            this.panelChatInfo.ResumeLayout(false);
            this.panelChatInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbChatInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChatTitulo;
        private System.Windows.Forms.Panel panelChatInfo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton3;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnPerfilClose;
        private System.Windows.Forms.Timer timerAbrir;
        public CircularPictureBox cpbChat;
        public System.Windows.Forms.Label labelChatNombre;
        public CircularPictureBox cpbChatInfo;
        public System.Windows.Forms.Label labelChatInfoNombre;
        private System.Windows.Forms.Timer timerCerrar;
    }
}