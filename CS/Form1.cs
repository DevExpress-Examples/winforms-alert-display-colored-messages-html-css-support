﻿using DevExpress.Utils.Html;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
            alertControl2.HtmlImages = svgImageCollection1;
        }

        private void alertControl2_CustomizeHtmlTemplate(object sender, DevExpress.XtraBars.Alerter.CustomizeAlertHtmlTemplateEventArgs e)
        {
            DxHtmlElement element = e.Root.FindElementById("popup");
            if (element != null)
                element.Style.SetBackgroundColor(colorPickEdit1.Color);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            alertControl2.Show(this, "Caption", "Text");
        }
       
    }
}
