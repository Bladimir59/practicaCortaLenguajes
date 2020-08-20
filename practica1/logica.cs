using System.Text.RegularExpressions;

internal class logica
{
    public string[] Dato(string linea)
    {
        // divide la linea em partes con un split ' ' 
        string[] partes = linea.Split(' ');
        for(int i = 0; i < partes.Length; i++)
        {
            //almacena los datos en un vector y los recorre llamando al metodo dividir que se encarga de asiganrle el tokens
            partes[i] = Dividir(partes[i]);
        }
        return partes;
    }


   public string Dividir(string dato)
    {
        //metodo para dividir las expreciones por su identidad
        Regex deci = new Regex("[0-9]\\.[0-9]$");
        Regex numero = new Regex("\\d$");
        Regex palabra = new Regex("[a-zA-Z]{1,254}");
        Regex moneda = new Regex("^Q.[0-9]{2,6}$");
        string compuesto=null;
        //separa y agrega en un string los datos
        if (numero.IsMatch(input: dato))
        {
            compuesto = "Tokens numero: " + dato;
        }
        if (deci.IsMatch(input: dato))
        {
            compuesto = "Tokens decimal: " + dato; 
        }

        else if (palabra.IsMatch(input: dato))
        {
            compuesto = "Tokens palabra: " + dato;
        }
        if (moneda.IsMatch(input: dato))
        {
            compuesto = "Tokens moneda: " + dato;
        }


        return compuesto;
    }
}