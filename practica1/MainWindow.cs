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

    protected void OnButton1Clicked(object sender, EventArgs e)
    {

        string texto = entry4.Text;
        logica ir = new logica();
        String[] lineas= ir.Dato(texto);
        for (int i=0; i <lineas.Length; i++)
        {
            Console.WriteLine(lineas[i]);

            textview4.Text=lineas[i];
        }
        
    }

}
