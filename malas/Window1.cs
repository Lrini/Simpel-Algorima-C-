using System;
namespace malas
{
    public partial class Window1 : Gtk.Window
    {
        public Window1() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void Onclick(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(entry1.Text);
            b = a * 4/5;
            label3.Text = b.ToString();
        }
    }
}
