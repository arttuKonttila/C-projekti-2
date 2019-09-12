using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahjakorttiappi.Class
{
    public class Asiakastiedot
    {
        int asiakasNro;
        public int AsiakasNro
        {
            get { return asiakasNro; }
            set { asiakasNro = value; }
        }

        string etunimi;
        public string Etunimi
        {
            get { return etunimi; }
            set { etunimi = value; }
        }

        string sukunimi;
        public string Sukunimi
        {
            get { return sukunimi; }
            set { sukunimi = value; }
        }

        string osoite;
        public string Osoite
        {
            get { return osoite; }
            set { osoite = value; }
        }

        string puhNro;
        public string PuhNro
        {
            get { return puhNro; }
            set { puhNro = value; }
        }

        string sahkoposti;
        public string Sahkoposti
        {
            get { return sahkoposti; }
            set { sahkoposti = value; }
        }

        string postinumero;
        public string Postinumero
        {
            get { return postinumero; }
            set { postinumero = value; }
        }

        string paikka;
        public string Paikka
        {
            get { return paikka; }
            set { paikka = value; }
        }

        int palveluID;
        public int PalveluID
        {
            get { return palveluID; }
            set { palveluID = value; }
        }

        int tilausID;
        public int TilausID
        {
            get { return tilausID; }
            set { tilausID = value; }
        }

        int lahjakorttiID;
        public int LahjakorttiID
        {
            get { return lahjakorttiID; }
            set { lahjakorttiID = value; }
        }

       
    }
}
