
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.VBox vbox2;

	private global::Gtk.HBox hbox4;

	private global::Gtk.VBox vbox9;

	private global::Gtk.Label label8;

	private global::Gtk.Entry entryIP;

	private global::Gtk.HSeparator hseparator1;

	private global::Gtk.VBox vbox10;

	private global::Gtk.Label label6;

	private global::Gtk.Entry entryPORT;

	private global::Gtk.HSeparator hseparator2;

	private global::Gtk.HBox hbox2;

	private global::Gtk.VBox vbox5;

	private global::Gtk.Label label3;

	private global::Gtk.RadioButton rbQUEUE;

	private global::Gtk.RadioButton rbCALC;

	private global::Gtk.VSeparator vseparator1;

	private global::Gtk.VBox vbox6;

	private global::Gtk.Label label4;

	private global::Gtk.Entry entryCOUNT;

	private global::Gtk.VBox vbox3;

	private global::Gtk.Label label1;

	private global::Gtk.Entry entryDELAY;

	private global::Gtk.VSeparator vseparator2;

	private global::Gtk.VBox vbox7;

	private global::Gtk.VBox vbox4;

	private global::Gtk.Label label10;

	private global::Gtk.HBox hbox1;

	private global::Gtk.VBox vbox8;

	private global::Gtk.Label label2;

	private global::Gtk.Label label5;

	private global::Gtk.Label label7;

	private global::Gtk.Label label9;

	private global::Gtk.VBox vbox11;

	private global::Gtk.Entry entryN;

	private global::Gtk.Entry entryLAMBDA;

	private global::Gtk.Entry entryMU;

	private global::Gtk.Entry entryM;

	private global::Gtk.Button generate;

	private global::Gtk.ScrolledWindow GtkScrolledWindow;

	private global::Gtk.TextView Log;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("SMO-alfa");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		this.Resizable = false;
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox ();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox ();
		this.vbox2.Name = "vbox2";
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox ();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox9 = new global::Gtk.VBox ();
		this.vbox9.Name = "vbox9";
		this.vbox9.Spacing = 6;
		// Container child vbox9.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label ();
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString ("IP-адрес");
		this.vbox9.Add (this.label8);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.label8]));
		w1.Position = 0;
		w1.Expand = false;
		// Container child vbox9.Gtk.Box+BoxChild
		this.entryIP = new global::Gtk.Entry ();
		this.entryIP.CanFocus = true;
		this.entryIP.Name = "entryIP";
		this.entryIP.IsEditable = true;
		this.entryIP.InvisibleChar = '●';
		this.vbox9.Add (this.entryIP);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.entryIP]));
		w2.Position = 1;
		// Container child vbox9.Gtk.Box+BoxChild
		this.hseparator1 = new global::Gtk.HSeparator ();
		this.hseparator1.Name = "hseparator1";
		this.vbox9.Add (this.hseparator1);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox9[this.hseparator1]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		this.hbox4.Add (this.vbox9);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox9]));
		w4.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.vbox10 = new global::Gtk.VBox ();
		this.vbox10.Name = "vbox10";
		this.vbox10.Spacing = 6;
		// Container child vbox10.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label ();
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString ("Порт");
		this.vbox10.Add (this.label6);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.label6]));
		w5.Position = 0;
		// Container child vbox10.Gtk.Box+BoxChild
		this.entryPORT = new global::Gtk.Entry ();
		this.entryPORT.CanFocus = true;
		this.entryPORT.Name = "entryPORT";
		this.entryPORT.IsEditable = true;
		this.entryPORT.InvisibleChar = '●';
		this.vbox10.Add (this.entryPORT);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.entryPORT]));
		w6.Position = 1;
		// Container child vbox10.Gtk.Box+BoxChild
		this.hseparator2 = new global::Gtk.HSeparator ();
		this.hseparator2.Name = "hseparator2";
		this.vbox10.Add (this.hseparator2);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox10[this.hseparator2]));
		w7.Position = 2;
		w7.Expand = false;
		w7.Fill = false;
		this.hbox4.Add (this.vbox10);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vbox10]));
		w8.Position = 1;
		this.vbox2.Add (this.hbox4);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox4]));
		w9.Position = 0;
		// Container child vbox2.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox ();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox5 = new global::Gtk.VBox ();
		this.vbox5.Name = "vbox5";
		this.vbox5.Homogeneous = true;
		this.vbox5.Spacing = 6;
		// Container child vbox5.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label ();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("Что делать?");
		this.vbox5.Add (this.label3);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.label3]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.rbQUEUE = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Генерировать заявки на\n        обслуживание"));
		this.rbQUEUE.CanFocus = true;
		this.rbQUEUE.Name = "rbQUEUE";
		this.rbQUEUE.DrawIndicator = true;
		this.rbQUEUE.UseUnderline = true;
		this.rbQUEUE.Group = new global::GLib.SList (global::System.IntPtr.Zero);
		this.vbox5.Add (this.rbQUEUE);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.rbQUEUE]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox5.Gtk.Box+BoxChild
		this.rbCALC = new global::Gtk.RadioButton (global::Mono.Unix.Catalog.GetString ("Рассчитать характеристики СМО\n       по данным параметрам"));
		this.rbCALC.CanFocus = true;
		this.rbCALC.Name = "rbCALC";
		this.rbCALC.DrawIndicator = true;
		this.rbCALC.UseUnderline = true;
		this.rbCALC.Group = this.rbQUEUE.Group;
		this.vbox5.Add (this.rbCALC);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox5[this.rbCALC]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		this.hbox2.Add (this.vbox5);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox5]));
		w13.Position = 0;
		w13.Expand = false;
		w13.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vseparator1 = new global::Gtk.VSeparator ();
		this.vseparator1.Name = "vseparator1";
		this.hbox2.Add (this.vseparator1);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator1]));
		w14.Position = 1;
		w14.Expand = false;
		w14.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox6 = new global::Gtk.VBox ();
		this.vbox6.Name = "vbox6";
		this.vbox6.Spacing = 6;
		// Container child vbox6.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label ();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString ("Количество заявок");
		this.vbox6.Add (this.label4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.label4]));
		w15.Position = 0;
		w15.Expand = false;
		w15.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.entryCOUNT = new global::Gtk.Entry ();
		this.entryCOUNT.CanFocus = true;
		this.entryCOUNT.Name = "entryCOUNT";
		this.entryCOUNT.IsEditable = true;
		this.entryCOUNT.InvisibleChar = '●';
		this.vbox6.Add (this.entryCOUNT);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.entryCOUNT]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		// Container child vbox6.Gtk.Box+BoxChild
		this.vbox3 = new global::Gtk.VBox ();
		this.vbox3.Name = "vbox3";
		this.vbox3.Spacing = 6;
		// Container child vbox3.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label ();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("  Средняя пауза\nмежду заявками");
		this.vbox3.Add (this.label1);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.label1]));
		w17.Position = 0;
		w17.Expand = false;
		w17.Fill = false;
		// Container child vbox3.Gtk.Box+BoxChild
		this.entryDELAY = new global::Gtk.Entry ();
		this.entryDELAY.CanFocus = true;
		this.entryDELAY.Name = "entryDELAY";
		this.entryDELAY.IsEditable = true;
		this.entryDELAY.InvisibleChar = '●';
		this.vbox3.Add (this.entryDELAY);
		global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox3[this.entryDELAY]));
		w18.Position = 1;
		w18.Expand = false;
		w18.Fill = false;
		this.vbox6.Add (this.vbox3);
		global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox6[this.vbox3]));
		w19.PackType = ((global::Gtk.PackType)(1));
		w19.Position = 2;
		w19.Expand = false;
		w19.Fill = false;
		this.hbox2.Add (this.vbox6);
		global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox6]));
		w20.Position = 2;
		w20.Expand = false;
		w20.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vseparator2 = new global::Gtk.VSeparator ();
		this.vseparator2.Name = "vseparator2";
		this.hbox2.Add (this.vseparator2);
		global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vseparator2]));
		w21.Position = 3;
		w21.Expand = false;
		w21.Fill = false;
		// Container child hbox2.Gtk.Box+BoxChild
		this.vbox7 = new global::Gtk.VBox ();
		this.vbox7.Name = "vbox7";
		this.vbox7.Spacing = 6;
		// Container child vbox7.Gtk.Box+BoxChild
		this.vbox4 = new global::Gtk.VBox ();
		this.vbox4.Name = "vbox4";
		this.vbox4.Spacing = 6;
		// Container child vbox4.Gtk.Box+BoxChild
		this.label10 = new global::Gtk.Label ();
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString ("Параметры СМО");
		this.vbox4.Add (this.label10);
		global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.label10]));
		w22.Position = 0;
		w22.Expand = false;
		w22.Fill = false;
		// Container child vbox4.Gtk.Box+BoxChild
		this.hbox1 = new global::Gtk.HBox ();
		this.hbox1.Name = "hbox1";
		this.hbox1.Spacing = 6;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox8 = new global::Gtk.VBox ();
		this.vbox8.Name = "vbox8";
		this.vbox8.Spacing = 6;
		// Container child vbox8.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label ();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Количество\n   каналов");
		this.vbox8.Add (this.label2);
		global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label2]));
		w23.Position = 0;
		// Container child vbox8.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label ();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("Интенсивность\n      потока");
		this.vbox8.Add (this.label5);
		global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label5]));
		w24.Position = 1;
		// Container child vbox8.Gtk.Box+BoxChild
		this.label7 = new global::Gtk.Label ();
		this.label7.Name = "label7";
		this.label7.LabelProp = global::Mono.Unix.Catalog.GetString ("Интенсивность\n обслуживания");
		this.vbox8.Add (this.label7);
		global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label7]));
		w25.Position = 2;
		// Container child vbox8.Gtk.Box+BoxChild
		this.label9 = new global::Gtk.Label ();
		this.label9.Name = "label9";
		this.label9.LabelProp = global::Mono.Unix.Catalog.GetString (" Длина\nочереди");
		this.vbox8.Add (this.label9);
		global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox8[this.label9]));
		w26.Position = 3;
		this.hbox1.Add (this.vbox8);
		global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox8]));
		w27.Position = 0;
		w27.Expand = false;
		w27.Fill = false;
		// Container child hbox1.Gtk.Box+BoxChild
		this.vbox11 = new global::Gtk.VBox ();
		this.vbox11.Name = "vbox11";
		this.vbox11.Spacing = 6;
		// Container child vbox11.Gtk.Box+BoxChild
		this.entryN = new global::Gtk.Entry ();
		this.entryN.CanFocus = true;
		this.entryN.Name = "entryN";
		this.entryN.IsEditable = true;
		this.entryN.InvisibleChar = '●';
		this.vbox11.Add (this.entryN);
		global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.entryN]));
		w28.Position = 0;
		// Container child vbox11.Gtk.Box+BoxChild
		this.entryLAMBDA = new global::Gtk.Entry ();
		this.entryLAMBDA.CanFocus = true;
		this.entryLAMBDA.Name = "entryLAMBDA";
		this.entryLAMBDA.IsEditable = true;
		this.entryLAMBDA.InvisibleChar = '●';
		this.vbox11.Add (this.entryLAMBDA);
		global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.entryLAMBDA]));
		w29.Position = 1;
		// Container child vbox11.Gtk.Box+BoxChild
		this.entryMU = new global::Gtk.Entry ();
		this.entryMU.CanFocus = true;
		this.entryMU.Name = "entryMU";
		this.entryMU.IsEditable = true;
		this.entryMU.InvisibleChar = '●';
		this.vbox11.Add (this.entryMU);
		global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.entryMU]));
		w30.Position = 2;
		// Container child vbox11.Gtk.Box+BoxChild
		this.entryM = new global::Gtk.Entry ();
		this.entryM.CanFocus = true;
		this.entryM.Name = "entryM";
		this.entryM.IsEditable = true;
		this.entryM.InvisibleChar = '●';
		this.vbox11.Add (this.entryM);
		global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox11[this.entryM]));
		w31.Position = 3;
		this.hbox1.Add (this.vbox11);
		global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vbox11]));
		w32.Position = 1;
		this.vbox4.Add (this.hbox1);
		global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox4[this.hbox1]));
		w33.Position = 1;
		w33.Expand = false;
		w33.Fill = false;
		this.vbox7.Add (this.vbox4);
		global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox7[this.vbox4]));
		w34.Position = 0;
		this.hbox2.Add (this.vbox7);
		global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.vbox7]));
		w35.Position = 4;
		w35.Expand = false;
		w35.Fill = false;
		this.vbox2.Add (this.hbox2);
		global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox2]));
		w36.Position = 1;
		w36.Expand = false;
		w36.Fill = false;
		this.vbox1.Add (this.vbox2);
		global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.vbox2]));
		w37.Position = 0;
		w37.Expand = false;
		w37.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.generate = new global::Gtk.Button ();
		this.generate.CanFocus = true;
		this.generate.Name = "generate";
		this.generate.UseUnderline = true;
		this.generate.Label = global::Mono.Unix.Catalog.GetString ("Генерировать заявки");
		this.vbox1.Add (this.generate);
		global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.generate]));
		w38.Position = 1;
		w38.Expand = false;
		w38.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
		this.GtkScrolledWindow.Name = "GtkScrolledWindow";
		this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
		this.Log = new global::Gtk.TextView ();
		this.Log.WidthRequest = 0;
		this.Log.HeightRequest = 200;
		this.Log.Name = "Log";
		this.Log.Editable = false;
		this.Log.CursorVisible = false;
		this.Log.Overwrite = true;
		this.Log.WrapMode = ((global::Gtk.WrapMode)(3));
		this.GtkScrolledWindow.Add (this.Log);
		this.vbox1.Add (this.GtkScrolledWindow);
		global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
		w40.PackType = ((global::Gtk.PackType)(1));
		w40.Position = 2;
		this.Add (this.vbox1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 722;
		this.DefaultHeight = 774;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.generate.Clicked += new global::System.EventHandler (this.RunClient);
	}
}
