using System;
namespace malas
{
    public partial class Window2 : Gtk.Window
    {
        public Window2() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        protected void OnClick(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(entry2.Text);
            b = a + 273.15;
            label7.Text = b.ToString();
        }
    }
}
