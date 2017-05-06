using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace paup_mcp.Models
{
    public class ServisAdmin // model za modul Servis(admin)
    {
        // podaci o klijentu i vozilu

        public string ime { get; set; }
        public string prezime { get; set; }
        public string markaVozila { get; set; }
        public string modelVozila { get; set; }
        public string vrstaMotora { get; set; }
        public int godinaProizvodnje { get; set; }
        public string brojRegistracije { get; set; }


        // podaci o servisu vozila

        public int idServisa { get; set; }
        public DateTime vrijemeServisa { get; set; }
        public string opisPosla { get; set; }
        public double cijena { get; set; }
        public string napomena { get; set; }
        public bool obavljeno { get; set; }
    }
}