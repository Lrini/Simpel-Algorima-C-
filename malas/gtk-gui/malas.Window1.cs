
// This file has been generated by the GUI designer. Do not modify.
namespace malas
{
	public partial class Window1
	{
		private global::Gtk.Fixed fixed1;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entry1;

		private global::Gtk.Button button1;

		private global::Gtk.Label label2;

		private global::Gtk.Label label3;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget malas.Window1
			this.Name = "malas.Window1";
			this.Title = global::Mono.Unix.Catalog.GetString("Celsius To Reamur");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child malas.Window1.Gtk.Container+ContainerChild
			this.fixed1 = new global::Gtk.Fixed();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Celsius");
			this.fixed1.Add(this.label1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label1]));
			w1.X = 97;
			w1.Y = 84;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed1.Add(this.entry1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.entry1]));
			w2.X = 165;
			w2.Y = 79;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.button1 = new global::Gtk.Button();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString("Konversi");
			this.fixed1.Add(this.button1);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.button1]));
			w3.X = 149;
			w3.Y = 120;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Reamur");
			this.fixed1.Add(this.label2);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label2]));
			w4.X = 94;
			w4.Y = 162;
			// Container child fixed1.Gtk.Fixed+FixedChild
			this.label3 = new global::Gtk.Label();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.fixed1.Add(this.label3);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1[this.label3]));
			w5.X = 172;
			w5.Y = 164;
			this.Add(this.fixed1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button1.Clicked += new global::System.EventHandler(this.Onclick);
		}
	}
}
