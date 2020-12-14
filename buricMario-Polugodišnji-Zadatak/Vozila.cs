using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buricMario_Polugodišnji_Zadatak
{
    class Vozila
    {
        string marka;
        string model;
        int godiste;
        

        public string Marka { get => marka; set => marka = value; }
        public string Model { get => model; set => model = value; }
        public int Godiste { get => godiste; set => godiste = value; }
        public static int Count { get; internal set; }

        public Vozila(string marka, string model, int godiste)
        {
            this.marka = marka;
            this.model = model;
            this.godiste = godiste;
            
        }
    }
}
