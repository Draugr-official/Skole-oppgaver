/* 
 Databases:
    Elever->
        ElevID - PRIMÆR
        Fornavn
        Etternavn
        Klasse
        Hobby
        Kjønn

    Datamaskiner->
        Navn
        Type
        Ytelse
 */

using System;

namespace Databaseoppgave8_31_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlClient sqlClient = new SqlClient("localhost", "winDB", "8asd80da0das089sad098dsa98ads", "elever");

            Console.WriteLine("Jenter i alle klassene");
            PresentTable(sqlClient.Query("SELECT * FROM ELEV WHERE Kjonn='J'"));

            Console.WriteLine("Gutter i klasse 2");
            PresentTable(sqlClient.Query("SELECT * FROM ELEV WHERE Kjonn='G' AND Klasse='2'"));

            Console.WriteLine("Jenter i klasse 2");
            Console.WriteLine($"Det er {sqlClient.Query("SELECT * FROM ELEV WHERE Kjonn='J' AND Klasse='2'").Length} jenter i klasse 2");

            Console.WriteLine("Elever med fornavn som starter på J");
            PresentTable(sqlClient.Query("SELECT Fornavn FROM ELEV WHERE LEFT(Fornavn, 1)='J'"));

            Console.WriteLine("Elever med fornavn som starter på M og går i klasse 2");
            PresentTable(sqlClient.Query("SELECT Fornavn,Klasse FROM ELEV WHERE LEFT(Fornavn, 1)='M' AND Klasse='2'"));

            sqlClient.Query("UPDATE ELEV SET Datamaskin=''");
        }

        static void PresentTable(string[][] table)
        {
            foreach(string[] row in table)
            {
                Console.WriteLine(string.Join(',', row));
            }
        }
    }
}
