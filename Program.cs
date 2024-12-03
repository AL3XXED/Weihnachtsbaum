using System.Collections.Generic;
using System.Net;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace Weihnachtsbaum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stufe1:
            //
            //Programmiere die Ausgabe eines Weinachtsbaum im ASCII Format.
            //Du kannst dir das Aussehen des Baums selber aussuchen
            //Nutze für die Ausgabe Schleifen.
            //
            //Beispiel:
            //       x
            //      xxx
            //     xxxxx
            //    xxxxxxx
            //   xxxxxxxxx
            //  xxxxxxxxxxx
            //      xxx
            //      xxx

            //Stufe 2:
            //
            //Unter dem Baum soll ein zuffäliger weinachtsgruß ausgegeben werden. nutze dafür ein Array
            //Nutze ggf. Farben.

            //Stufe 3: 
            //
            //Alle paar Sekunden soll sich die Gruß nachricht verändern also aktualisiert werden

            //Stufe 4:
            //
            //Lass den Baum Blinken und Funkeln
            //Mach eine Recherche wie man spezifische stellen in der Konsole aktualisiert.

            string[] gruß = { "Frohe Weihnachten und ein glückliches neues Jahr!", "Genieße die besinnliche Zeit im Kreise deiner Lieben!", "Möge dein Herz in dieser festlichen Zeit leuchten!", "Wünsche dir frohe Feiertage und viel Freude!", "Besinnliche Weihnachten und einen guten Rutsch ins neue Jahr!", "Weihnachten ist Liebe – und du bist ein Teil davon!", "Frohes Fest! Mögen deine Wünsche in Erfüllung gehen!", "Wärme, Frieden und Freude – das wünsche ich dir zu Weihnachten!", "Die besten Geschenke sind die, die wir miteinander teilen.", "Frohe Weihnachten! Lass uns die Zeit genießen!" };
            Random zufall = new Random();

            string[] baum = {
    @"                         *",
    @"                        /x\",
    @"                       /* *\",
    @"                      /* x *\",
    @"                     /x * * x\",
    @"                    /* * x * *\",
    @"                   /* x * * x *\",
    @"                  /x * * x * * x\",
    @"                 /* x * * * * x *\",
    @"                /* x * * x * * x *\",
    @"               /* x * x * * x * x *\",
    @"              ***********************",
    @"                        |||"
};
            while (true)
            {
                Console.Clear();
                foreach (string line in baum)
                {
                    foreach (char c in line)
                    {
                            if (c == 'x')
                            {
                                Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
                                Console.Write('x');
                                Console.ResetColor();
                            }
                            else if (c == '*' || c == '/' || c == '\\')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(c);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.Write(c);
                            }
                    }
                    Console.WriteLine();
                }
                int zufallIndex = zufall.Next(gruß.Length);
                string zufallText = gruß[zufallIndex];
                Console.SetCursorPosition(0, baum.Length + 2);
                Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 16);
                Console.WriteLine($"  {zufallText}                                             ");
                Thread.Sleep(1000);
            }
        }
    }
}
