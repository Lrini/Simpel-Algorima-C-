using System;
namespace malas
{
    public partial class Window3 : Gtk.Window
    {
        public Window3() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void Onclik(object sender, EventArgs e)
        {
            int a, b,c,d,f;
            a = Convert.ToInt32(entry1.Text);
            b = a / 3600;
            label4.Text = b.ToString();
            c = a - (b * 3600);
            d = c / 60;
            label5.Text = d.ToString();
            f = c - (d * 60);
            label6.Text = f.ToString();
        }
    }
}
