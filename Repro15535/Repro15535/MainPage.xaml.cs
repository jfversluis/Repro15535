using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Repro15535
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            myLabel.Text = "A\nb";
        }
    }
}

