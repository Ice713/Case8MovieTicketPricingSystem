using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case8MovieTicketPricingSystem
{
    internal class MovieTicket
    {

        public string MovieName { get; set; }
        public decimal TicketPrice { get; set; }

        private decimal discount;
        public decimal Discount
        {
            get => discount;
            set
            {
                if (value < 0)
                    discount = 0;
                else if (value > 100)
                    discount = 100;
                else
                    discount = value;
            }
        }

        public decimal DiscountedPrice => TicketPrice - (TicketPrice * Discount / 100);

        public MovieTicket(string movieName, decimal ticketPrice, decimal discount = 0) 
        {
            MovieName = movieName;
            TicketPrice = ticketPrice;
            Discount = discount;  
        }
    }
}
