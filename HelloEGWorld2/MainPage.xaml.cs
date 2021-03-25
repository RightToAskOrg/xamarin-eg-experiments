using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ElectionGuard;

namespace HelloEGWorld2
{
    public partial class MainPage : ContentPage
    {
        // ulong[] rValue;
        ulong[] rValue = new ulong[] { 0, 0 };
        ElementModP r;

        public MainPage()
        {
            // ulong[] rValue = new ulong[] { 0, 0 };
            r = new ElementModP(rValue);

            InitializeComponent();
        }

        int count = 0;
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            count++;
            ((Button)sender).Text = $"You clicked {count} times.";
        }


        void EG_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            ((Button)sender).Text = $"You clicked the EG button.";
        }
    }
}
