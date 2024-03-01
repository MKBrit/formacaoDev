using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projeto4
{
    public partial class Edita2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt_nome.Text = Request.QueryString["id"]; 
            string connetionString; 
            SqlConnection con;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\zzzAulaJAVA6out\projeto4\App_Data\bd_projeto4.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);             
            con.Open();             
            // Response.Write("Ligado com sucesso!");             
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso
            SqlCommand command;             
            SqlDataReader dataReader;             
            String sql;             
            sql = "Select * from livro where id="+ Request.QueryString["id"];             
            command = new SqlCommand(sql, con);             
            dataReader = command.ExecuteReader();             
            dataReader.Read();             
            txt_nome.Text = dataReader.GetValue(1).ToString();             
            txt_npag.Text= dataReader.GetValue(2).ToString();             
            txt_tam.Text= dataReader.GetValue(3).ToString();
        }

        protected void btn_alterar_Click(object sender, EventArgs e)
        {
            string connetionString; 
            SqlConnection con;
            // veja a imagem abaixo para saber onde vai buscar o caminho da conexão
            connetionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\zzzAulaJAVA6out\projeto4\App_Data\bd_projeto4.mdf;Integrated Security=True";
            con = new SqlConnection(connetionString);             
            con.Open();             
            // Response.Write("Ligado com sucesso!");             
            // a linha acima utilizo apenas para ver se a conexão é feita com sucesso
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";
            sql = "update livros set nome='" + txt_nome.Text + "', n_paginas=" + txt_npag.Text + ", tamanho='" + txt_tam.Text + "' where id=" + txt_id.Text;             
            Response.Write(sql);            
            // a linha acima serve para verem o que esta a ser executado no vosso sql
            command = new SqlCommand(sql, con);
            adapter.InsertCommand = new SqlCommand(sql, con);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "Dados", "alert('Dados alterados com sucesso');window.location='Index.aspx';", true); 
        }
    }
}

