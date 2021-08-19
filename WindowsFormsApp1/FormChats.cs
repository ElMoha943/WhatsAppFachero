using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormChats : Form
    {
        public FormChats()
        {
            InitializeComponent();
        }

        private void timerAbrir_Tick(object sender, EventArgs e)
        {
            if (panelChatInfo.Width < 320)
            {
                panelChatInfo.Width += 20;
            }
            else
            {
                timerAbrir.Stop();
            }
        }

        private void btnPerfilClose_Click(object sender, EventArgs e)
        {
            timerCerrar.Start();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            cpbChatInfo.Image = cpbChat.Image;
            labelChatInfoNombre.Text = labelChatNombre.Text;
            timerAbrir.Start();
        }

        private void timerCerrar_Tick_1(object sender, EventArgs e)
        {
            if (panelChatInfo.Width > 0)
            {
                panelChatInfo.Width -= 20;
            }
            else
            {
                timerCerrar.Stop();
            }
        }
    }
}
