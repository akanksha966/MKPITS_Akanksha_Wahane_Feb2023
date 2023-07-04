using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;
using System.EnterpriseServices;

namespace OnlineBookShopping.Views.Admin
{
    public partial class Authors : System.Web.UI.Page
    {

        Models.Function con;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con=new Models.Function();
            ShowAuthors();

           
        }
        private void ShowAuthors()//method
            //class name Function
        {
            string query = "select * from Author2 ";
            AuthorsLists.DataSource=con.GetData(query);
            AuthorsLists.DataBind();
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {

            try
            {
               if(aname.Value=="" || Gencb.SelectedIndex==-1||Countrycb.SelectedIndex==-1)
                {
                    Errormsg.Text = "Missing Data!!";
                }
                else
                {
                    string Aname=aname.Value;
                    string gender=Gencb.SelectedItem.ToString();
                 string country=Countrycb.SelectedItem.ToString();
                    string query = "insert into Author2 values('{0}','{1}','{2}')";
                    query=string.Format(query, Aname, gender, country);
                    con.setdata(query);
                    ShowAuthors();
                    Errormsg.Text = "Author inserted";
                    aname.Value = "";
                    Gencb.SelectedIndex = -1;
                    Countrycb.SelectedIndex = -1;

                }

            }
            catch(Exception ex)
            {
                Errormsg.Text = ex.Message;
            }
           


        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            try
            {
                if (aname.Value == "" || Gencb.SelectedIndex == -1 || Countrycb.SelectedIndex == -1)
                {
                    Errormsg.Text = "Missing Data!!";
                }
                else
                {
                    string Aname = aname.Value;
                    string gender = Gencb.SelectedItem.ToString();
                    string country = Countrycb.SelectedItem.ToString();
                    //string query = "update Author2 set Authorname('{0}',Autgender='{1}',Autcountry='{2}' where Autid='{3}')";
                    string query = "update Author2 set Authorname = '{0}', Autgender = '{1}',Autcountry ='{2}' where Autid ={3}";
                    query = string.Format(query, Aname, gender, country, AuthorsLists.SelectedRow.Cells[1].Text);
                    con.setdata(query);
                    ShowAuthors();
                    Errormsg.Text = "Author updated";
                    aname.Value = "";
                    Gencb.SelectedIndex = -1;
                    Countrycb.SelectedIndex = -1;

                }


            }
            catch (Exception ex)
            {
                Errormsg.Text = ex.Message;
            }
        }

            protected void Unnamed3_Click(object sender, EventArgs e)
                   {
            try
            {
                if (aname.Value == "" || Gencb.SelectedIndex == -1 || Countrycb.SelectedIndex == -1)
                {
                    Errormsg.Text = "select an author!!";
                }
                else
                {
                    string Aname = aname.Value;
                    string gender = Gencb.SelectedItem.ToString();
                    string country = Countrycb.SelectedItem.ToString();
                    //string query = "update Author2 set Authorname('{0}',Autgender='{1}',Autcountry='{2}' where Autid='{3}')";
                    string query = "delete from Author2 where  Autid={0}";
                    query = string.Format(query,AuthorsLists.SelectedRow.Cells[1].Text);
                    con.setdata(query);
                    ShowAuthors();
                    Errormsg.Text = "Author deleted";
                    aname.Value = "";
                    Gencb.SelectedIndex = -1;
                    Countrycb.SelectedIndex = -1;

                }


            }
            catch (Exception ex)
            {
                Errormsg.Text = ex.Message;
            }



        }
        int key = 0;

        protected void AuthorsLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            aname.Value = AuthorsLists.SelectedRow.Cells[2].Text;
            Gencb.SelectedItem.Value = AuthorsLists.SelectedRow.Cells[3].Text;
            Countrycb.SelectedItem.Value = AuthorsLists.SelectedRow.Cells[4].Text;   
            if(aname.Value=="")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(AuthorsLists.SelectedRow.Cells[1].Text);
            }

        }
    }
}