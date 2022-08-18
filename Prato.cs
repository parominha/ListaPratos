using System;
using System.Collections.Generic;
using System.Text;

namespace ListaPratos
{
    public class Prato
    {
        public Prato() { }
        public string NomePrato { get; set; }
        public string Ingredientes { get; set; }
        public string DescricaoPrato { get; set; }
        public string UrlFoto { get; set; }
        public string TempoPreparo { get; set; }

        public Prato(string nomeprato, string ingredientes, string descricaoprato, string urlfoto, string tempopreparo)
        {
            this.NomePrato = nomeprato;
            this.Ingredientes = ingredientes;
            this.DescricaoPrato = descricaoprato;
            this.UrlFoto = urlfoto;
            this.TempoPreparo = tempopreparo;
        }

    }
}
