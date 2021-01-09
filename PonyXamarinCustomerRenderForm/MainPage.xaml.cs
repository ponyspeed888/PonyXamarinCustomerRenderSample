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

        private async void Test1_Clicked(object sender, EventArgs e)
        {

            dataForm.DataObject = new IntentTask();


        }


        //async Task<FileResult> PickAndShow(PickOptions options)
        //{
        //    try
        //    {
        //        var result = await FilePicker.PickAsync();
        //        if (result != null)
        //        {
        //            Text = $"File Name: {result.FileName}";
        //            if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
        //                result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
        //            {
        //                var stream = await result.OpenReadAsync();
        //                Image = ImageSource.FromStream(() => stream);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // The user canceled or something went wrong
        //    }
        //}



    }
}
