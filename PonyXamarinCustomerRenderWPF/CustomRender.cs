using DeveloperHelperXForm;
using DeveloperHelperXForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

[assembly: Xamarin.Forms.Platform.WPF.ExportRenderer(typeof(Syncfusion.XForms.DataForm.SfDataForm), typeof(DeveloperHelperXWpf.SfDataFormRenderer))]
namespace DeveloperHelperXWpf
{
     class SfDataFormRenderer : ViewRenderer<Syncfusion.XForms.DataForm.SfDataForm, System.Windows.FrameworkElement>
    {


        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.DataForm.SfDataForm> e)
        {
            base.OnElementChanged(e);

             var pg = new Syncfusion.Windows.PropertyGrid.PropertyGrid();

            SetNativeControl(pg);



            if (Control != null)
            {
            }
        }


        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == "DataObject")
            {

                var obj = ((Syncfusion.XForms.DataForm.SfDataForm)sender).DataObject;
                ((Syncfusion.Windows.PropertyGrid.PropertyGrid)GetNativeElement()).SelectedObject = obj;

            }
        }


    }
}