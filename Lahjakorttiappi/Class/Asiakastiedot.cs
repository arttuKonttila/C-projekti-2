using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahjakorttiappi.Class
{
    class Asiakastiedot
    {
        int asiakasNro;
        int AsiakasNro
        {
            get { return asiakasNro; }
            set { asiakasNro = value; }
        }

        string etunimi;
        string Etunimi
        {
            get { return etunimi; }
            set { etunimi = value; }
        }

        string sukunimi;
        string Sukunimi
        {
            get { return sukunimi; }
            set { sukunimi = value; }
        }

        string osoite;
        string Osoite
        {
            get { return osoite; }
            set { osoite = value; }
        }

        string puhNro;
        string PuhNro
        {
            get { return puhNro; }
            set { puhNro = value; }
        }

        string sahkoposti;
        string Sahkoposti
        {
            get { return sahkoposti; }
            set { sahkoposti = value; }
        }

        int postinumeroID;
        int PostinumeroID
        {
            get { return postinumeroID; }
            set { postinumeroID = value; }
        }

        int paikkaID;
        int PaikkaID
        {
            get { return paikkaID; }
            set { paikkaID = value; }
        }

        int palveluID;
        int PalveluID
        {
            get { return palveluID; }
            set { palveluID = value; }
        }

        int tilausID;
        int TilausID
        {
            get { return tilausID; }
            set { tilausID = value; }
        }
    }
}
