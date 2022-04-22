/*
    Como los tests estan referenciando a la libreria, el codigo quedo duplicado

*/
// Escribir una función que recibe una cadena de caracteres como parámetro con una fecha de la forma
// “dd/mm/aaaa” y devuelve la fecha en formato “aaaa­‐mm­‐dd”.
// Ej.: 10/11/1977 -> 1977­‐11­‐10
//
// La función para cambiar el forma de la fecha está implementada en el método de clase ChangeFormat de la
// clase Program. Ese método se invoca desde el método de clase Main de la clase Program que es el punto de
// entrada del programa.
using System;

namespace DateFormat
{
    public class Program
    {
            public static String ChangeFormat(String year)
            {
                return year.Substring(6) + "-" + year.Substring(3, 2) + "-" + year.Substring(0, 2);
            }

            public static String ChangeFormat2(String year, String format)
            {
                if (year == "")
                {
                    return "";
                }
                string[] date = year.Split("/");
                string changeDay = date[0];
                string changeMonth = date[1];
                string changeYear = date[2];
                if (format == "DD-MM-YYYY")
                {
                    date[0] = changeDay;
                    date[1] = changeMonth;
                    date[2] = changeYear;
                }
                else if ((format == "DD-YYYY-MM"))
                {
                    date[0] = changeDay;
                    date[2] = changeMonth;
                    date[1] = changeYear;
                }
                else if (format == "MM-DD-YYYY")
                {
                    date[1] = changeDay;
                    date[0] = changeMonth;
                    date[2] = changeYear;
                }
                else if (format == "MM-YYYY-DD")
                {
                    date[2] = changeDay;
                    date[0] = changeMonth;
                    date[1] = changeYear;
                }
                else if (format == "YYYY-DD-MM")
                {
                    date[1] = changeDay;
                    date[2] = changeMonth;
                    date[0] = changeYear;
                }
                else if (format == "YYYY-MM-DD")
                {
                    date[2] = changeDay;
                    date[1] = changeMonth;
                    date[0] = changeYear;
                }
                string result = date[0] + "-" + date[1] + "-" + date[2];
                return result;
            }

            public static void Main(string[] args)
            {
                //string testDate = "10/11/1977";
                //Console.WriteLine("{0} se convierte a: {1} ", testDate, ChangeFormat(testDate));
                string? testDate2 = Console.ReadLine();
                string? format = Console.ReadLine();
                if ((testDate2 != null) && (format != null))
                {
                    Console.WriteLine("{0} se convierte a: {1}", testDate2, ChangeFormat2(testDate2, format));
                }
            }
    }
}