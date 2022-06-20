using DevExpress.Utils.Html;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
            alertControl2.HtmlImages = svgImageCollection1;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            alertControl1.Show(this, "Caption", "Text", "Hot-tracked text", null, null, colorPickEdit1.Color);
        }

        private void btnRegularAlert_Click(object sender, EventArgs e) {
            alertControl1.Show(this, "Caption", "Text", "Hot-tracked text", (Image)null, null);
        }
    }
}
