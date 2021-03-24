using System;
using System.IO;// File Class --> funktion 7,8

namespace preLexicon // Thomas Youssef 2021-02-26 kl 13:00
{
    class Combat //funktion 16
    {
        static Random slump = new Random();
        public string namnen = " ";

        public int Hälsa = slumpGenerator();
        public int Styrka = slumpGenerator();
        public int Tur = slumpGenerator();
        public static int slumpGenerator()
        {
            return slump.Next(1, 9);
        }
    }
    class Program
    {
        static Random slump = new Random();// funktion 16
        static void Main(string[] args)
        {
            string inMatatVal = "";
            while (inMatatVal != "0")
            {
                
                Console.WriteLine(); 
                Console.WriteLine("Välj en funktion");

                Console.WriteLine(" 1: Standardhälsning");
                Console.WriteLine(" 2: Ditt för-, efternamn och ålder?");
                Console.WriteLine(" 3: Skifta till ljus eller mörk bakgrund ");
                Console.WriteLine(" 4: Vad är det för datum idag?");
                Console.WriteLine(" 5: Vilket av två heltal är störst?");
                Console.WriteLine(" 6: Gissta ett tal mellan 1 och 100");
                Console.WriteLine(" 7: Skriv en textrad som sparas till fil i hårddisken");
                Console.WriteLine(" 8: Läs fil från håddisk");
                Console.WriteLine(" 9: Matematik");
                Console.WriteLine("10: Multiplikationstabell 1 till 10");
                Console.WriteLine("11: En slumpArray, sorterad och utskriven"); //ej till array, sort
                Console.WriteLine("12: Är ordet Du matar in ett Palindrom?"); 
                Console.WriteLine("13: Skriv ut tal mellan två inmatningar");
                Console.WriteLine("14: Mata in tal med kommaseparering, utskrift udda/jämnt"); //som 11, sort
                Console.WriteLine("15: Mata in tal med kommaseparering, datorn adderar dom");
                Console.WriteLine("16: Hälsa, styrka och tur på inmatad användare och motståndare"); // Ej påbörjat

                Console.WriteLine(" 0: Avsluta programmet");

                inMatatVal = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                switch (inMatatVal)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Hello World");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Skriv ditt Förnamn");
                        string förnamn = Console.ReadLine();

                        Console.WriteLine("Skriv ditt Efternamn");
                        string efternamn = Console.ReadLine();

                        Console.WriteLine("Skriv din ålder");
                        int ålder = int.Parse(Console.ReadLine());

                        Console.WriteLine("Du heter " + förnamn + "\t" + efternamn + " och är " + ålder + " år");
                        break;

                    case "3":
                        Console.Clear();
                        if (Console.BackgroundColor != ConsoleColor.White)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                        }
                        break;

                    case "4":
                        Console.Clear();
                        string today = DateTime.Today.ToShortDateString();
                        Console.WriteLine(today);
                        break;

                    case "5":
                        Console.Clear();
                        Console.WriteLine("Mata in det första heltalet: ");
                        int tal1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Mata in det andra heltalet: ");
                        int tal2 = int.Parse(Console.ReadLine());

                        if (tal1 > tal2)
                        {
                            Console.WriteLine($"Av de två talen är {tal1} störst");
                        }
                        else if (tal1 == tal2)
                        {
                            Console.WriteLine("Du har matat in två lika stora tal");
                        }
                        else
                        {
                            Console.WriteLine($"Av de två talen är {tal2} störst");
                        }
                        break;

                    case "6":
                        
                        Random slump = new Random();
                        int slumpTal = slump.Next(1, 100);
                        int användarensGissning = 0;
                        int varvtal = 0;

                        while (användarensGissning != slumpTal)
                        {
                            Console.WriteLine("Gissa vilket heltal datorn tänker på: ");
                            användarensGissning = int.Parse(Console.ReadLine());
                            if (användarensGissning > slumpTal)
                            {
                                Console.WriteLine("för högt");
                            }
                            else if (användarensGissning < slumpTal)
                            {
                                Console.WriteLine("för lågt");
                            }
                            varvtal += 1;
                        }
                        Console.WriteLine($"RÄTT, krävdes {varvtal} försök");
                        Console.ReadKey();
                        break;
                  
                    case "7":
                        Console.Clear();
                        string fil = "C:\\Users\\Thomas\\OneDrive\\Dokument\\Sample.txt";
                        Console.WriteLine("Mata in en kort rad som sparas till fil");
                        string rad = Console.ReadLine();
                        File.WriteAllText(fil, rad);
                        break;

                    case "8":
                        Console.Clear();
                        string filer = File.ReadAllText("C:\\Users\\Thomas\\OneDrive\\Dokument\\Sample.txt");
                        Console.WriteLine(filer);
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Skriv in ett decimaltal, använd kommatecken:");
                        double tal = double.Parse(Console.ReadLine());

