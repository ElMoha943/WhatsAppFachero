using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Form chatActual;
        public Form1()
        {
            InitializeComponent();
            //Valores Default

            crearChat(WindowsFormsApp1.Properties.Resources.pp__1_, "Pekke");
            crearChat(WindowsFormsApp1.Properties.Resources.pp__2_, "Seba");
            crearChat(WindowsFormsApp1.Properties.Resources.pp, "Grupo");
        }

        private void crearChat(Image imagen, string nombre)
        {
            //Panel
            Panel panel = new Panel();
            panel.Dock = DockStyle.Top;
            panel.Height = 75;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panelChats.Controls.Add(panel);
            panel.BringToFront();

            //Imagen
            CircularPictureBox cpb = new CircularPictureBox();
            cpb.Width = 68;
            cpb.Image = imagen;
            panel.Controls.Add(cpb);
            cpb.Location = new Point(6, 2);

            //Label Titulo
            Label titulo = new Label();
            titulo.Font = new Font("Century Gothic", 12, FontStyle.Regular);
            titulo.Size = new Size(160, 17);
            titulo.Text = nombre;
            titulo.ForeColor = Color.White;
            panel.Controls.Add(titulo);
            titulo.Location = new Point(91, 18);

            //Label Mensaje
            Label mensaje = new Label();
            mensaje.Font = new Font("Century Gothic", 10, FontStyle.Regular);
            mensaje.Size = new Size(160, 17);
            mensaje.Text = "Placeholder"; //Cambiar
            mensaje.ForeColor = Color.Gray;
            panel.Controls.Add(mensaje);
            mensaje.Location = new Point(91, 39);

            //Eventos
            panel.Click += panel_Click;
            panel.MouseEnter += panel_MouseEnter;
            panel.MouseLeave += panel_MouseLeave;
        }

        private void panel_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(16, 15, 52);
        }

        private void panel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BackColor = Color.FromArgb(26, 25, 62);
        }

        private void panel_Click(object sender, EventArgs e)
        {
            Image imagen = null;
            string titulo = "";
            foreach (var control in ((Panel)sender).Controls)
            {
                if (control is CircularPictureBox) imagen = ((CircularPictureBox)control).Image;
                if (control is Label)
                {
                    if (((Label)control).ForeColor == Color.White) titulo = ((Label)control).Text;
                }
            }
            abrirChat(new FormChats(), imagen, titulo);
        }

        private void abrirChat(FormChats chat, Image imagen, string titulo)
        {
            if (chatActual != null)
            {
                chatActual.Close();
            }
            chat.cpbChat.Image = imagen;
            chat.labelChatNombre.Text = titulo;
            chatActual = chat;
            chat.TopLevel = false;
            formHijo.Controls.Add(chat);
            formHijo.Tag = chat;
            chat.BringToFront();
            chat.Show();
        }

        private void timerAbrir_Tick(object sender, EventArgs e)
        {
            if(panelPerfil.Width < 320)
            {
                panelPerfil.Width += 20;
            }
            else
            {
                timerAbrir.Stop();
            }
        }

        private void timerCerrar_Tick(object sender, EventArgs e)
        {
            if (panelPerfil.Width > 0)
            {
                panelPerfil.Width -= 20;
            }
            else
            {
                timerCerrar.Stop();
            }
        }

        private void cpbYo_Click(object sender, EventArgs e)
        {
            timerAbrir.Start();
            cpbPerfil.Image = cpbYo.Image;
        }

        private void btnPerfilClose_Click(object sender, EventArgs e)
        {
            timerCerrar.Start();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Image imagen = WindowsFormsApp1.Properties.Resources.pp__1_;
            string titulo = "Placeholder";
            crearChat(imagen,titulo);
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
