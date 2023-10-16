using System.Diagnostics.Metrics;

namespace MemoryGra
{
    public partial class MainPage : ContentPage
    {
        ImageButton btn2;
        ImageButton btn;
        List<ImageButton> imageButtons = new List<ImageButton>();
        Random rnd = new Random();
        int[] but;
        int flower, cherry, orange;
        int wylosowano;
        int znaleziono;
        string x, y;
        public MainPage()
        {
            InitializeComponent();
            imageButtons.Add(Btn1);
            imageButtons.Add(Btn2);
            imageButtons.Add(Btn3);
            imageButtons.Add(Btn4);
            imageButtons.Add(Btn5);
            imageButtons.Add(Btn6);
        }

        private async void OnGrajClicked(object sender, EventArgs e)
        {
            foreach (var imgButton in imageButtons) imgButton.IsVisible = true;
            but = new int[] { 0, 0, 0, 0, 0, 0 };
            winLbl.Text = "";
            flower = cherry = orange = 0;
            for (int i=0; i<6; i++)
            {
                    wylosowano = rnd.Next(1, 4);
                    if (wylosowano == 1) flower++;
                    if (wylosowano == 2) cherry++;
                    if (wylosowano == 3) orange++;



                    if (flower > 2) {
                        flower--;
                        i--;
                        continue;
                    }

                    if (cherry > 2)
                    {
                        cherry--;
                        i--;
                        continue;
                    }

                    if (orange > 2)
                    {
                        orange--;
                        i--;
                        continue;
                    }





                if (i == 0) {
                    Btn1.Source = "o" + wylosowano.ToString() + ".png";
                    but[0] = wylosowano;
                }
                if (i == 1)
                {
                    Btn2.Source = "o" + wylosowano.ToString() + ".png";
                    but[1] = wylosowano;
                }
                if (i == 2)
                {
                    Btn3.Source = "o" + wylosowano.ToString() + ".png";
                    but[2] = wylosowano;
                }
                if (i == 3)
                {
                    Btn4.Source = "o" + wylosowano.ToString() + ".png";
                    but[3] = wylosowano;
                }
                if (i == 4)
                {
                    Btn5.Source = "o" + wylosowano.ToString() + ".png";
                    but[4] = wylosowano;
                }
                if (i == 5)
                {
                    Btn6.Source = "o" + wylosowano.ToString() + ".png";
                    but[5] = wylosowano;
                }


                await Task.Delay(500);


                foreach (var imgButton in imageButtons) imgButton.Source = "o0.png";

            }




            Btn1.Source = "o" + but[0] +".png";
            Btn2.Source = "o" + but[1] + ".png";
            Btn3.Source = "o" + but[2] + ".png";
            Btn4.Source = "o" + but[3] + ".png";
            Btn5.Source = "o" + but[4] + ".png";
            Btn6.Source = "o" + but[5] + ".png";
            await Task.Delay(500);
            foreach (var imgButton in imageButtons) imgButton.Source = "o0.png";
            foreach (var imgButton in imageButtons) imgButton.IsEnabled = true;


        }


        private async void OnCheckClicked (object sender, EventArgs e)
        {
            if(x==null) btn = sender as ImageButton;
            else btn2 = sender as ImageButton;

            if (x == null)
            {
                btn.IsEnabled = false;
                btn.Source = "o" + but[int.Parse((btn.CommandParameter).ToString()) - 1] + ".png";
            }
            else
            {
                btn2.IsEnabled = false;
                btn2.Source = "o" + but[int.Parse((btn2.CommandParameter).ToString()) - 1] + ".png";
            }


            if (x == null) x = btn.Source.ToString();
            else y = btn2.Source.ToString();





            await Task.Delay(1000);


            if (x == y && x != null)
            {
                x = null; y=null;
                znaleziono++;
                btn.IsVisible = false;
                btn2.IsVisible = false;
                btn = null;
                btn2 = null;
            }
            else if (btn!=null && btn2!=null)
            {
                x = null; y = null;
                btn.IsEnabled = true;
                btn2.IsEnabled = true;
                btn.Source = "o0.png";
                btn2.Source = "o0.png";
                btn = null;
                btn2 = null;
            }
            if (znaleziono==3)
            {
                winLbl.Text = "Wygrałeś!";
                znaleziono = 0;
            }


        }


        }
}