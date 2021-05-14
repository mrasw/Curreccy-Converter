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

    protected void click(object sender, EventArgs e)
    {
        int nilai = int.Parse(entry2.Text);
        double convert;


        //rupee
        if (from1.ActiveText == "Rupee(India)" && to.ActiveText == "Ringgit(Malaysia)")
        {
            convert = nilai * 0.056;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Rupee(India)" && to.ActiveText == "Singapura Dollar(Singapura)")
        {
            convert = nilai * 0.018;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Rupee(India)" && to.ActiveText == "U.S Dollar(Amerika)")
        {
            convert = nilai * 0.014;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Rupee(India)" && to.ActiveText == "Rupiah(Indonesia)")
        {
            convert = nilai * 195.19;
            converted.Text = convert.ToString();
        }
        //Rupee(India)
        //Rupiah(Indonesia)
        //Ringgit(Malaysia)
        //U.S Dollar(Amerika)
        //Singapura Dollar(Singapura)

        //rupiah
        if (from1.ActiveText == "Rupiah(Indonesia)" && to.ActiveText == "Rupee(India)")
        {
            convert = nilai * 0.0051;
        }
        if (from1.ActiveText == "Rupiah(Indonesia)" && to.ActiveText == "U.S Dollar(Amerika)")
        {
            convert = nilai * 0.000070;
        }
        if (from1.ActiveText == "Rupiah(Indonesia)" && to.ActiveText == "Singapura Dollar(Singapura)")
        {
            convert = nilai * 0.000094;
        }
        if (from1.ActiveText == "Rupiah(Indonesia)" && to.ActiveText == "Ringgit(Malaysia)")
        {
            convert = nilai * 0.00029;
        }
        //Rupee(India)
        //Rupiah(Indonesia)
        //Ringgit(Malaysia)
        //U.S Dollar(Amerika)
        //Singapura Dollar(Singapura)

        //ringgit
        if (from1.ActiveText == "Ringgit(Malaysia)" && to.ActiveText == "Rupee(India)")
        {
            convert = nilai * 17.79;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Ringgit(Malaysia)" && to.ActiveText == "Rupiah(Indonesia)")
        {
            convert = nilai * 3441.43;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Ringgit(Malaysia)" && to.ActiveText == "Singapura Dollar(Singapura)")
        {
            convert = nilai * 0.32;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Ringgit(Malaysia)" && to.ActiveText == "U.S Dollar(Amerika)")
        {
            convert = nilai * 0.24;
            converted.Text = convert.ToString();
        }
        //Rupee(India)
        //Rupiah(Indonesia)
        //Ringgit(Malaysia)
        //U.S Dollar(Amerika)
        //Singapura Dollar(Singapura)

        //dollar
        if (from1.ActiveText == "U.S Dollar(Amerika)" && to.ActiveText == "Rupee(India)")
        {
            convert = nilai * 73.26;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "U.S Dollar(Amerika)" && to.ActiveText == "Rupiah(Indonesia)")
        {
            convert = nilai * 14306.25;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "U.S Dollar(Amerika)" && to.ActiveText == "Ringgit(Malaysia)")
        {
            convert = nilai * 4.13;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "U.S Dollar(Amerika)" && to.ActiveText == "Singapura Dollar(Singapura)")
        {
            convert = nilai * 1.33;
            converted.Text = convert.ToString();
        }
        //Rupee(India)
        //Rupiah(Indonesia)
        //Ringgit(Malaysia)
        //U.S Dollar(Amerika)
        //Singapura Dollar(Singapura)

        //dollarsing
        if (from1.ActiveText == "Singapura Dollar(Singapura)" && to.ActiveText == "Rupee(India)")
        {
            convert = nilai * 54.96;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Singapura Dollar(Singapura)" && to.ActiveText == "Rupiah(Indonesia)")
        {
            convert = nilai * 10732.93;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Singapura Dollar(Singapura)" && to.ActiveText == "Ringgit(Malaysia)")
        {
            convert = nilai * 3.10;
            converted.Text = convert.ToString();
        }
        if (from1.ActiveText == "Singapura Dollar(Singapura)" && to.ActiveText == "U.S Dollar(Amerika)")
        {
            convert = nilai * 0.75;
            converted.Text = convert.ToString();
        }

    }
}