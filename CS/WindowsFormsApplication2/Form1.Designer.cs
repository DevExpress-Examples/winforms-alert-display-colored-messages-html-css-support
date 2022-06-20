using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Converter;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Form1layoutControl1ConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleButton1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.colorPickEdit1item = new DevExpress.XtraLayout.LayoutControlItem();
            this.alertControl2 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).BeginInit();
            this.Form1layoutControl1ConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1item)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // Form1layoutControl1ConvertedLayout
            // 
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.simpleButton1);
            this.Form1layoutControl1ConvertedLayout.Controls.Add(this.colorPickEdit1);
            this.Form1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1layoutControl1ConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.Form1layoutControl1ConvertedLayout.Name = "Form1layoutControl1ConvertedLayout";
            this.Form1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2495, 99, 650, 400);
            this.Form1layoutControl1ConvertedLayout.Root = this.layoutControlGroup1;
            this.Form1layoutControl1ConvertedLayout.Size = new System.Drawing.Size(386, 121);
            this.Form1layoutControl1ConvertedLayout.TabIndex = 6;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(362, 22);
            this.simpleButton1.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Show alert with a color using HTML";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.colorPickEdit1.Location = new System.Drawing.Point(83, 38);
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Size = new System.Drawing.Size(291, 20);
            this.colorPickEdit1.StyleController = this.Form1layoutControl1ConvertedLayout;
            this.colorPickEdit1.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.simpleButton1item,
            this.colorPickEdit1item});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(386, 121);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 50);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(366, 51);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleButton1item
            // 
            this.simpleButton1item.Control = this.simpleButton1;
            this.simpleButton1item.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1item.Name = "simpleButton1item";
            this.simpleButton1item.Size = new System.Drawing.Size(366, 26);
            this.simpleButton1item.TextSize = new System.Drawing.Size(0, 0);
            this.simpleButton1item.TextVisible = false;
            // 
            // colorPickEdit1item
            // 
            this.colorPickEdit1item.BestFitWeight = 300;
            this.colorPickEdit1item.Control = this.colorPickEdit1;
            this.colorPickEdit1item.Location = new System.Drawing.Point(0, 26);
            this.colorPickEdit1item.Name = "colorPickEdit1item";
            this.colorPickEdit1item.Size = new System.Drawing.Size(366, 24);
            this.colorPickEdit1item.Text = "Select color:";
            this.colorPickEdit1item.TextSize = new System.Drawing.Size(59, 13);
            // 
            // alertControl2
            // 
            // 
            // 
            // 
            this.alertControl2.HtmlTemplate.Styles = resources.GetString("alertControl2.HtmlTemplate.Styles");
            this.alertControl2.HtmlTemplate.Template = resources.GetString("alertControl2.HtmlTemplate.Template");
            this.alertControl2.CustomizeHtmlTemplate += new DevExpress.XtraBars.Alerter.CustomizeAlertHtmlTemplateEventHandler(this.alertControl2_CustomizeHtmlTemplate);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("message_icon", "image://svgimages/outlook inspired/glyph_message.svg");
            this.svgImageCollection1.Add("message_image", "image://svgimages/business objects/bo_lead.svg");
            this.svgImageCollection1.Add("message_close", "image://svgimages/icon builder/actions_delete.svg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 121);
            this.Controls.Add(this.Form1layoutControl1ConvertedLayout);
            this.Name = "Form1";
            this.Text = "Colored alerts";
            ((System.ComponentModel.ISupportInitialize)(this.Form1layoutControl1ConvertedLayout)).EndInit();
            this.Form1layoutControl1ConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleButton1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1item)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private LayoutControl Form1layoutControl1ConvertedLayout;
        private LayoutControlGroup layoutControlGroup1;
        private LayoutControlItem simpleButton1item;
        private LayoutControlItem colorPickEdit1item;
        private EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl2;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}

