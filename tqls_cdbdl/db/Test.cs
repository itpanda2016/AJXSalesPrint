using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tqls_cdbdl.db
{
    public class Test
    {
        public DataSet test()
        {
            DbHelper db = new DbHelper();
            DbCommand cmd = db.GetSqlStringCommond("select * from [tu_khzc] where xm like '%黄倩%'");

            DataSet ds = db.ExecuteDataSet(cmd);
            return ds;
        }

    }
}
