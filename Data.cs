using System;
using System.Data;
using System.Data.SqlClient;

public class ClassData
{
    public string connectionString;
    public SQLConnection con;
    public SQLCommand cmd;

	public ClassData()
	{
        connectionString = "Data Source = localhost; Initial catalog = Prueba; UserID = sa; Password = Alastor2611.";
        con = new SQLConnection();


	}

    public bool IsConnect()
    {
        try
        {
            if(con.)
        }
        catch(SQLException ex)
        {
            return false;
        }
    }
}
