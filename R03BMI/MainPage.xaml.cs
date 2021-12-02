using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
          　double h;  
            double w;   
            double bmi;



        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A23 鈴木遥香";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try 
            { 
                string height=heighit.Text;
                string weight=weighi.Text;

                double height2=double.Parse(height);
                double weight2=double.Parse(weight);

            if (height2>=10)
            {
                height2=height2/100;
            }

            if wheight2>=1000)
            {
                weight2=weight2/1000;
            }



            double BMI=weight2/height2*height2;
            double BMI2=Math.Round(BMI,1);
                string status=null;

            if (BMI22>=18.5)
                {
                    status="低体重(痩せ)";
                 }
            else if(BMI2<25){
                    
                    status="普通体重";
                }
             else if(BMI2<30){

                    status="肥満 (1度)";
                }
             else if(BMI2<35){

                    status="肥満 (2度)";
                }
             else if(BMI2<40){
                    status="肥満 (3度)";
                }
            else {
                    status="肥満 (4度)";
                }
           
            result.Text="BMI値は"+BMI2+",状態は"+status+"です。";


                catch(FormatException ex)
                {
                    result.Text=ex.Message;
                    Console.WriteLine(ex.Message);
                }


            }
        }
    }
}
