using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projeto4
{
    public partial class Lista_simples : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connetionString; 
            SqlConnection con;
            int numero = 0;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\zzzAulaJAVA6out\projeto4\App_Data\bd_projeto4.mdf;Integrated Security=True";              
            con = new SqlConnection(connetionString);             
            con.Open();              
            //Response.Write("Ligado com sucesso!");             
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso
            SqlCommand command;             
            SqlDataReader dataReader;             
            String sql, Output = " ";
            sql = "Select * from livro";              
            command = new SqlCommand(sql, con);             
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            { 
                Output = Output + dataReader.GetValue(0) + "-" + dataReader.GetValue(1) + "</br>"; 
                numero = numero + 1; 
            }
            Response.Write(Output); 
            dataReader.Close(); 
            con.Close();
        }
    }   
}