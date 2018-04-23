namespace WindowsFormsApplication2
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if ( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.btnColoredAlert = new DevExpress.XtraEditors.SimpleButton();
            this.btnRegularAlert = new DevExpress.XtraEditors.SimpleButton();
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.alertControl1 = new WindowsFormsApplication2.CustomAlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColoredAlert
            // 
            this.btnColoredAlert.Location = new System.Drawing.Point(12, 12);
            this.btnColoredAlert.Name = "btnColoredAlert";
            this.btnColoredAlert.Size = new System.Drawing.Size(143, 31);
            this.btnColoredAlert.TabIndex = 0;
            this.btnColoredAlert.Text = "Show alert with a color";
            this.btnColoredAlert.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnRegularAlert
            // 
            this.btnRegularAlert.Location = new System.Drawing.Point(12, 49);
            this.btnRegularAlert.Name = "btnRegularAlert";
            this.btnRegularAlert.Size = new System.Drawing.Size(143, 31);
            this.btnRegularAlert.TabIndex = 2;
            this.btnRegularAlert.Text = "Show regular alert";
            this.btnRegularAlert.Click += new System.EventHandler(this.btnRegularAlert_Click);
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colorPickEdit1.Location = new System.Drawing.Point(161, 18);
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Size = new System.Drawing.Size(213, 20);
            this.colorPickEdit1.TabIndex = 3;
            // 
            // alertControl1
            // 
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.colorPickEdit1);
            this.Controls.Add(this.btnRegularAlert);
            this.Controls.Add(this.btnColoredAlert);
            this.Name = "Form1";
            this.Text = "Colored alerts";
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private CustomAlertControl alertControl1;
        private DevExpress.XtraEditors.SimpleButton btnColoredAlert;
        private DevExpress.XtraEditors.SimpleButton btnRegularAlert;
        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit1;
	}
}

