using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class _Default : Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["KalkulatorConnectionString"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
       
        con.Open();
        
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button4_Click(object sender, EventArgs e)
    {

        double sum;
        double a = Convert.ToDouble(TextBoxA.Text);
        double b = Convert.ToDouble(TextBoxB.Text);
        sum = a / b;
        TextBoxResult.Text = sum.ToString();
        string action = a + " / " + b + "=" + sum;

        String time = DateTime.Now.ToString();
        SqlCommand cmd = new SqlCommand("insert into Events values('" + time + "','" + action + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.DataBind();
        TextBoxA.Text = "";
        TextBoxB.Text = "";
        TextBoxResult.Text = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int sum;
        int a = Convert.ToInt32(TextBoxA.Text);
        int b = Convert.ToInt32(TextBoxB.Text);
        sum = a + b;
        TextBoxResult.Text = sum.ToString();


        string action = a + " + " + b + "=" + sum;

        String time = DateTime.Now.ToString();
        SqlCommand cmd = new SqlCommand("insert into Events values('" + time + "','" + action + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.DataBind();
        TextBoxA.Text = "";
        TextBoxB.Text = "";
        TextBoxResult.Text = "";

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int sum;
        int a = Convert.ToInt32(TextBoxA.Text);
        int b = Convert.ToInt32(TextBoxB.Text);
        sum = a * b;
        TextBoxResult.Text = sum.ToString();
        string action = a + " * " + b + "=" + sum;

        String time = DateTime.Now.ToString();
        SqlCommand cmd = new SqlCommand("insert into Events values('" + time + "','" + action + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.DataBind();
        TextBoxA.Text = "";
        TextBoxB.Text = "";
        TextBoxResult.Text = "";
    }

    protected void TextBox1_TextChanged1(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int sum;
        int a = Convert.ToInt32(TextBoxA.Text);
        int b = Convert.ToInt32(TextBoxB.Text);
        sum = a - b;
        TextBoxResult.Text = sum.ToString();
        string action = a + " - " + b + "=" + sum;
        
        String time = DateTime.Now.ToString();
        SqlCommand cmd = new SqlCommand("insert into Events values('" + time + "','" + action + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
        GridView1.DataBind();
        TextBoxA.Text = "";
        TextBoxB.Text = "";
        TextBoxResult.Text = "";
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}