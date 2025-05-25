using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;


namespace Math_School
{
    class Class1
    {
        public static string conReturn()
        {
            //return("Data Source=Joash;Initial Catalog=MathSchool;Integrated Security=True");
            //return (@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename = " + System.IO.Path.GetFullPath("Finaldb.mdf") + "; Integrated Security = True; Connect Timeout = 30");
            //return (@"Data Source="+Properties.Settings.Default.strDataSource+";Network Library=DBMSSOCN; Initial Catalog=MathSchool; User ID=eguessusers;Password=joash; Integrated Security = false; MultipleActiveResultSets=True");
            return (Properties.Settings.Default.strDataSource);
        }

        public static string conFile()
        {
            return (System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location));
        }
    }
}
