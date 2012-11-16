using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
/// <summary>
/// Summary description for Connection
/// </summary>
public class Connection
{
	public Connection()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public  SqlConnection SqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["CMSConnectionString"].ConnectionString);
    
}