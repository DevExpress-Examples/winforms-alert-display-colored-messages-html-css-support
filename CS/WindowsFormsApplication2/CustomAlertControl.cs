using DevExpress.XtraBars.Alerter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2 {
    public class CustomAlertControl : AlertControl {
        public CustomAlertControl() { }

        public CustomAlertControl(System.ComponentModel.IContainer container)
            : base(container) { }

        protected override AlertForm CreateAlertForm(System.Drawing.Point location, AlertControl control, AlertInfo info) {
            return new MyAlertForm(location, control, info);
        }

        public void Show(Form owner, string caption, string text, string hotTrackedText, Image image, object tag, Color color) {
            base.Show(owner, new MyAlertInfo(caption, text, hotTrackedText, image, tag, color));
        }
    }

    public class MyAlertForm : AlertForm {
        public MyAlertForm(System.Drawing.Point location, IAlertControl control, AlertInfo info)
            : base(location, control, info) { }
        protected override AlertPainter CreatePainter() {
            return new MyAlertPainter(this);
        }
    }

    public class MyAlertPainter : AlertPainter {
        public MyAlertPainter(AlertFormCore form)
            : base(form) {
        }

        protected override void DrawContent(DevExpress.Utils.Drawing.GraphicsCache graphicsCache, DevExpress.Skins.Skin skin) {
            base.DrawContent(graphicsCache, skin);
            MyAlertInfo alertInfo = Owner.Info as MyAlertInfo;
            if (alertInfo != null) {
                Color backColor = alertInfo.BackColor;
                Rectangle rect = new Rectangle(Owner.ClientRectangle.Location, Owner.ClientRectangle.Size);
                rect.Inflate(-2, -2);
                using (SolidBrush brush = new SolidBrush(backColor))
                    graphicsCache.Graphics.FillRectangle(brush, rect);
            }
        }
    }

    public class MyAlertInfo : AlertInfo {
        public MyAlertInfo(string caption, string text)
            : base(caption, text) { }

        public MyAlertInfo(string caption, string text, string hotTrackedText)
            : base(caption, text, hotTrackedText) {
        }

        public MyAlertInfo(string caption, string text, Image image)
            : base(caption, text, image) { }

        public MyAlertInfo(string caption, string text, string hotTrackedText, Image image)
            : base(caption, text, hotTrackedText, image) { }

        public MyAlertInfo(string caption, string text, string hotTrackedText, Image image, object tag)
            : base(caption, text, hotTrackedText, image, tag) { }

        public MyAlertInfo(string caption, string text, string hotTrackedText, Image image, object tag, Color color)
            : base(caption, text, hotTrackedText, image, tag) {
                BackColor = color;
        }

        public Color BackColor {
            get; set;
        }
    }
}
