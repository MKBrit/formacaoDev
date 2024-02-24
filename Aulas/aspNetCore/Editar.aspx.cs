using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace seilaquantasando
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\zzzAulaJAVA6out\seilaquantasando\App_Data\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";
            sql = "SELECT Id, matricula, proprietario, marca, modelo, cilindrada FROM Motas";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            Response.Write("<h1>Editar Utilizadores</h1><br/>");
            Response.Write("<table border='1'>");
            Response.Write("<tr>");
            Response.Write("<th>Id</th>");
            Response.Write("<th>Matricula</th>");
            Response.Write("<th>Proprietario</th>");
            Response.Write("<th>Marca</th>");
            Response.Write("<th>Modelo</th>");
            Response.Write("<th>Cilindrada</th>");
            Response.Write("<th>Ação</th>");
            Response.Write("</tr>");

            while (dataReader.Read())
            {
                Response.Write("<tr>");
                Response.Write("<td>" + dataReader.GetValue(0) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(1) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(2) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(3) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(4) + "</td>");
                Response.Write("<td>" + dataReader.GetValue(5) + "</td>");
                Response.Write("<td><input type='button' Value='Editar' onclick=window.open('Editar2.aspx?id=" + dataReader.GetValue(0) + "') />&nbsp<input type='button' Value='Eliminar' onclick=window.open('Eliminar.aspx?id=" + dataReader.GetValue(0) + "') /></td>");
                Response.Write("</tr>");
            }

            Response.Write("</table>");

            dataReader.Close();
            con.Close();
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}