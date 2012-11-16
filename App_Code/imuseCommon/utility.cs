using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for utility
/// </summary>
public class utility
{
	public utility()
	{
		//
		// TODO: Add constructor logic here
		//
	}


    public string GetDirectoryPath()
    {
        string path = string.Empty;
        path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        return path;
    }
}