using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
        private void simpleButton1_Click(object sender, EventArgs e) {
            alertControl1.Show(this, "Caption", "Text", "Hot-tracked text", null, null, colorPickEdit1.Color);
        }

        private void btnRegularAlert_Click(object sender, EventArgs e) {
            alertControl1.Show(this, "Caption", "Text", "Hot-tracked text", null, null);
        }
	}
}
