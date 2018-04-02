using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace letsCinema
{
   
    public partial class Order_Was_Given : Form
    {
       

        public string seats;
        public Order_Was_Given()
        {
            InitializeComponent();
            showInfo();
            
        }

        public void showInfo()
        {
            AName.Text = ReserveSeats.Ad;
            ASurName.Text = ReserveSeats.Soyad;
            APrice.Text = Salon_One.Qiymet.ToString();
            AMovieName.Text = Movies.moviesName[Welcome.SelectedMovieNum];

            APrice.Text = Salon_Two.Qiymet2.ToString();

            foreach (Button item in Salon_One.seatList)
            {
                seats += item.Text + ",";
                ABiletNo.Text = seats;
            }

            foreach (Button item2 in Salon_Two.seatList)
            {
                seats += item2.Text + ",";
                ABiletNo.Text = seats;
            }

        }

      
    }
}
