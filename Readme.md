<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128618175/22.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T190778)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Alert Control - Display alert popups in different colors

The WinForms AlertControl v.22.1+ supports [HTML and CSS Templates](https://docs.devexpress.com/WindowsForms/403775/controls-and-libraries/messages-notifications-and-dialogs/alert-windows/alert-windows-with-html-templates). This example handles the `AlertControl.CustomizeHtmlTemplate` event to customize the background color of alert windows:

```csharp
private void alertControl2_CustomizeHtmlTemplate(object sender, DevExpress.XtraBars.Alerter.CustomizeAlertHtmlTemplateEventArgs e) {
    DxHtmlElement element = e.Root.FindElementById("popup");
    if (element != null)
        element.Style.SetBackgroundColor(colorPickEdit1.Color);
}
```

![WinForms Alert Control - Display alert popups in different colors](https://raw.githubusercontent.com/DevExpress-Examples/alertcontrol-how-to-display-alert-popups-with-different-colors-t190778/22.1.2%2B/media/winforms-alert-control-html-css-support.png)


## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication2/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication2/Form1.vb))


## Documentation

* [Alert Windows with HTML Templates](https://docs.devexpress.com/WindowsForms/403775/controls-and-libraries/messages-notifications-and-dialogs/alert-windows/alert-windows-with-html-templates)
* [HTML and CSS Support](https://docs.devexpress.com/WindowsForms/403397/common-features/html-css-based-desktop-ui)
