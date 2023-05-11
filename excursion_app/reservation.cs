using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excursion_app
{
    public class Reservation
    {
        private string _fio;
        private int _pasport;
        private string _otkyda;
        private string _kyda;
        private short _people;
        private int _money;


        public string Fio
        {
            get => _fio;
            set
            {
                if (value != null) _fio = value;
                else _fio = "unknown";
            }
        }

        public int Pasport
        {
            get => _pasport;
            set
            {
                 _pasport = value;
            }
        }

        public string Otkyda
        {
            get => _otkyda;
            set
            {
                if (value != null) _otkyda = value;
                else _otkyda = "unknown";
            }
        }

        public string Kyda
        {
            get => _kyda;
            set
            {
                if (value != null) _kyda = value;
                else _kyda = "unknown";
            }
        }

        public short People
        {
            get => _people;
            set
            {
                if (value > 50) _people = 50;
                else _people = value;
            }
        }

        public int Money
        {
            get => _money;
            set
            {
                if (value < _money)
                    _money = _money;
                else _money = value;
            }
        }

        public Reservation(string fio, int pasport,string otkyda,string kyda, short people,int money)
        {
            Fio = fio;
            Pasport = pasport;
            Otkyda = otkyda;
            Kyda = kyda;
            People = people;
            Money = money;
        }

        public override string ToString()
        {
            return new string($"ФИО: {Fio} \n" +
                $"Паспортные данные: {Pasport}\n " +
                $"Исходная точка назначения: {Otkyda} \n" +
                $"Конечная точка назначение: {Kyda}\n" +
                $"Участники тура:  {People}\n" +
                $"Стоимость тура:  {Money}");

        }
    }
}
