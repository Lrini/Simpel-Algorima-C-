using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void Click(object sender, EventArgs e)
    {
        malas.Window frm = new malas.Window();
        frm.Show(); ;

    }
    protected void onclick(object sender, EventArgs e)
    {
        malas.Window1 frd = new malas.Window1();
        frd.Show();

    }

    protected void OnClick(object sender, EventArgs e)
    {
        malas.Window2 fre = new malas.Window2();
        fre.Show();
    }

    protected void Onclick(object sender, EventArgs e)
    {
        malas.Window3 frw = new malas.Window3();
        frw.Show();
    }
}
