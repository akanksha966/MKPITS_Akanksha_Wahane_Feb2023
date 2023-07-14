using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebPages.Html;

namespace fillcountry_city_state.Models
{
    public class CascadingModel
    {
        public List<SelectListItem> Countries {  get; set; } 
        public List<SelectListItem> State { get; set;}
        public List<SelectListItem> City { get; set;}
        

        public int CountryId { get; set; }
        public int StateId { get; set; }
        public int CityId { get; set; }

        public CascadingModel() {

            this.Countries = new List<SelectListItem>();
            this.State = new List<SelectListItem>();
            this.City = new List<SelectListItem>();
        }
    }
}