                        double roten = Math.Sqrt(tal);
                        double upp2 = Math.Pow(tal, 2);
                        double upp10 = Math.Pow(tal, 10);
                        Console.WriteLine();
                        Console.WriteLine($"Roten ur {tal} är {roten}\n{tal}" +
                            $" upphöjt i 2 blir {upp2}\noch {tal} upphöjt i 10 är {upp10}");
                        break;

                    case "10":
                        Console.Clear();
                        for (int första = 1; första < 11; första++)
                        {
                            Console.WriteLine(första + ":ans tabell");

                            for (int andra = 1; andra < 11; andra++)
                            {
                                Console.WriteLine(första + " x " + andra + " = " + första * andra);
                            }
                            Console.WriteLine();
                        }
                        break;

                    case "11":
                        Console.Clear();
                        int storlek = 10;
                        Random randomerare = new Random();
                        int[] arraySlumpa = new int[storlek];
                        for (int i = 0; i < storlek; i++)
                        {
                            arraySlumpa[i] = randomerare.Next(100);
                        }

                        Array.Sort(arraySlumpa);
                        foreach (int value in arraySlumpa)
                        {
                            Console.WriteLine(value);
                        }
                        break;

                    case "12":
                        Console.Clear();
                        Console.WriteLine("Skriv ett ord Palindrom-test");
                        string inmatning = Console.ReadLine();
                        string inmatningSmå = inmatning.ToLower();
                            
                        string bakVändText = framVändText(inmatningSmå);
                        Console.WriteLine();

                            if (inmatningSmå == bakVändText)
                            {
                                Console.WriteLine(inmatning + " är ett Palindrom");
                            }
                            else
                            {
                                Console.WriteLine(inmatning + " är INTE ett Palindrom");
                            }
                        
                        static string framVändText(string text)
                        {
                            string bakVändText = "";

                            for (int i = text.Length - 1; i >= 0; i--)
                            {
                                bakVändText += text[i];
                            }
                            return bakVändText;
                        }
                        break;

                    case "13":
                        Console.Clear();
                        Console.WriteLine("skriv ett heltal");
                        int talFirst = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ett annat heltal");
                        int talSecond = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (talFirst < talSecond)
                        {
                            for (int i = talFirst; i <= talSecond; i++)
                            {
                                Console.Write(i + ", ");
                            }
                        }
                        else if (talFirst > talSecond)
                        {
                            for (int i = talSecond; i < talFirst; i++)
                            {
                                Console.Write(i + ", ");
                            }
                        }

                        else
                        {
                            Console.WriteLine("Fel, du ska skriva två OLIKA tal");
                        }
                        break;

                    case "14":
                        Console.Clear();
                        Console.WriteLine("Skriv in tal med kommaseparering,output med Jämnt/Ojämnt");

                        string inmatningen = Console.ReadLine();
                        string[] komma = inmatningen.Split(',');
                        int[] ints = Array.ConvertAll(komma, int.Parse);
                        Console.WriteLine();

                        for (int i = 0; i < ints.Length; i++)
                        {
                            if (ints[i] % 2 == 0)
                            {   
                                Console.Write(ints[i] + " ");
                            }
                        }
                        Console.WriteLine("<--- Jämna tal");

                        for (int j = 0; j < ints.Length; j++)
                        {
                            if (ints[j] % 2 != 0)
                            {
                                Console.Write(ints[j] + " ");
                            }
                        }
                        Console.WriteLine("<--- Ojämna tal");
                        break;
                                       
                     case "15":
                        Console.Clear();
                        Console.WriteLine("Skriv in tal med kommaseparering, datorn adderar dom");

                         string beräkning = Console.ReadLine();
                         string[] koma = beräkning.Split(',');
                         int summerat = 0;

                        foreach (string siffror in koma)
                        {
                            int adderat = int.Parse(siffror);
                            summerat += adderat;
                        }
                        Console.WriteLine();
                        Console.WriteLine("summan av inmatade tal är: "+summerat);
                        break;

                    case "16":
                        Console.Clear();
                        Combat jag = new Combat();
                        Console.WriteLine("Vem är du?");
                        jag.namnen = Console.ReadLine();

                        //int Hälsa1 = jag.Hälsa;
                        //int Styrka1 = jag.Styrka;
                        //int Tur1 = jag.Tur;
                        Console.WriteLine("Hälsa: "+jag.Hälsa);
                        Console.WriteLine("Styrka: "+jag.Styrka);
                        Console.WriteLine("Tur: "+jag.Tur);

                        Combat motstånd = new Combat();
                        Console.WriteLine("Vem är motståndaren?");
                        motstånd.namnen = Console.ReadLine();

                        //int Hälsa2 = motstånd.Hälsa;
                        //int Styrka2 = motstånd.Styrka;
                        //int Tur2 = motstånd.Tur;
                        Console.WriteLine("Hälsa: " + motstånd.Hälsa);
                        Console.WriteLine("Styrka: " + motstånd.Styrka);
                        Console.WriteLine("Tur: " + motstånd.Tur);
                        break;

                        

                    case "0":
                        Console.WriteLine("Nu är programmet avslutat");
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ.");
                        break;
                }
              
            }
        }
    }
}
