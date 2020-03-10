using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lahjakorttiappi.Class
{
    public class pdfInfoclass
    {
        int asiakasNro;
        public int CustomerNumber
        {
            get { return asiakasNro; }
            set { asiakasNro = value; }
        }
        string exdate;

        string service;
        public string Service
        {
            get { return service; }
            set { service = value; }
        }
        public string ExDate
        {
            get { return exdate; }
            set { exdate = value; }
        }

        string duration;
        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        string amount;
        public string Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        string etunimi;
        public string Firstname
        {
            get { return etunimi; }
            set { etunimi = value; }
        }

        string sukunimi;
        public string Lastname
        {
            get { return sukunimi; }
            set { sukunimi = value; }
        }

        string osoite;
        public string Adress
        {
            get { return osoite; }
            set { osoite = value; }
        }

        string puhNro;
        public string Phone
        {
            get { return puhNro; }
            set { puhNro = value; }
        }


        string postinumero;
        public string Pin
        {
            get { return postinumero; }
            set { postinumero = value; }
        }

        string paikka;
        public string PostalPlace
        {
            get { return paikka; }
            set { paikka = value; }
        }

    
        int lahjakorttiID;
        public int LahjakorttiID
        {
            get { return lahjakorttiID; }
            set { lahjakorttiID = value; }
        }

        string myyjaID;
        public string Seller
        {
            get { return myyjaID; }
            set { myyjaID = value; }
        }

    }
}
