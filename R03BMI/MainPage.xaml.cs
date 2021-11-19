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
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A23 鈴木遥香";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //94
            //不快指数参考にする
            double h;   //height
            double w;   //weight
            double bmi;

            h=double.Parse(height.Text);
            w=double.Parse(weight.Text);
            //bmi=w/(h*h);
            //result=bmi;
            bmi=w/(h*h);
           //result=Math.Round(bmi,1,MidpointRounding.AwayFromZero);
            result=(Math.Round(bmi,1,MidpointRounding.AwayFromZero)).ToString;
            //result=w/(h*h).ToString;

            //heighit.text="";
        }
    }
}
