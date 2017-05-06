using System;
using System.Collections.Generic;

namespace paup_mcp.Models
{
    public class ServisiDB
    {
        // lista Servisa kreirana samo za pomoć u izradi ostatka projekta
        // privremena baza dok se ne kreira prava SQL baza

        private List<ServisAdmin> listaServisa = new List<ServisAdmin>();

        public ServisiDB()
        {
            // dodavanje izmišljenih klijenata i vozila

            listaServisa.Add(new ServisAdmin
            {

                ime = "Ivan", // ime klijenta
                prezime = "Horvat", // prezime klijenta
                markaVozila = "Citroen", // marka vozila
                modelVozila = "Saxo", // model vozila
                vrstaMotora = "1,6", // vrsta motora
                godinaProizvodnje = 1998, // godina proizvodnje
                brojRegistracije = "VŽ333RR" // broj registracije

            });

            listaServisa.Add(new ServisAdmin
            {

                ime = "Ivan",  // ime klijenta
                prezime = "Horvat", // prezime klijenta
                markaVozila = "Peugeot", // marka vozila
                modelVozila = "206", // model vozila
                vrstaMotora = "1,2", // vrsta motora
                godinaProizvodnje = 2001, // godina proizvodnje
                brojRegistracije = "VŽ222PP" // broj registracije

            });

            listaServisa.Add(new ServisAdmin
            {

                ime = "Ivan", // ime klijenta
                prezime = "Perić", // prezime klijenta
                markaVozila = "Renault", // marka vozila
                modelVozila = "Megane", // model vozila
                vrstaMotora = "1,8", // vrsta motora
                godinaProizvodnje = 1996, // godina proizvodnje
                brojRegistracije = "ČK434PS" // broj registracije

            });


            // dodavanje izmišljenih servisa

            listaServisa.Add(new ServisAdmin
            {

                idServisa = 1,
                vrijemeServisa = new DateTime(2017, 4, 10, 9, 30, 25), // proizvoljno vrijeme servisa
                opisPosla = "Promjena ulja u kočnicama.", // proizvoljan naziv popravka
                cijena = 199.99, // proizvolja cijena
                napomena = "Korišteno Castrol ulje za kočnice.", // proizvoljna napomena
                obavljeno = true // posao označen kao kompletno obavljen

            });

            listaServisa.Add(new ServisAdmin
            {

                idServisa = 2,
                vrijemeServisa = new DateTime(2017, 4, 12, 11, 2, 37), // proizvoljno vrijeme servisa
                opisPosla = "Zamjena filtera zraka.", // proizvoljan naziv popravka
                cijena = 250.00, // proizvolja cijena
                napomena = "Originalni (ne zamjenski) filter zraka.", // proizvoljna napomena
                obavljeno = true // posao označen kao kompletno obavljen

            });

            listaServisa.Add(new ServisAdmin
            {

                idServisa = 3,
                vrijemeServisa = new DateTime(2017, 4, 13, 14, 50, 3), // proizvoljno vrijeme servisa
                opisPosla = "Brušenje cilindra.", // proizvoljan naziv popravka
                cijena = 799.99, // proizvolja cijena
                napomena = "Posao nije dovršen radi završetka radnog vremena.", // proizvoljna napomena
                obavljeno = false // posao označen kao neobavljen kompletno

            });
        }

        public List<ServisAdmin> VratiServise()
        {
            return listaServisa;
        }
    }
}