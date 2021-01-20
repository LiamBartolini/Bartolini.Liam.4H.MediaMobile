using System;
using System.Collections.Generic;
using System.Text;

namespace Bartolini.Liam._4H.MediaMobile.Models
{
    class Campione
    {
        //microgrammi per metro cubo
        string _data;
        double _temperatura;
        double _umidita;
        int _pressione; // ti per milione pbm
        
        public string Data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }

        public double Temperatura
        {
            get
            {
                return _temperatura;
            }

            set
            {
                _temperatura = value; 
            }
        }

        public double Umidita
        {
            get
            {
                return _umidita;
            }
            
            set
            {
                _umidita = value;
            }
        }

        public int Pressione
        {
            get
            {
                return _pressione;
            }
            
            set
            {
                _pressione = value;
            }
        }

        //costruttore di defaults
        public Campione()
        {

        }

        //media mobile con 3 valori
        public string MediaMobile3(Campione c1, Campione c2)
        {
            double mediaT = 0;
            double mediaU = 0;
            double mediaP = 0;

            mediaT = this.mediaTemperature(c1, c2);
            mediaU = this.mediaUmidita(c1, c2);
            mediaP = this.mediaPressione(c1, c2);

            return $"\r\n\tDa {this._data} A {c2._data}: \r\nMedia temperature: {mediaT:n2}\r\nMedia uminidita: {mediaU:n2}\r\nMedia pressione: {mediaP:n2}";
        }

        //media mobile con 4 valori
        public string MediaMobile4(Campione c1, Campione c2, Campione c3)
        {
            double mediaT = 0;
            double mediaU = 0;
            double mediaP = 0;

            mediaT = this.mediaTemperature(c1, c2, c3);
            mediaU = this.mediaUmidita(c1, c2, c3);
            mediaP = this.mediaPressione(c1, c2, c3);

            return $"\r\n\tDa {this._data} A {c3._data}: \r\nMedia temperature: {mediaT:n2}\r\nMedia uminidita: {mediaU:n2}\r\nMedia pressione: {mediaP:n2}";
        }

        //media mobile con 5 valori
        public string MediaMobile5(Campione c1, Campione c2, Campione c3, Campione c4)
        {
            double mediaT = 0;
            double mediaU = 0;
            double mediaP = 0;

            mediaT = this.mediaTemperature(c1, c2, c3, c4);
            mediaU = this.mediaUmidita(c1, c2, c2, c4);
            mediaP = this.mediaPressione(c1, c2, c2, c4);

            return $"\r\n\tDa {this._data} A {c4._data}: \r\nMedia temperature: {mediaT:n2}\r\nMedia uminidita: {mediaU:n2}\r\nMedia pressione: {mediaP:n2}";
        }

        //sfrutto il polimorfismo dei metodi per calcolare le varie medie
        private double mediaTemperature(Campione c1, Campione c2)
        {
            double media = this._temperatura + c1._temperatura + c2._temperatura;
            return media / 3;
        }

        private double mediaTemperature(Campione c1, Campione c2, Campione c3)
        {
            double media = this._temperatura + c1._temperatura + c2._temperatura + c3._temperatura;
            return media / 4;
        }

        private double mediaTemperature(Campione c1, Campione c2, Campione c3, Campione c4)
        {
            double media = this._temperatura + c1._temperatura + c2._temperatura + c3._temperatura + c4._temperatura;
            return media / 5;
        }

        private double mediaUmidita(Campione c1, Campione c2)
        {
            double media = this._umidita + c1._umidita + c2._umidita;
            return media / 3;
        }

        private double mediaUmidita(Campione c1, Campione c2, Campione c3)
        {
            double media = this._umidita + c1._umidita + c2._umidita + c3._umidita;
            return media / 4;
        }

        private double mediaUmidita(Campione c1, Campione c2, Campione c3, Campione c4)
        {
            double media = this._umidita + c1._umidita + c2._umidita + c3._umidita + c4._umidita;
            return media / 5;
        }

        private double mediaPressione(Campione c1, Campione c2)
        {
            double media = this._pressione + c1._pressione + c2._pressione;
            return media / 3;
        }

        private double mediaPressione(Campione c1, Campione c2, Campione c3)
        {
            double media = this._pressione + c1._pressione + c2._pressione + c3._pressione;
            return media / 4;
        }

        private double mediaPressione(Campione c1, Campione c2, Campione c3, Campione c4)
        {
            double media = this._pressione + c1._pressione + c2._pressione + c3._pressione + c4._pressione;
            return media / 5;
        }
    }
}