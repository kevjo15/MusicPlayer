using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.ComponentModel;

namespace MusicApp
{
    internal class TransparentListBox : ListBox
    {

        public TransparentListBox() : base()
        {
            SetStyle(
                    ControlStyles.Opaque |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.UserPaint |
                    ControlStyles.OptimizedDoubleBuffer, true);
            DrawMode = DrawMode.OwnerDrawFixed;
        }
        public Color SelectionBackColor { get; set; } = Color.DarkOrange;

        [DllImport("uxtheme", ExactSpelling = true)]
        private extern static int DrawThemeParentBackground(
            IntPtr hWnd,
            IntPtr hdc,
            ref Rectangle pRect
            );

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            var rec = ClientRectangle;

            IntPtr hdc = g.GetHdc();
            DrawThemeParentBackground(this.Handle, hdc, ref rec);
            g.ReleaseHdc(hdc);

            using (Region reg = new Region(e.ClipRectangle))
            {
                if (Items.Count > 0)
                {
                    for (int i = 0; i < Items.Count; i++)
                    {
                        rec = GetItemRectangle(i);

                        if (e.ClipRectangle.IntersectsWith(rec))
                        {
                            if ((SelectionMode == SelectionMode.One && SelectedIndex == i) ||
                                (SelectionMode == SelectionMode.MultiSimple && SelectedIndices.Contains(i)) ||
                                (SelectionMode == SelectionMode.MultiExtended && SelectedIndices.Contains(i)))
                                OnDrawItem(new DrawItemEventArgs(g, Font, rec, i, DrawItemState.Selected, ForeColor, BackColor));
                            else
                                OnDrawItem(new DrawItemEventArgs(g, Font, rec, i, DrawItemState.Default, ForeColor, BackColor));

                            reg.Complement(rec);
                        }
                    }
                }
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            var rec = e.Bounds;
            var g = e.Graphics;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                using (SolidBrush sb = new SolidBrush(SelectionBackColor))
                    g.FillRectangle(sb, rec);

            using (SolidBrush sb = new SolidBrush(ForeColor))
            using (StringFormat sf = new StringFormat { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center })
                g.DrawString(GetItemText(Items[e.Index]), Font, sb, rec, sf);
        }
        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);
            Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            Invalidate();
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);
            Invalidate();
        }
            private const int WM_KILLFOCUS  = 0x8;
    private const int WM_VSCROLL    = 0x115;
    private const int WM_HSCROLL    = 0x114;

    protected override void WndProc(ref Message m)
    {
        if (m.Msg != WM_KILLFOCUS && 
            (m.Msg == WM_HSCROLL || m.Msg == WM_VSCROLL))
            Invalidate();
        base.WndProc(ref m);
    }

    }
}
