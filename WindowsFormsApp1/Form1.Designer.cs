
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChats = new System.Windows.Forms.Panel();
            this.panelBusqueda = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelPerfilEmail = new System.Windows.Forms.Label();
            this.labelPerfilNombre = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelPerfil = new System.Windows.Forms.Label();
            this.formHijo = new System.Windows.Forms.Panel();
            this.timerAbrir = new System.Windows.Forms.Timer(this.components);
            this.timerCerrar = new System.Windows.Forms.Timer(this.components);
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.btnPerfilEditar = new FontAwesome.Sharp.IconButton();
            this.btnPerfilClose = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.cpbYo = new WindowsFormsApp1.CircularPictureBox();
            this.cpbPerfil = new WindowsFormsApp1.CircularPictureBox();
            this.panelSuperior.SuspendLayout();
            this.panelChats.SuspendLayout();
            this.panelBusqueda.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbYo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSuperior.Controls.Add(this.iconButton3);
            this.panelSuperior.Controls.Add(this.iconButton4);
            this.panelSuperior.Controls.Add(this.label1);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(1264, 30);
            this.panelSuperior.TabIndex = 0;
            this.panelSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSuperior_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "WhatsApp Facherito";
            // 
            // panelChats
            // 
            this.panelChats.AutoScroll = true;
            this.panelChats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelChats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChats.Controls.Add(this.panelBusqueda);
            this.panelChats.Controls.Add(this.panelInfo);
            this.panelChats.Controls.Add(this.panelPerfil);
            this.panelChats.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelChats.Location = new System.Drawing.Point(0, 30);
            this.panelChats.Name = "panelChats";
            this.panelChats.Size = new System.Drawing.Size(320, 596);
            this.panelChats.TabIndex = 1;
            // 
            // panelBusqueda
            // 
            this.panelBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(15)))), ((int)(((byte)(62)))));
            this.panelBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBusqueda.Controls.Add(this.rjTextBox1);
            this.panelBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusqueda.Location = new System.Drawing.Point(0, 75);
            this.panelBusqueda.Name = "panelBusqueda";
            this.panelBusqueda.Size = new System.Drawing.Size(318, 51);
            this.panelBusqueda.TabIndex = 2;
            // 
            // panelInfo
            // 
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo.Controls.Add(this.iconButton1);
            this.panelInfo.Controls.Add(this.iconButton2);
            this.panelInfo.Controls.Add(this.cpbYo);
            this.panelInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInfo.Location = new System.Drawing.Point(0, 0);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(318, 75);
            this.panelInfo.TabIndex = 1;
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.panelPerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerfil.Controls.Add(this.labelVersion);
            this.panelPerfil.Controls.Add(this.labelPerfilEmail);
            this.panelPerfil.Controls.Add(this.btnPerfilEditar);
            this.panelPerfil.Controls.Add(this.labelPerfilNombre);
            this.panelPerfil.Controls.Add(this.panel4);
            this.panelPerfil.Controls.Add(this.cpbPerfil);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(0, 594);
            this.panelPerfil.TabIndex = 0;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(8, 564);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(30, 16);
            this.labelVersion.TabIndex = 16;
            this.labelVersion.Text = "V0.1";
            // 
            // labelPerfilEmail
            // 
            this.labelPerfilEmail.AutoSize = true;
            this.labelPerfilEmail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfilEmail.ForeColor = System.Drawing.Color.White;
            this.labelPerfilEmail.Location = new System.Drawing.Point(105, 320);
            this.labelPerfilEmail.Name = "labelPerfilEmail";
            this.labelPerfilEmail.Size = new System.Drawing.Size(51, 21);
            this.labelPerfilEmail.TabIndex = 15;
            this.labelPerfilEmail.Text = "Email";
            // 
            // labelPerfilNombre
            // 
            this.labelPerfilNombre.AutoSize = true;
            this.labelPerfilNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfilNombre.ForeColor = System.Drawing.Color.White;
            this.labelPerfilNombre.Location = new System.Drawing.Point(105, 279);
            this.labelPerfilNombre.Name = "labelPerfilNombre";
            this.labelPerfilNombre.Size = new System.Drawing.Size(73, 21);
            this.labelPerfilNombre.TabIndex = 14;
            this.labelPerfilNombre.Text = "Nombre";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnPerfilClose);
            this.panel4.Controls.Add(this.labelPerfil);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(0, 75);
            this.panel4.TabIndex = 1;
            // 
            // labelPerfil
            // 
            this.labelPerfil.AutoSize = true;
            this.labelPerfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPerfil.ForeColor = System.Drawing.Color.White;
            this.labelPerfil.Location = new System.Drawing.Point(52, 27);
            this.labelPerfil.Name = "labelPerfil";
            this.labelPerfil.Size = new System.Drawing.Size(67, 21);
            this.labelPerfil.TabIndex = 3;
            this.labelPerfil.Text = "Mi Perfil";
            // 
            // formHijo
            // 
            this.formHijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(49)))));
            this.formHijo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formHijo.Location = new System.Drawing.Point(320, 30);
            this.formHijo.Name = "formHijo";
            this.formHijo.Size = new System.Drawing.Size(944, 596);
            this.formHijo.TabIndex = 2;
            // 
            // timerAbrir
            // 
            this.timerAbrir.Interval = 10;
            this.timerAbrir.Tick += new System.EventHandler(this.timerAbrir_Tick);
            // 
            // timerCerrar
            // 
            this.timerCerrar.Interval = 10;
            this.timerCerrar.Tick += new System.EventHandler(this.timerCerrar_Tick);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CommentAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(215, 19);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(42, 33);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
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
            this.iconButton2.Location = new System.Drawing.Point(263, 19);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(35, 33);
            this.iconButton2.TabIndex = 10;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // btnPerfilEditar
            // 
            this.btnPerfilEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfilEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfilEditar.FlatAppearance.BorderSize = 0;
            this.btnPerfilEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPerfilEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnPerfilEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfilEditar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPerfilEditar.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnPerfilEditar.IconColor = System.Drawing.Color.White;
            this.btnPerfilEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPerfilEditar.IconSize = 25;
            this.btnPerfilEditar.Location = new System.Drawing.Point(57, 275);
            this.btnPerfilEditar.Name = "btnPerfilEditar";
            this.btnPerfilEditar.Size = new System.Drawing.Size(35, 33);
            this.btnPerfilEditar.TabIndex = 14;
            this.btnPerfilEditar.UseVisualStyleBackColor = false;
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
            this.btnPerfilClose.Location = new System.Drawing.Point(11, 23);
            this.btnPerfilClose.Name = "btnPerfilClose";
            this.btnPerfilClose.Size = new System.Drawing.Size(35, 33);
            this.btnPerfilClose.TabIndex = 13;
            this.btnPerfilClose.UseVisualStyleBackColor = false;
            this.btnPerfilClose.Click += new System.EventHandler(this.btnPerfilClose_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.Transparent;
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(1180, -2);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(42, 33);
            this.iconButton3.TabIndex = 13;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.Transparent;
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateBlue;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 25;
            this.iconButton4.Location = new System.Drawing.Point(1226, -2);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(35, 33);
            this.iconButton4.TabIndex = 12;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.rjTextBox1.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 1;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjTextBox1.Location = new System.Drawing.Point(26, 9);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.SlateBlue;
            this.rjTextBox1.PlaceholderText = "Buscar...";
            this.rjTextBox1.Size = new System.Drawing.Size(250, 31);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // cpbYo
            // 
            this.cpbYo.BackColor = System.Drawing.Color.White;
            this.cpbYo.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cpbYo.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cpbYo.BorderColor2 = System.Drawing.Color.HotPink;
            this.cpbYo.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cpbYo.BorderSize = 2;
            this.cpbYo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cpbYo.GradientAngle = 50F;
            this.cpbYo.Image = ((System.Drawing.Image)(resources.GetObject("cpbYo.Image")));
            this.cpbYo.Location = new System.Drawing.Point(5, 6);
            this.cpbYo.Name = "cpbYo";
            this.cpbYo.Size = new System.Drawing.Size(62, 62);
            this.cpbYo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbYo.TabIndex = 8;
            this.cpbYo.TabStop = false;
            this.cpbYo.Click += new System.EventHandler(this.cpbYo_Click);
            // 
            // cpbPerfil
            // 
            this.cpbPerfil.BackColor = System.Drawing.Color.White;
            this.cpbPerfil.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cpbPerfil.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cpbPerfil.BorderColor2 = System.Drawing.Color.HotPink;
            this.cpbPerfil.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cpbPerfil.BorderSize = 2;
            this.cpbPerfil.GradientAngle = 50F;
            this.cpbPerfil.Location = new System.Drawing.Point(57, 89);
            this.cpbPerfil.Name = "cpbPerfil";
            this.cpbPerfil.Size = new System.Drawing.Size(166, 166);
            this.cpbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cpbPerfil.TabIndex = 0;
            this.cpbPerfil.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 626);
            this.ControlBox = false;
            this.Controls.Add(this.formHijo);
            this.Controls.Add(this.panelChats);
            this.Controls.Add(this.panelSuperior);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            this.panelChats.ResumeLayout(false);
            this.panelBusqueda.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cpbYo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpbPerfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panelChats;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Panel formHijo;
        private System.Windows.Forms.Panel panelBusqueda;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label1;
        private CircularPictureBox cpbYo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelPerfilEmail;
        private FontAwesome.Sharp.IconButton btnPerfilEditar;
        private System.Windows.Forms.Label labelPerfilNombre;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnPerfilClose;
        private System.Windows.Forms.Label labelPerfil;
        private CircularPictureBox cpbPerfil;
        private System.Windows.Forms.Timer timerAbrir;
        private System.Windows.Forms.Timer timerCerrar;
    }
}

