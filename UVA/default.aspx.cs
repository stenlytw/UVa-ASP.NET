using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UVA
{
    public partial class _default : System.Web.UI.Page
    {
        DataTable table;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public DataSet getData()
        {
            DataSet ds = new DataSet();
            table = Tool.ranklist();
            ds.Tables.Add(table);

            return ds;
        }
    }
}