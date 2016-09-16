using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessionalpapers
{
    public partial class cahing1 : System.Web.UI.Page
    {
        GridView gv;
        protected void Page_Load(object sender, EventArgs e)
        {
            //String id1, name1, branch1, sem1;
            String connstring = "Data Source=CELAB5;Initial Catalog=student;Integrated Security=SSPI";
            SqlConnection conn = new SqlConnection(connstring);
            conn.Open();
           String select = "select * from std_info";
            SqlCommand command = new SqlCommand(select,conn);
            

            gv.DataSource = command.ExecuteReader();
            gv.DataBind();

            Cache.Insert("data", gv);
            GridView1.DataSource=(GridView) Cache["data"];
            GridView1.DataBind();

          
            
        }
    }
}