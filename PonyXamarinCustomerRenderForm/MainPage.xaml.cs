using DeveloperHelperXForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PonyXamarinCustomerRenderForm
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void SetObject_Clicked(object sender, EventArgs e)
        {

            dataForm.DataObject = new IntentTask();


        }

        private void bntGetObject_Clicked(object sender, EventArgs e)
        {
            // StyleId exist in all View and most of the time is not used, use this as a hint to copy all properties from Control to Element

            //dataForm.StyleId = "sis";

            IntentTask tsk = dataForm.DataObject as IntentTask;
            if (tsk.IntentTaskTitle == null )
                App.Current.MainPage.DisplayAlert("don care in wpf" , "Please set title property", "OK");
            else
                App.Current.MainPage.DisplayAlert(tsk.IntentTaskTitle, tsk.IntentTaskTitle, "OK");
        }





    }
}
