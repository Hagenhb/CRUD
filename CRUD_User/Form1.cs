using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_User
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Limpiar();

                DeshCamp();

                ClassData data = new ClassData();

                if (data.IsConnect())
                {
                    MessageBox.Show("Conexión Exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Conexión Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dgvUsers.DataSource = data.LoadData();
            }
            catch (Exception ex)
            {
                
            }
        }

        private void Limpiar()
        {
            textUsuario.Text = "";
            textNickname.Text = "";
            textCont.Text = "";
            textCorreo.Text = "";
        }

        private void DeshCamp()
        {
            textUsuario.Enabled = false;
            textCont.Enabled = false;
            textNickname.Enabled = false;
            textCorreo.Enabled = false;
        }
    }
}
