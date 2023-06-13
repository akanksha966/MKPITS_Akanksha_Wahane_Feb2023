using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace insert_update_delete_using_asp.net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection s = new SqlConnection("server=.\\sqlexpress;integrated security=true;database=Fendahl");
        DataSet ds = new DataSet();
        SqlDataAdapter dr=new SqlDataAdapter();
        string query = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            query = "  select * from TableProduct";
            dr=new SqlDataAdapter(query,s);
            dr.Fill(ds,"TableProduct");
            GridView1.DataSource = ds.Tables["TableProduct"].DefaultView;
            GridView1.DataBind();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            query = "insert into TableProduct values(@ProductID,@Product_Name,@Product_Category_ID,@ProductPrice)";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@ProductID", Convert.ToInt32(TextBox1.Text));
            cmd.Parameters.AddWithValue("@Product_Name", (TextBox2.Text));
            cmd.Parameters.AddWithValue("@Product_Category_ID", Convert.ToInt32(TextBox3.Text));
            cmd.Parameters.AddWithValue("@ProductPrice", Convert.ToInt32(TextBox4.Text));
            s.Open();
           cmd.ExecuteNonQuery();   
            s.Close();
            Label1.Text = "inserted successfully";
            loaddata();
           // clearall();



        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            query = "update TableProduct set Product_Name=@productname,Product_Category_ID=@productcategoryid,ProductPrice=@price where ProductID=@productid";
            SqlCommand cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@productname", (TextBox2.Text));
            cmd.Parameters.AddWithValue("@productcategoryid", Convert.ToInt32(TextBox3.Text));
            cmd.Parameters.AddWithValue("@price", Convert.ToInt32(TextBox4.Text));
            cmd.Parameters.AddWithValue("@productid", Convert.ToInt32(TextBox1.Text));

            s.Open();
            cmd.ExecuteNonQuery();
            s.Close();
            Label1.Text = "updeted successfuuly";
            loaddata();
            clearall();



        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            query = "delete from tableProduct where ProductID=@productid";
            SqlCommand cmd=new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@productid", Convert.ToInt32(TextBox1.Text));
            s.Open();
            cmd.ExecuteNonQuery();  
            s.Close();
            Label1.Text = "deleted successfully";
            loaddata();
            clearall();


        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            query = "  select * from TableProduct where ProductID=@productid";
            dr = new SqlDataAdapter(query, s);
            dr.SelectCommand.Parameters.AddWithValue("@productid",Convert.ToInt32(TextBox1.Text));
            dr.Fill(ds, "TableProduct");
            TextBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            //TextBox3.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            //TextBox4.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();


            GridView1.DataSource = ds.Tables["TableProduct"].DefaultView;
            GridView1.DataBind();
            Label1.Text = "saved successfully";
        }
        public void clearall()
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }
    }
}