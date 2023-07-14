using fillcountry_city_state.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Configuration;
using System.Data.SqlClient;

namespace fillcountry_city_state.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           CascadingModel model = new CascadingModel();
            //this will call constructor
            model.Countries = PopulateDropDown("SELECT Id, CountryName FROM  country", "CountryName", "Id");
            return View(model);
        }
        private static List<SelectListItem> PopulateDropDown(string query, string textcolumn, string valuecolumn)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr[textcolumn].ToString(),
                                Value = sdr[valuecolumn].ToString()

                            });
                        }
                    }
                    con.Close();
                }
            }

            return items;
        }


        }


    }

