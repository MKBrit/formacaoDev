using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tecnobispo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void btn_inserir_Click(object sender, EventArgs e)
        {
            Response.Redirect("inserir.aspx");
        }

        protected void btn_listar_Click(object sender, EventArgs e)
        {
            Response.Redirect("listar.aspx");
        }

        protected void btn_editar_Click(object sender, EventArgs e)
        {
            Response.Redirect("editar.aspx");
        }
    }
}