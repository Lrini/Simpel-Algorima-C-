
// This file has been generated by the GUI designer. Do not modify.
namespace malas
{
	public partial class Window
	{
		private global::Gtk.Fixed fixed4;

		private global::Gtk.Label label1;

		private global::Gtk.Entry entry1;

		private global::Gtk.Button button3;

		private global::Gtk.Label label2;

		private global::Gtk.Label label4;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget malas.Window
			this.Name = "malas.Window";
			this.Title = global::Mono.Unix.Catalog.GetString("Celsius To Fahrenheit");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child malas.Window.Gtk.Container+ContainerChild
			this.fixed4 = new global::Gtk.Fixed();
			this.fixed4.Name = "fixed4";
			this.fixed4.HasWindow = false;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Celsius");
			this.fixed4.Add(this.label1);
			global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed4[this.label1]));
			w1.X = 71;
			w1.Y = 78;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.entry1 = new global::Gtk.Entry();
			this.entry1.CanFocus = true;
			this.entry1.Name = "entry1";
			this.entry1.IsEditable = true;
			this.entry1.InvisibleChar = '•';
			this.fixed4.Add(this.entry1);
			global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed4[this.entry1]));
			w2.X = 188;
			w2.Y = 72;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.button3 = new global::Gtk.Button();
			this.button3.CanFocus = true;
			this.button3.Name = "button3";
			this.button3.UseUnderline = true;
			this.button3.Label = global::Mono.Unix.Catalog.GetString("Konversi");
			this.fixed4.Add(this.button3);
			global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed4[this.button3]));
			w3.X = 146;
			w3.Y = 119;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label2 = new global::Gtk.Label();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Fahrenheit");
			this.fixed4.Add(this.label2);
			global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed4[this.label2]));
			w4.X = 63;
			w4.Y = 161;
			// Container child fixed4.Gtk.Fixed+FixedChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("0");
			this.fixed4.Add(this.label4);
			global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed4[this.label4]));
			w5.X = 207;
			w5.Y = 160;
			this.Add(this.fixed4);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show();
			this.button3.Clicked += new global::System.EventHandler(this.Click);
		}
	}
}