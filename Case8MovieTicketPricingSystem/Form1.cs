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
        }
    }
}
