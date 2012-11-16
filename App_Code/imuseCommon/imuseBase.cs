using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for imuseBase
/// </summary>
namespace imuse.Common
{
    public class imuseBase
    {
        public static bool isvalidinvitation;    

        public bool IsValidInvitation
        {
            get { return isvalidinvitation; }
            set { isvalidinvitation = value; }
        }


        public imuseBase()
        {
            //
            // TODO: Add constructor logic here
            //
        }
        
        public static string imagePath;
        public static string ImagePath
        {
            get
            { return imagePath; }
            set
            { imagePath = value; }

        }

        public static string GetServerDirectoryPath()
        {
            imagePath =  System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            return imagePath;
        }


    }
}