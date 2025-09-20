using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Case8MovieTicketPricingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<MovieTicket> movies = new List<MovieTicket> 
            {
                new MovieTicket("Avengers Endgame", 10m),
                new MovieTicket("Inception", 12m),
                new MovieTicket("The Matrix", 8m),
                new MovieTicket("Interstellar", 15m),
                new MovieTicket("Joker", 9m),
                new MovieTicket("Frozen II", 7m),
                new MovieTicket("Toy Story 4", 11m),
            };

            listBoxMovies.DataSource = movies;
            listBoxMovies.DisplayMember = "Name";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (listBoxMovies.SelectedIndex < 0) { return; }
            else if (listBoxMovies.SelectedItem is MovieTicket selectedMovie)
            {
                if (checkBoxDiscount.Checked) 
                {
                    selectedMovie.Discount = numericUpDownDiscount.Value;
                }

                labelMovie.Text = $"Movie: {selectedMovie.MovieName}";
                labelPrice.Text = $"Original Price: ${selectedMovie.TicketPrice.ToString()}";
                labelDiscount.Text = $"Discount: {selectedMovie.Discount.ToString()}%";
                labelFinalPrice.Text = $"FinaPrice: ${selectedMovie.DiscountedPrice.ToString()}";
            }
        }
    }
}
