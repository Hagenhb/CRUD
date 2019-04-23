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
        int Id = 0;
        bool isupdate = false;
        string usuario;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                HabDeshCamp(false);
                toolGuardar.Enabled = false;
                toolCancelar.Enabled = false;

                //ClassData data = new ClassData();

                /*if (data.IsConnect())
                {
                    MessageBox.Show("Conexión Exitosa", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Conexión Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/

                dgvUsers.DataSource = new LinQData().GetUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Conexión Fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolAgregar_Click(object sender, EventArgs e)
        {
            HabDeshCamp(true);
            toolAgregar.Enabled = false;
            toolActualizar.Enabled = false;
            toolBorrar.Enabled = false;
            toolGuardar.Enabled = true;
            toolCancelar.Enabled = true;

            isupdate = false;
            
        }

        private void Limpiar()
        {
            textUsuario.Text = "";
            textNickname.Text = "";
            textCont.Text = "";
            textCorreo.Text = "";
        }

        private void HabDeshCamp(bool b)
        {
            textUsuario.Enabled = b;
            textCont.Enabled = b;
            textNickname.Enabled = b;
            textCorreo.Enabled = b;
        }

        private void toolActualizar_Click(object sender, EventArgs e)
        {
            HabDeshCamp(true);
            toolAgregar.Enabled = false;
            toolActualizar.Enabled = false;
            toolBorrar.Enabled = false;
            toolGuardar.Enabled = true;
            toolCancelar.Enabled = true;

            isupdate = true;
        }

        private void toolBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(string.Format("¿Está seguro que dese borrar el usuario: [{0}] y todo su contenido?", usuario), "Info", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                var res = new LinQData().BorrarLinQ(Id);

                if (res)
                {
                    MessageBox.Show("Se borró la información correctamente", "Usuario Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se borró la información correctamente", "Usuario No Borrado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (resultado == DialogResult.No)
            {
                MessageBox.Show("Operación Cancelada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            //ClassData data = new ClassData();

            //data.BorrarDato(usuario, Id);

            Limpiar();
            HabDeshCamp(false);
            toolAgregar.Enabled = true;
            toolActualizar.Enabled = true;
            toolBorrar.Enabled = true;
            toolGuardar.Enabled = false;
            toolCancelar.Enabled = false;
            isupdate = false;

            dgvUsers.DataSource = new LinQData().GetUsuarios();

            this.Refresh();
        }

        private void toolCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            HabDeshCamp(false);
            toolAgregar.Enabled = true;
            toolActualizar.Enabled = true;
            toolBorrar.Enabled = true;
            toolGuardar.Enabled = false;
            toolCancelar.Enabled = false;
            isupdate = false;
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                var userId = dgvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();    //obtención de ID
                //MessageBox.Show("User Id: " + userId, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Id = int.Parse(userId);
                usuario = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textUsuario.Text = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            textNickname.Text = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            textCont.Text = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
            textCorreo.Text = dgvUsers.Rows[e.RowIndex].Cells[4].Value.ToString();

            HabDeshCamp(true);
            toolAgregar.Enabled = false;
            toolActualizar.Enabled = false;
            toolBorrar.Enabled = false;
            toolGuardar.Enabled = true;
            toolCancelar.Enabled = true;

            isupdate = true;
        }

        private void toolGuardar_Click(object sender, EventArgs e)
        {
            ClassData data = new ClassData();

            if (isupdate == true)
            {
                //data.ActualizaDato(textUsuario.Text, textNickname.Text, textCont.Text, textCorreo.Text, Id);
                var resultado = new LinQData().ModificarLinQ(textUsuario.Text, textNickname.Text, textCont.Text, textCorreo.Text, Id);

                if(resultado)
                {
                    MessageBox.Show("Se actualizó la información correctamente", "Usuario Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se actualizó la información correctamente", "Usuario No Modificado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //data.InsertaDato(textUsuario.Text, textNickname.Text, textCont.Text, textCorreo.Text);
                //LinQData dataconlinq = new LinQData();

                //var resultado = dataconlinq.InsertarLinQ(textUsuario.Text, textNickname.Text, textCont.Text, textCorreo.Text);
                var resultado = new LinQData().InsertarLinQ(textUsuario.Text, textNickname.Text, textCont.Text, textCorreo.Text);

                if (resultado)
                {
                    MessageBox.Show("Se guardo la información correctamente","Usuario Agregado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se guardo la información correctamente", "Usuario No Agregado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvUsers.DataSource = new LinQData().GetUsuarios(); //data.LoadData();

            Limpiar();
            HabDeshCamp(false);
            toolAgregar.Enabled = true;
            toolActualizar.Enabled = true;
            toolBorrar.Enabled = true;
            toolGuardar.Enabled = false;
            toolCancelar.Enabled = false;
            isupdate = false;

            this.Refresh();
        }
    }
}
