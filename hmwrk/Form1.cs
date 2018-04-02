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
    public partial class Welcome : Form
    {
        public int Count = 1;
        public int movieCount = 1;
        public int salonID = 1;
        public int seansID = 1;
        public static int SelectedMovieNum;
        public static int SelectedMovieNumToSeans;

       
        
        public Welcome()
        {
            InitializeComponent();
            this.Width = 1301;
            this.Height = 697;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            convertToDropDownList();
            addInfoToInfoBox();
            AddSalonToSeansBoxs();
            addSeansToSeansBoxs();

            
        }

       



        public void addInfoToInfoBox()//metod user for add to InfoBox
        {
            MovieOne();

            void MovieOne()
            {


                Info mvOneInfo = new Info("Slash of the Titans", "2004", "6.5", "American", "Fox Studio", "Horror");
                //mvOneInfo.movieID = Count;
                foreach (Info item in mvOneInfo.moviesInfo)
                {
                    //item.movieID = movieCount;
                    //movieCount++;
                    MovieOneInfo.Items.Add(item.movieID + ":" + item.Name);
                    MovieOneInfo.Items.Add(item.movieID + ":" + item.VisionDate);
                    MovieOneInfo.Items.Add(item.movieID + ":" + item.IMDB_Point);
                    MovieOneInfo.Items.Add(item.movieID + ":" + item.Nationality);
                    MovieOneInfo.Items.Add(item.movieID + ":" + item.Company);
                    MovieOneInfo.Items.Add(item.movieID + ":" + item.TypeOfMovie);
                }


            }


            movieTwo();

            void movieTwo()
            {

                Info mvTwoInfo = new Info("Bang Bang", "2015", "5.5", "Indian", "Fox Studio", "Action");

                foreach (Info item in mvTwoInfo.moviesInfo)
                {
                    MovieTwoInfo.Items.Add(item.Name);
                    MovieTwoInfo.Items.Add(item.VisionDate);
                    MovieTwoInfo.Items.Add(item.IMDB_Point);
                    MovieTwoInfo.Items.Add(item.Nationality);
                    MovieTwoInfo.Items.Add(item.Company);
                    MovieTwoInfo.Items.Add(item.TypeOfMovie);
                }
            }


            movieThree();

            void movieThree()
            {

                Info mvThreeInfo = new Info("DeadPool", "2016", "7.8", "American", "Marvel", "Fantastic vs Action");

                foreach (Info item in mvThreeInfo.moviesInfo)
                {
                    MovieThreeInfo.Items.Add(item.Name);
                    MovieThreeInfo.Items.Add(item.VisionDate);
                    MovieThreeInfo.Items.Add(item.IMDB_Point);
                    MovieThreeInfo.Items.Add(item.Nationality);
                    MovieThreeInfo.Items.Add(item.Company);
                    MovieThreeInfo.Items.Add(item.TypeOfMovie);
                }
            }


            movieFourth();

            void movieFourth()
            {

                Info mvFourthInfo = new Info("John Wick 2", "2017", "8", "American", "Fox Studio", "Action");

                foreach (Info item in mvFourthInfo.moviesInfo)
                {
                    MovieFourInfo.Items.Add(item.Name);
                    MovieFourInfo.Items.Add(item.VisionDate);
                    MovieFourInfo.Items.Add(item.IMDB_Point);
                    MovieFourInfo.Items.Add(item.Nationality);
                    MovieFourInfo.Items.Add(item.Company);
                    MovieFourInfo.Items.Add(item.TypeOfMovie);
                }
            }
        }

       

        


        public void checkSeansOrSalonEmptyToMovieOne()
        {

            if (ChooseSalonToMovieOne.SelectedItem == null || ChooseSeansToMovieOne.SelectedItem == null)
            {
                MessageBox.Show("Maybe You Don't Choose Salon or Seans!!! Let's try again");

            }
            else
            {
                
                var secilmisItem = ChooseSalonToMovieOne.SelectedItem.ToString();




                switch (secilmisItem)
                {

                    case "1:Salon Nar Mobile":
                        
                        Salon_One so = new Salon_One();
                        so.Show();
                        so.SalonName.Text = ChooseSalonToMovieOne.SelectedItem.ToString();
                       
                        
                        break;

                    case "2:Salon VIP":
                        Salon_Two so2 = new Salon_Two();
                        so2.Show();
                        so2.SalonName2.Text = ChooseSalonToMovieOne.SelectedItem.ToString();
                        break;

                    case "3:Salon Ergen":
                        Salon_Three so3 = new Salon_Three();
                        so3.Show();
                        so3.SalonName3.Text = ChooseSalonToMovieOne.SelectedItem.ToString();
                        break;

                    case "4:Salon Sevgililer":
                        Salon_Four so4 = new Salon_Four();
                        so4.Show();
                        so4.SalonName4.Text = ChooseSalonToMovieOne.SelectedItem.ToString();
                        break;


                    default:
                       
                        break;
                }

            }
        }




        public void checkSeansOrSalonEmptyToMovieTwo()
        {

            if (ChooseSalonToMovieTwo.SelectedItem == null || ChooseSeansToMovieTwo.SelectedItem == null)
            {
                MessageBox.Show("Maybe You Don't Choose Salon or Seans!!! Let's try again");
            }
            else
            {
                var secilmisItem2 = ChooseSalonToMovieTwo.SelectedItem.ToString();




                switch (secilmisItem2)
                {

                    case "1:Salon Nar Mobile":
                        Salon_One so = new Salon_One();
                        so.Show();
                        so.SalonName.Text = ChooseSalonToMovieTwo.SelectedItem.ToString();
                        break;

                    case "2:Salon VIP":
                        Salon_Two so2 = new Salon_Two();
                        so2.Show();
                        so2.SalonName2.Text = ChooseSalonToMovieTwo.SelectedItem.ToString();
                        break;

                    case "3:Salon Ergen":
                        Salon_Three so3 = new Salon_Three();
                        so3.Show();
                        so3.SalonName3.Text = ChooseSalonToMovieTwo.SelectedItem.ToString();
                        break;

                    case "4:Salon Sevgililer":
                        Salon_Four so4 = new Salon_Four();
                        so4.Show();
                        so4.SalonName4.Text = ChooseSalonToMovieTwo.SelectedItem.ToString();
                        break;


                    default:

                        break;
                }
            }
        }





            public void checkSeansOrSalonEmptyToMovieThree()
            {


                if (ChooseSalonToMovieThree.SelectedItem == null || ChooseSeansToMovieThree.SelectedItem == null)
                {
                    MessageBox.Show("Maybe You Don't Choose Salon or Seans!!! Let's try again");
                }
                else
                {
                var secilmisItem3 = ChooseSalonToMovieThree.SelectedItem.ToString();




                switch (secilmisItem3)
                {

                    case "1:Salon Nar Mobile":
                        Salon_One so = new Salon_One();
                        so.Show();
                        so.SalonName.Text = ChooseSalonToMovieThree.SelectedItem.ToString();
                        break;

                    case "2:Salon VIP":
                        Salon_Two so2 = new Salon_Two();
                        so2.Show();
                        so2.SalonName2.Text = ChooseSalonToMovieThree.SelectedItem.ToString();
                        break;

                    case "3:Salon Ergen":
                        Salon_Three so3 = new Salon_Three();
                        so3.Show();
                        so3.SalonName3.Text = ChooseSalonToMovieThree.SelectedItem.ToString();
                        break;

                    case "4:Salon Sevgililer":
                        Salon_Four so4 = new Salon_Four();
                        so4.Show();
                        so4.SalonName4.Text = ChooseSalonToMovieThree.SelectedItem.ToString();
                        break;


                    default:

                        break;
                }
            }

            }




            public void checkSeansOrSalonEmptyToMovieFour()
            {


                if (ChooseSalonToMovieFour.SelectedItem == null || ChooseSeansToMovieFour.SelectedItem == null)
                {
                    MessageBox.Show("Maybe You Don't Choose Salon or Seans!!! Let's try again");
                }
                else
                {
                var secilmisItem4 = ChooseSalonToMovieFour.SelectedItem.ToString();




                switch (secilmisItem4)
                {

                    case "1:Salon Nar Mobile":
                        Salon_One so = new Salon_One();
                        so.Show();
                        so.SalonName.Text = ChooseSalonToMovieFour.SelectedItem.ToString();
                        Order_Was_Given owg = new Order_Was_Given();
                        owg.AMovieName.Text = Movies.moviesName[0];
                        break;

                    case "2:Salon VIP":
                        Salon_Two so2 = new Salon_Two();
                        so2.Show();
                        so2.SalonName2.Text = ChooseSalonToMovieFour.SelectedItem.ToString();
                        break;

                    case "3:Salon Ergen":
                        Salon_Three so3 = new Salon_Three();
                        so3.Show();
                        so3.SalonName3.Text = ChooseSalonToMovieFour.SelectedItem.ToString();
                        break;

                    case "4:Salon Sevgililer":
                        Salon_Four so4 = new Salon_Four();
                        so4.Show();
                        so4.SalonName4.Text = ChooseSalonToMovieFour.SelectedItem.ToString();
                        break;


                    default:
                       
                        break;
                }
                }
            }


            //MOVIE CLICK SECTION Start
            

            //This Code will Executed When You Click To Picture Box one
            private void Movie1_Click(object sender, EventArgs e)
            {
              checkSeansOrSalonEmptyToMovieOne();
            SelectedMovieNum = 0;
            SelectedMovieNumToSeans = 0;

            }

            //This Code will Executed When You Click To Picture Box Two
            private void Movie2_Click(object sender, EventArgs e)
            {
                checkSeansOrSalonEmptyToMovieTwo();
                SelectedMovieNum = 1;
               
        }

            //This Code will Executed When You Click To Picture Box Three
            private void Movie3_Click(object sender, EventArgs e)
            {
                checkSeansOrSalonEmptyToMovieThree();
            }

            //This Code will Executed When You Click To Picture Box Four
            private void Movie4_Click(object sender, EventArgs e)
            {
                checkSeansOrSalonEmptyToMovieFour();
            }


        //MOVIE CLICK SECTION END

        public void AddSalonToSeansBoxs()
            {
                salonID = 1;
                foreach (string salon in Salons.listOfSalons)
                {

                    Salons.ID = salonID;
                    salonID++;
                    ChooseSalonToMovieOne.Items.Add(Salons.ID + ":" + salon);
                    ChooseSalonToMovieThree.Items.Add(Salons.ID + ":" + salon);
                    ChooseSalonToMovieTwo.Items.Add(Salons.ID + ":" + salon);
                    ChooseSalonToMovieFour.Items.Add(Salons.ID + ":" + salon);
                }
            }


            public void addSeansToSeansBoxs()
            {
                AddMovieOne();
                void AddMovieOne()
                {
                    foreach (string seans in Seans.seansList)
                    {

                        Seans.ID = seansID;
                        seansID++;

                        ChooseSeansToMovieOne.Items.Add(Seans.ID + ":" + seans);
                        ChooseSeansToMovieTwo.Items.Add(Seans.ID + ":" + seans);
                        ChooseSeansToMovieThree.Items.Add(Seans.ID + ":" + seans);
                        ChooseSeansToMovieFour.Items.Add(Seans.ID + ":" + seans);
                    }
                }
            }

            public void convertToDropDownList()
            {
                //Convert Movies Info To Drop Down List
                MovieOneInfo.DropDownStyle = ComboBoxStyle.DropDownList;
                MovieTwoInfo.DropDownStyle = ComboBoxStyle.DropDownList;
                MovieThreeInfo.DropDownStyle = ComboBoxStyle.DropDownList;
                MovieFourInfo.DropDownStyle = ComboBoxStyle.DropDownList;


                //Convert Choose Salons's Item To Drop Down List
                ChooseSalonToMovieOne.DropDownStyle = ComboBoxStyle.DropDownList;
                ChooseSalonToMovieTwo.DropDownStyle = ComboBoxStyle.DropDownList;
                ChooseSalonToMovieThree.DropDownStyle = ComboBoxStyle.DropDownList;
                ChooseSalonToMovieFour.DropDownStyle = ComboBoxStyle.DropDownList;


                //Convert Choose Sean's item To Drop Down List
                ChooseSeansToMovieOne.DropDownStyle = ComboBoxStyle.DropDownList;
                ChooseSeansToMovieTwo.DropDownStyle = ComboBoxStyle.DropDownList;
                ChooseSeansToMovieThree.DropDownStyle = ComboBoxStyle.DropDownList;
                ChooseSeansToMovieFour.DropDownStyle = ComboBoxStyle.DropDownList;

            }

        private void btnCloser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void InfoMovie_Click(object sender, EventArgs e)
        {

        }

        
    }
    }




