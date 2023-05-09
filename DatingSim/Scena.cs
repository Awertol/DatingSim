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
        private string _cesta;
        public string Cesta
        {
            get
            {
                return "videa/" + (VyberyUz.Scena+2) + "S"+ VyberyUz.MacekMichal + ".mp4";
            }
            set { _cesta = value; }
        }

        public Dictionary<string, PostavaBody> Odpovedi = new Dictionary<string, PostavaBody>();
    }
    public static class Sceny
    {
        public static Scena[] Pole =
        {
            new Scena{ Cesta="2S", Odpovedi=
                {
                    { "Nejvíc se těším na multimedia, určitě budeme dělat nějakej project na konci a můžeme být spolu ve skupině! Třeba dating simulator!", new PostavaBody{ Postava=1, Body=2 } },
                    { "Já se těším hlavně na hardware, ten fakt miluju!", new PostavaBody{ Postava=1, Body=0 } },
                    { "Tak já hlavně miluju programování, takže hlavně na to, no…", new PostavaBody{ Postava=1, Body=-2 } },
                    { "Stejnej jako tvůj, prográmko, to se budeme moct učit spolu!", new PostavaBody{ Postava=2, Body=2 } },
                    { "Já se těším hlavně na grafiku, určitě pro mě bude jednoduchá!", new PostavaBody{ Postava=2, Body=0 } },
                    { "Tak prográmko fakt nesnáším, nejvíc se těším na sítě, miluju sítě a Linux!", new PostavaBody{ Postava=2, Body=-2 } },
                } 
            },
            new Scena{ Cesta="3S", Odpovedi=
                {
                    { "Nesnáším, když se někdo zbytečně fláká, souhlasím s tebou, práce šlechtí", new PostavaBody{ Postava=2, Body=2 } },
                    { "Nic se nesmí přehánět, Občas je zajít na kafe fajn, ale člověk nesmí kašlat na povinnosti ", new PostavaBody{ Postava=2, Body=0 } },
                    { "To je hodně šprtskej přístup teda, to já radši pochilluju, než hrotit další hodinu…", new PostavaBody{ Postava=2, Body=-2 } },
                    { "Zbytečný šprtání je přes čáru, radši s tebou pofellím venku na dvorku nebo půjdu za školu", new PostavaBody{ Postava=1, Body=2 } },
                    { "Asi tak půl na půl, hrotit věci není úplně pro mě, ale za školu nikdy!", new PostavaBody{ Postava=1, Body=0 } },
                    { "Zevlit s cigárem nebo vůbec nepřijít, to je fakt strašněj přístup, s tím nechci mít nit společnýho. ", new PostavaBody{ Postava=1, Body=-2 } },
                }
            },
            new Scena{ Cesta="4S", Odpovedi=
                {
                    { "Tak to jsme s dvackou dva, taky se mi moc líbíš!", new PostavaBody{ Postava=1, Body=2 } },
                    { "Ty hlášky si příště kdyžtak nech pro sebe, ale můžeme sem zajít někdy společně.", new PostavaBody{ Postava=1, Body=0 } },
                    { "Taak tohle je fakt trapas, horší hlášku snad neznám, nemyslím si, že se vidíme stejně.", new PostavaBody{ Postava=1, Body=-2 } },
                    { "To je od tebe moc hezké, ty máš taky moc krásné oči!", new PostavaBody{ Postava=2, Body=2 } },
                    { "To jsou fakt otřepaný fráze… ale taky jsi mi sympatický!", new PostavaBody{ Postava=2, Body=0 } },
                    { "To jsi vyčetl v knížce otřepaných frází? Je to fakt trapný, nemyslím si, že se vidíme stejně…", new PostavaBody{ Postava=2, Body=-2 } },
                }
            },
            new Scena{ Cesta="5S", Odpovedi=
                {
                    { "Jasně, že je to rande! ", new PostavaBody{ Postava=2, Body=2 } },
                    { "Uvidíme, jestli je to rande.", new PostavaBody{ Postava=2, Body=0 } },
                    { "Určitě to není rande, jenom kamarádská schůzka.", new PostavaBody{ Postava=2, Body=-2 } },
                    { "Jasně, že je to rande!", new PostavaBody{ Postava=1, Body=2 } },
                    { "Uvidíme, jestli je to rande", new PostavaBody{ Postava=1, Body=0 } },
                    { "Určitě to není rande, jenom kamarádská schůzka", new PostavaBody{ Postava=1, Body=-2 } },
                }
            },
            new Scena{ Cesta="6S", Odpovedi=
                {
                    { "Bylo to fakt úžasný! Jeden z mých nových oblíbených filmů!", new PostavaBody{ Postava=2, Body=2 } },
                    { "Šlo to, spíš dobrý než špatný, ale úplně mě to neposadilo na zadek, ale klidně na něj s tebou kouknu znovu.", new PostavaBody{ Postava=2, Body=0 } },
                    { "Tak to byla ta největší kravina co existuje, horší film snad není. Jak se ti to může líbit?", new PostavaBody{ Postava=2, Body=-2 } },
                    { "Bylo to fakt úžasný! Jeden z mých nových oblíbených filmů! ", new PostavaBody{ Postava=1, Body=2 } },
                    { "Šlo to, spíš dobrý než špatný, ale úplně mě to neposadilo na zadek, ale klidně na něj s tebou kouknu znovu", new PostavaBody{ Postava=1, Body=0 } },
                    { "Tak to byla ta největší kravina co existuje, horší film snad není. Jak se ti to může líbit? ", new PostavaBody{ Postava=1, Body=-2 } },
                }
            },
            new Scena{ Cesta="7S", Odpovedi=
                {
                    { "Je mi jedno jak počkáme, hlavně, že počkáme spolu", new PostavaBody{ Postava=2, Body=2 } },
                    { "Já budu pařit candy crush, nevím jak ty haha", new PostavaBody{ Postava=2, Body=0 } },
                    { "No, já si zapálím cigaretu a budu doufat, že ten bus nikdy nepřijede.", new PostavaBody{ Postava=2, Body=-2 } },
                    { "Je mi jedno jak počkáme, hlavně, že počkáme spolu ", new PostavaBody{ Postava=1, Body=2 } },
                    { "Já budu pařit candy crush, nevím jak ty haha ", new PostavaBody{ Postava=1, Body=0 } },
                    { "No, já si zapálím cigaretu a budu doufat, že ten bus nikdy nepřijede. ", new PostavaBody{ Postava=1, Body=-2 } },
                }
            },
        };
        }
    public class PostavaBody
    {
        public int Postava { get; set; }
        public int Body { get; set; }
    }
}

