using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace PMNS
{
    class Connection
    {
        static public string ketnoi = "Data Source=BUM;Initial Catalog=WebNhanSu;Integrated Security=True";
        static public SqlConnection cnn = new SqlConnection(ketnoi);
        static public void moketnoi()
        {
            if (cnn.State != ConnectionState.Open)
                cnn.Open();
        }
        static public void dongketnoi()
        {
            cnn.Close();
        }
        static public void Dispose()
        {
            cnn.Dispose();
        }
    }
}
