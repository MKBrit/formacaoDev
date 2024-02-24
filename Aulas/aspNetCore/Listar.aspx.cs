using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace seilaquantasando
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;

            // Connection string
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\zzzAulaJAVA6out\seilaquantasando\App_Data\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);

            // Open the connection
            con.Open();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = " ";

            // SQL query
            sql = "SELECT Id, matricula, proprietario, marca, modelo, cilindrada FROM Motas";
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();

            // Build HTML table
            Output = "<table border='1'><tr><th>ID</th><th>Matricula</th><th>Proprietario</th><th>Marca</th><th>Modelo</th><th>Cilindrada</th></tr>";
            while (dataReader.Read())
            {
                Output += "<tr><td>" + dataReader.GetValue(0) + "</td><td>" + dataReader.GetValue(1) + "</td><td>" + dataReader.GetValue(2) + "</td><td>" + dataReader.GetValue(3) + "</td><td>" + dataReader.GetValue(4) + "</td><td>" + dataReader.GetValue(5) + "</td></tr>";
            }
            Output += "</table>";

            // Display the HTML table
            Response.Write(Output);

            // Close the data reader and connection
            dataReader.Close();
            con.Close();
        }

        protected void btn_voltar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}