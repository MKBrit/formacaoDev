using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace seilaquantasando
{
    public partial class Inserir : System.Web.UI.Page
    {
        protected void btn1_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\zzzAulaJAVA6out\seilaquantasando\App_Data\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            // Response.Write("Ligado com sucesso!");
            //con.Close();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "INSERT INTO Motas (matricula, proprietario, marca, modelo, cilindrada) VALUES('" + txt_matricula.Text + "', '" + txt_proprietario.Text + "', '" + txt_marca.Text + "', '" + txt_modelo.Text + "', '" + txt_cilindrada.Text + "')";
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados",
            "alert('Dados inseridos com sucesso');window.location = 'Lista_simples.aspx';", true);
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}