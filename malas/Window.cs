using System;
namespace malas
{
    public partial class Window : Gtk.Window
    {
        public Window() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(entry1.Text);
            b = a * 9 / 5 + 32;
            label4.Text = b.ToString();
        }
    }
}
