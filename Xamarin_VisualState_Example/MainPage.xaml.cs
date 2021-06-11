using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin_VisualState_Example
{
    public partial class MainPage : ContentPage
    {
        private bool FlagDisableEntry { get; set; } = true;

        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisableEntry.IsEnabled = FlagDisableEntry = !FlagDisableEntry;
        }
    }
}
