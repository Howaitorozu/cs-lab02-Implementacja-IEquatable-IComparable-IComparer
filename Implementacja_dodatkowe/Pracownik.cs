using javax.xml.crypto;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Implementacja_dodatkowe
{




    class Pracownik : IEquatable<Pracownik>
    {
        public string nazwisko;
        public DateTime dataZatrudnienia;
        public decimal wynagrodzenie;
        public string Nazwisko {
            get { return nazwisko; }
            set
            {
                nazwisko = value.Trim();
            }       
        }
        public DateTime DataZatrudnienia
        {
            get
            {
                return dataZatrudnienia;
            }
            set
            {
                if (DataZatrudnienia > DateTime.Now)
                {
                    throw new ArgumentException();
                    
                }
                dataZatrudnienia = value;
                
            }
        }
        public int CzasZatrudnienia => (DateTime.Now - DataZatrudnienia).Days / 30;
        //int czasZatrudnienia;
        //public int CzasZatrudnienia
        //{
        //    get { return czasZatrudnienia; }
        //    set
        //    { 
        //        DateTime teraz = DateTime.Today;
        //        DataZatrudnienia = DataZatrudnienia;
        //        int mineloDni = teraz.Day - DataZatrudnienia.Day;
        //        czasZatrudnienia = mineloDni/30;
        //    }
        //}
        public decimal Wynagrodzenie {
            get { return wynagrodzenie; }
            set 
            {
                if (Wynagrodzenie < 0)
                {
                    Wynagrodzenie = 0;
                }

                wynagrodzenie = value;
            }
        }

        public override string ToString()
        {
            return $"({Nazwisko},{DataZatrudnienia:d MMM yyyy} ({CzasZatrudnienia}),{Wynagrodzenie} PLN)";
        }

        public Pracownik()
        {
            Nazwisko = "Anonim";
            DataZatrudnienia = DateTime.Now;
            Wynagrodzenie = 0m;
        }

        public Pracownik(string nazwisko, DateTime dataZatrudnienia, decimal wynagrodzenie)
        {
            Nazwisko = nazwisko;
            DataZatrudnienia = dataZatrudnienia;
            Wynagrodzenie = wynagrodzenie;
        }
       
     
        public override bool Equals(object obj)
        {
            if ((Nazwisko == ((Pracownik)obj).Nazwisko) && (DataZatrudnienia ==((Pracownik)obj).DataZatrudnienia) && (Wynagrodzenie == ((Pracownik)obj).Wynagrodzenie))
            {
                return true;
            }return false;
        }
        public bool Equals(Pracownik other)
        {
            if (other is null) return false;
            if (Object.ReferenceEquals(this, other)) //other i this są referencjami do tego samego obiektu
                return true;

            return (Nazwisko == other.Nazwisko &&
                    DataZatrudnienia == other.DataZatrudnienia &&
                    Wynagrodzenie == other.Wynagrodzenie);
        }
        public override int GetHashCode() => (Nazwisko, DataZatrudnienia, Wynagrodzenie).GetHashCode();

        public static bool Equals(Pracownik p1, Pracownik p2)
        {
            return Equals(p1, p2);

        }
        public static bool operator ==(Pracownik p1, Pracownik p2)
        {
            if (ReferenceEquals(p1, null))
            {
                return ReferenceEquals(p2, null);
            }
            return ReferenceEquals(p1, null);
        }
        public static bool operator !=(Pracownik p1, Pracownik p2)
        {
            return !(p1 == p2);
        }
    }

}
