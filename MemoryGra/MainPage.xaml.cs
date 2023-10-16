using System.Diagnostics.Metrics;

namespace MemoryGra
{
    public partial class MainPage : ContentPage
    {
        Random rnd = new Random();
        int flower = 0;
        int cherry = 0;
        int orange = 0;
        int wylosowano;
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnGrajClicked(object sender, EventArgs e)
        {
            flower = 0;
            cherry = 0;
            orange = 0;
            int but1 = 0;
            int but2 = 0;
            int but3 = 0;
            int but4 = 0;
            int but5 = 0;
            int but6 = 0;
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
                    but1 = wylosowano;
                }
                if (i == 1)
                {
                    Btn2.Source = "o" + wylosowano.ToString() + ".png";
                    but2 = wylosowano;
                }
                if (i == 2)
                {
                    Btn3.Source = "o" + wylosowano.ToString() + ".png";
                    but3 = wylosowano;
                }
                if (i == 3)
                {
                    Btn4.Source = "o" + wylosowano.ToString() + ".png";
                    but4 = wylosowano;
                }
                if (i == 4)
                {
                    Btn5.Source = "o" + wylosowano.ToString() + ".png";
                    but5 = wylosowano;
                }
                if (i == 5)
                {
                    Btn6.Source = "o" + wylosowano.ToString() + ".png";
                    but6 = wylosowano;
                }


                await Task.Delay(1000);


                Btn1.Source = "o0.png";
                Btn2.Source = "o0.png";
                Btn3.Source = "o0.png";
                Btn4.Source = "o0.png";
                Btn5.Source = "o0.png";
                Btn6.Source = "o0.png";

            }





            Btn1.Source = "o" + but1 +".png";
            Btn2.Source = "o" + but2 +".png";
            Btn3.Source = "o" + but3 +".png";
            Btn4.Source = "o" + but4 +".png";
            Btn5.Source = "o" + but5 +".png";
            Btn6.Source = "o" + but6 +".png";
            await Task.Delay(500);
            Btn1.Source = "o0.png";
            Btn2.Source = "o0.png";
            Btn3.Source = "o0.png";
            Btn4.Source = "o0.png";
            Btn5.Source = "o0.png";
            Btn6.Source = "o0.png";



            Btn1.IsEnabled = true;
            Btn2.IsEnabled = true;
            Btn3.IsEnabled = true;
            Btn4.IsEnabled = true;
            Btn5.IsEnabled = true;
            Btn6.IsEnabled = true;
        }


        private void OnCheckClicked (object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ImageSource =;
        }


        }
}