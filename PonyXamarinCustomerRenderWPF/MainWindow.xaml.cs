﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace PonyXamarinCustomerRenderWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();



    
            Forms.Init();

            Syncfusion.SfDataGrid.XForms.WPF.SfDataGridRenderer.Init();
            Syncfusion.ListView.XForms.WPF.SfListViewRenderer.Init();
            Syncfusion.XForms.WPF.Buttons.SfCheckBoxRenderer.Init();
            Syncfusion.XForms.WPF.Border.SfBorderRenderer.Init();

            LoadApplication(new PonyXamarinCustomerRenderForm.App());
        }
    }
}
