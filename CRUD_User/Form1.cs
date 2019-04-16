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
        bool b1 = true, b2 = true, b3 = true, b4 = false, b5 = false, b = false;
        bool esagregar = false;
        int id = 0, primogeneo = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Limpiar();

                DesHabBtn(b1,b2,b3,b4,b5);

                DesHabCampo(b);

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

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            b1 = b2 = b3 = false;
            b4 = b5 = b = true;

            DesHabCampo(b);
            DesHabBtn(b1,b2,b3,b4,b5);
            esagregar = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            b1 = b2 = b3 = false;
            b4 = b5 = b = true;

            DesHabCampo(b);
            DesHabBtn(b1, b2, b3, b4, b5);

            textUsuario.Text = dgvUsers.Rows[id].Cells[1].Value.ToString();
            textNickname.Text = dgvUsers.Rows[id].Cells[2].Value.ToString();
            textCont.Text = dgvUsers.Rows[id].Cells[3].Value.ToString();
            textCorreo.Text = dgvUsers.Rows[id].Cells[4].Value.ToString();

            esagregar = false;
        }


        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            var index = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
            id = int.Parse(index);

            MessageBox.Show(index, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            ClassData data = new ClassData();

            if(esagregar == true)
            {
                data.AgregarUsuario(textUsuario.Text, textNickname.Text, textCont.Text, textCorreo.Text);
            }
            else if(esagregar == false)
            {
                data.ActualizarUsuario(textUsuario.Text, textNickname.Text, textCont.Text, textCorreo.Text, id);
            }

            dgvUsers.DataSource = data.LoadData();
            this.Refresh();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            b1 = b2 = b3 = true;
            b4 = b5 = false;
            b = false;

            DesHabCampo(b);

            DesHabBtn(b1, b2, b3, b4, b5);
            Limpiar();
        }




        private void Limpiar()
        {
            textUsuario.Text = "";
            textNickname.Text = "";
            textCont.Text = "";
            textCorreo.Text = "";
        }


        private void DesHabBtn(bool b1, bool b2, bool b3, bool b4, bool b5)
        {
            btnActualizar.Enabled = b1;
            BtnAgregar.Enabled = b2;
            btnBorrar.Enabled = b3;
            btnCancelar.Enabled = b4;
            btnGuardar.Enabled = b5;
        }

        private void DesHabCampo(bool b)
        {
            textUsuario.Enabled = b;
            textNickname.Enabled = b;
            textCont.Enabled = b;
            textCorreo.Enabled = b;
        }
        
    }
}
