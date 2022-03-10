using System;
using Model.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new EFBankContext();
            //foreach (var klant in context.Klanten)
            //    Console.WriteLine(klant.Voornaam);
            //Console.WriteLine(context.Klanten.ToQueryString());

            //var query = from klant in context.Klanten.Include("Rekeningen")
            //            orderby klant.Voornaam
            //            select klant;
            //foreach(var klant in query)
            //{
            //    var totaal = 0m;
            //    Console.WriteLine(klant.Voornaam);
            //    foreach(var rekening in klant.Rekeningen)
            //    {
            //        Console.WriteLine("{0}: {1}", rekening.RekeningNr, rekening.Saldo);
            //        totaal += rekening.Saldo;
            //    }
            //    Console.WriteLine($"Totaal: {totaal}\n");

            //}

            //Oefening 7.6
            //var klanten = from klant in context.Klanten
            //              orderby klant.Voornaam
            //              select klant;
            //foreach (var klant in klanten)
            //    Console.WriteLine($"Naam: {klant.Voornaam}\nKlantnummer: {klant.KlantNr}");
            //Console.Write("Geef een klantnummer in: ");
            //var geldigNummer = int.TryParse(Console.ReadLine(), out int klantnummer);
            //if (!geldigNummer)
            //    Console.WriteLine("Tik een getal");
            //var bestaatHetNummer = context.Klanten.Find(klantnummer);
            //if (bestaatHetNummer != null)
            //{
            //    Console.Write("Geef een nieuw rekeningnummer in: ");
            //    var nieuwRekeningnummer = Console.ReadLine();
            //    Rekening nieuweRekening = new Rekening { KlantNr = klantnummer, RekeningNr = nieuwRekeningnummer, Saldo = 0, Soort = 'Z' };
            //    context.Rekeningen.Add(nieuweRekening);
            //    context.SaveChanges();
            //}
            //else
            //    Console.WriteLine("Klant niet gevonedn");

            //8.5

            //var testnummer = 69;
            //var controle = context.Rekeningen.Find(testnummer.ToString());
            //if (controle != null)
            //{
            //    Console.Write("bedrag?");
            //    if (decimal.TryParse(Console.ReadLine(), out var bedrag))
            //        if (bedrag > 0)
            //        {
            //            controle.Storten(bedrag);
            //            context.SaveChanges();
            //        }
            //        else
            //            Console.WriteLine("Geef een positief bedrag in");
            //}
            //else
            //    Console.WriteLine("rekening niet gevonden");
            Console.Write("geef een klantnummer in zonder rekeningen");
            var klantOmTeVerwijderen = int.TryParse(Console.ReadLine(), out int klantnummer);
            var klant = context.Klanten.Find(klantnummer);
            if (klantOmTeVerwijderen)
            {

                    if (klant.Rekeningen.Count()==0)
                    {
                        context.Klanten.Remove(klant);
                        context.SaveChanges();
                    }
                    else Console.WriteLine("Klant heeft rekeningen");
                
            }
            else Console.WriteLine("ongeldige klantnummer");


        }
    }
}
