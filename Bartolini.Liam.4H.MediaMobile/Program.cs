using System;
using System.IO;
using Bartolini.Liam._4H.MediaMobile.Models;

namespace Bartolini.Liam._4H.MediaMobile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"dati.txt";

            Console.WriteLine("Media Mobile, Liam Bartolini 4H");

            //dichiaro un array di Oggetti 
            Campione[] array = new Campione[10];
            
            //lo istanzio
            for(int i = 0; i < array.Length; i++)
                array[i] = new Campione();

            StreamReader sr = new StreamReader(path);

            //prendo la data
            string riga = sr.ReadLine();
            string[] data = riga.Split(' ');

            //prendo la temperatura
            riga = sr.ReadLine();
            string[] temp = riga.Split(' ');

            //prendo la umidita
            riga = sr.ReadLine();
            string[] umidita = riga.Split(' ');

            //prendo la pressione
            riga = sr.ReadLine();
            string[] pressione = riga.Split(' ');

            sr.Close();

            //popolazione vettore
            for(int i = 0; i < data.Length; i++)
            {
                array[i].Data = data[i];
                array[i].Temperatura = Convert.ToDouble(temp[i]);
                array[i].Umidita = Convert.ToDouble(umidita[i]);
                array[i].Pressione= Convert.ToInt32(pressione[i]);
            }


            Console.WriteLine(array[0].MediaMobile3(array[1], array[2]));
            Console.WriteLine(array[0].MediaMobile4(array[1], array[2], array[3]));
            Console.WriteLine(array[0].MediaMobile5(array[1], array[2], array[3], array[4]));

        }
    }
}