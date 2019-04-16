using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public class ClassData
{
    public string connectionString;
    public SqlConnection con;
    public SqlCommand cmd;

    public ClassData()
    {
        try
        {
            //connectionString = @"Data Source = localhost\SQLEXPRESS; Initial catalog = Prueba; User ID = sa; Password = Alastor2611.";
            connectionString = @"Data Source = 192.168.0.90; Initial catalog = Prueba_EDI; User ID = sa; Password = Pa$$w0rd";
            con = new SqlConnection(connectionString);
        }
        catch (SqlException ex)
        {

        }


    }

    public bool IsConnect()
    {
        try
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                con.Close();
                return true;
            }
            else if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Open();
                con.Close();
                return true;
            }

            return false;
        }
        catch (SqlException ex)
        {
            return false;
        }
    }

    public DataTable LoadData()
    {
        try
        {
            using (con = new SqlConnection(connectionString))//Borra lo que tenga en memoria (elimina el objeto) pero no cierra la conexion
            {
                DataTable result = new DataTable();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM USUARIOS";

                cmd.Connection.Open();

                var Reader = cmd.ExecuteReader();



                if (Reader.HasRows)
                {
                    result.Load(Reader);
                    cmd.Connection.Close();
                    return result;
                }
                cmd.Connection.Close();

                return null;
            }
        }
        catch (SqlException ex)
        {
            return null;
        }
    }

    public DataTable ActualizaDato(string usuario, string nickname, string contrasenia, string email, int id)
    {
        using (con = new SqlConnection(connectionString))//Borra lo que tenga en memoria (elimina el objeto) pero no cierra la conexion
        {
            DataTable result = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("UPDATE USUARIOS SET USUARIO = '{0}', NICKNAME = '{1}', CONTRASEÑA = '{2}', EMAIL = '{3}' WHERE USUARIOID = {4}", usuario, nickname, contrasenia, email, id);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return null;
        }
    }

    public DataTable InsertaDato(string usuario, string nickname, string contrasenia, string email)
    {
        using (con = new SqlConnection(connectionString))//Borra lo que tenga en memoria (elimina el objeto) pero no cierra la conexion
        {
            DataTable result = new DataTable();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = string.Format("Insert Into Usuarios Values('{0}','{1}','{2}','{3}')", usuario, nickname, contrasenia, email);

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return null;
        }
    }

    public DataTable BorrarDato(string usuario, int ID)
    {

        DialogResult resultado = MessageBox.Show(string.Format("¿Está seguro que dese borrar el usuario: [{0}] y todo su contenido?",usuario),"Info",MessageBoxButtons.YesNo);
        if (resultado == DialogResult.Yes)
        {
            using (con = new SqlConnection(connectionString))//Borra lo que tenga en memoria (elimina el objeto) pero no cierra la conexion
            {
                DataTable result = new DataTable();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = string.Format("Delete Usuarios Where UsuarioID = {0}",ID);

                cmd.Connection.Open();

                cmd.ExecuteNonQuery();

                cmd.Connection.Close();

            }
        }

        else if (resultado == DialogResult.No)
        {
            MessageBox.Show("Operación Cancelada", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        return null;
    }
}
