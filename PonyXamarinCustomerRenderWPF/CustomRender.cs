using DeveloperHelperXForm;
using DeveloperHelperXForm.Models;
using Syncfusion.XForms.DataForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

[assembly: Xamarin.Forms.Platform.WPF.ExportRenderer(typeof(Syncfusion.XForms.DataForm.SfDataForm), typeof(DeveloperHelperXWpf.SfDataFormRenderer))]
namespace DeveloperHelperXWpf
{
    class SfDataFormRenderer : ViewRenderer<Syncfusion.XForms.DataForm.SfDataForm, Syncfusion.Windows.PropertyGrid.PropertyGrid>
    {

        protected override void OnElementChanged(ElementChangedEventArgs<Syncfusion.XForms.DataForm.SfDataForm> e)
        {
            base.OnElementChanged(e);

            if (Control == null )
            {

                var pg = new Syncfusion.Windows.PropertyGrid.PropertyGrid();

                SetNativeControl(pg);

            }


        }



        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == "DataObject")
            {
                Control.SelectedObject = Element.DataObject ;

            }
            // StyleId exist in all View and most of the time is not used, use this as a hint to copy all properties from Control to Element
            else if (e.PropertyName == "StyleId") 
            {

                this.Element.DataObject = Control.SelectedObject;

            }

        }


    }
}