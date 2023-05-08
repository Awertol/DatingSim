using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingSim
{
    public class Scena
    {
        public Dictionary<string, int> Dialogy = new Dictionary<string, int>();
        public string Otazka { get; set; }
        public Dictionary<string, int> Odpovedi = new Dictionary<string, int>();
    }
    public static class Sceny
    {
        public static Scena[] Pole {get; set;}
        public static void NactiText(string cesta)
        {
            string obsahTxt = File.ReadAllText(cesta);
            string[] rozdeleny = obsahTxt.Split(";");
            Scena scena = new Scena();
            foreach(string roz in rozdeleny)
            {
                if (roz.Contains("ˇ"))
                {
                    string[] rozdelenyVetaKdo = roz.Split("ˇ");
                    string veta = rozdelenyVetaKdo[0];
                    string kdo = rozdelenyVetaKdo[1];
                    int kdoCislo = Convert.ToInt32(kdo);
                    scena.Dialogy.Add(veta, kdoCislo);
                }
                else
                {
                    string[] rozdelenyOtaOdp = roz.Split("%");
                    string ota = rozdelenyOtaOdp[0];
                    scena.Otazka = ota;
                    rozdelenyOtaOdp = rozdelenyOtaOdp.Skip(1).ToArray();
                    foreach(string vec in rozdelenyOtaOdp)
                    {
                        string[] rozd = vec.Split("£");
                        scena.Odpovedi.Add(rozd[0], Convert.ToInt32(rozd[1]));
                    }
                }
            }
            Pole.Append(scena);

        }
    }
}
