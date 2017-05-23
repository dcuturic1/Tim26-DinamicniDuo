﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResidenceInnEnyojYourStay.Models
{
    public abstract class Osoba : Template10.Validation.ValidatableModelBase
    {
        private String ime;
        private String prezime;
        private String email;
        private String user;
        private String password;
        private DateTime datumRodjenja;

        public String Ime
        {
            get
            {
                return Read<string>();
            }
            set
            {
                Write(value);
            }
        }
        public String Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                if (value != prezime)
                {
                    prezime = value;
                   // OnPropertyChanged("Prezime");
                }
            }
        }
        public String Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value != email)
                {
                    email = value;
                  //  OnPropertyChanged("Email");
                }
            }
        }
        public String User
        {
            get
            {
                return user;
            }
            set
            {
                if (value != user)
                {
                    user = value;
                 //   OnPropertyChanged("User");
                }
            }
        }
        public String Pass
        {
            get
            {
                return password;
            }
            set
            {
                if (value != password)
                {
                    password = value;
                 //   OnPropertyChanged("Pass");
                }
            }
        }
        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                if (value != datumRodjenja)
                {
                    datumRodjenja = value;
                //    OnPropertyChanged("DatumRodjenja");
                }
            }
        }
        public Osoba(string im, string prez, DateTime datR, string us, string pass, string em)
        {
            Ime = im;
            Prezime = prez;
            Email = em;
            User = us;
            Pass = pass;
            DatumRodjenja = datR;
        }
        public Osoba()
        {

        }
    }
}
