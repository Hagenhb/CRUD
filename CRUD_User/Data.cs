using System;
using System.Data;
using System.Data.SqlClient;

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
            connectionString = @"Data Source = LAPTOP-D3L177HO; Initial catalog = Pruebas; User ID = sa; Password = 123";
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
}
