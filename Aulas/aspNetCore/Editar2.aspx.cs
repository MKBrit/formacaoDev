using Microsoft.AspNet.FriendlyUrls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tecnobispo
{
    public partial class Editar2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_id.Text = Request.QueryString["Id"];
            string connetionString;
            SqlConnection con;
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\.WorkSpace\formacaoDev\Aulas\aspNetCore\App_Data\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql; 
            sql = "Select * from Motas where Id=" + Request.QueryString["Id"];
            command = new SqlCommand(sql, con);
            dataReader = command.ExecuteReader();
            dataReader.Read();
            txt_matricula.Text = dataReader.GetValue(1).ToString();
            txt_proprietario.Text = dataReader.GetValue(2).ToString();
            txt_marca.Text = dataReader.GetValue(3).ToString();
            txt_modelo.Text = dataReader.GetValue(4).ToString();
            txt_cilindrada.Text = dataReader.GetValue(5).ToString();
        }

        protected void btn_alterar_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection con;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\.WorkSpace\formacaoDev\Aulas\aspNetCore\App_Data\Database1.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);    
            con.Open();
            // Response.Write("Ligado com sucesso!");
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso
            SqlCommand command; 
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            String sql = "";
            sql = "UPDATE Motas SET matricula = '" + txt_matricula.Text + "', proprietario = '" + txt_proprietario.Text + "', marca = '" + txt_marca.Text + "', modelo = '" + txt_modelo.Text + "', cilindrada = " + txt_cilindrada.Text + " WHERE Id = " + txt_matricula.Text;
            // Response.Write(sql);
            // a linha acima serve para verem o que esta a ser executado no vosso sql
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Dados alterados com sucesso');window.location='Index.aspx';", true);}

        protected void btn_cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("editar.aspx");
        }
    }
    }