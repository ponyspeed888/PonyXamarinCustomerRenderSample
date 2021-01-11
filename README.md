This project demonstrate that you can REPLACE a Xamarin form control in
platform specific code that render a control that does not exist in
Xamarin form. In this case, I want to use a property grid in both
Android and WPF. Syncfusion WPF has propertyGrid control, but not in
Xamarin Form. The Syncfusion DataForm control looks very like a
propertyGrid, so this on is used as a property grid. We need a customer
renderer for SfDataForm in the WPF project. It intercept the
\"DataObject\" property setter. The core concept is that you can use
*OnElementPropertyChanged e*vent to set Property that does not exist in
Xamarin form control. StyleId property exist in all View and most of the
time is not used, use this as a hint to copy all properties from Control
back to Element
