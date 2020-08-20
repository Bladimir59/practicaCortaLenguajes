using System.Text.RegularExpressions;

internal class logica
{
    public string[] Dato(string linea)
    {
        string[] partes = linea.Split(' ');
        for(int i = 0; i < partes.Length; i++)
        {

            partes[i] = Dividir(partes[i]);
        }
        return partes;
    }


   public string Dividir(string dato)
    {
        Regex deci = new Regex("[0-9].[0-9]");
        Regex numero = new Regex("[0-9]");
        Regex palabra = new Regex("[a-zA-Z]");
        Regex moneda = new Regex("[Q.0-9]");
        string compuesto=null;
        if (deci.IsMatch(input: dato))
        {
            compuesto = "decimal " + dato;
            
        }else if (moneda.IsMatch(input: dato))
        {
            compuesto = "moneda " + dato;
        }
        else if (palabra.IsMatch(input: dato))
        {
            compuesto = "palabra " + dato;
        }
        else if (numero.IsMatch(input: dato))
        {
            compuesto = "numero " + dato;
        }
        return compuesto;
    }
}