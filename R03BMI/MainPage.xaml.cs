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
            
          

            h=double.Parse(height.Text);
            w=double.Parse(weight.Text);

            if (h>100)
            {
                h=h/100;
            }

            if (w>1000)
            {
                w=w/1000;
            }
          
           
            bmi=w/(h*h);
            result.Text=(Math.Round(bmi,1,MidpointRounding.AwayFromZero)).ToString;
          
        }
    }
}
