using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace movietecket
{
    internal abstract class Movie_Ticket //abstract class
    {

            



        public string Movie_Name { get; set; }
        public string Theater_Name { get; set; }

        public string Show_Time { get; set; }

        public int No_Of_Seats { get; set; }

        public float Ticket_Price { get; set; }
        
            



        public abstract string Calculate_Ticket_Price();//abstract method 
    }


    class Online_Booking : Movie_Ticket
    {

        public Online_Booking(string Movie_Name, string Theater_Name, string Show_Time, int No_of_Seats, float Ticket_Price)
        {
            this.Movie_Name = Movie_Name;
            this.Theater_Name = Theater_Name;
            this.Show_Time = Show_Time;
            this.No_Of_Seats = No_of_Seats;
            this.Ticket_Price = Ticket_Price;

        }
        public float Discount { get; set; }

        public override string Calculate_Ticket_Price()
        {

            float tp = No_Of_Seats * Ticket_Price;
            Discount = tp * 0.10f;
            tp = tp - Discount;

            return "Total Price" + tp.ToString();
        }
    }

    class BoxOffice : Movie_Ticket//hierachical inheritance
    {

        public BoxOffice(string Movie_Name, string Theater_Name, string Show_Time, int No_of_Seats, float Ticket_Price)
        {
            this.Movie_Name = Movie_Name;
            this.Theater_Name = Theater_Name;
            this.Show_Time = Show_Time;
            this.No_Of_Seats = No_of_Seats;
            this.Ticket_Price = Ticket_Price;

        }


        public float Booking_Amount { get; set; }
        public override string Calculate_Ticket_Price()
        {

            float tp = No_Of_Seats * Ticket_Price;
            Booking_Amount = 20;
            tp = tp + Booking_Amount;




            return "Total Price " + tp.ToString();



        }


    }










}
