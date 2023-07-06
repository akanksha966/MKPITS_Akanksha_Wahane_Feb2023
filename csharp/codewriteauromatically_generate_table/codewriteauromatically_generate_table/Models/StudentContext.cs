using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace codewriteauromatically_generate_table.Models
{
    public class StudentContext:DbContext
    {
        //creating a constructor and calling the base class constructor and passing the database name
        public StudentContext():base("StudentDatabase") { }
    }
}