using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodu
{
    public abstract class Factory
    {
        
        public abstract string ArabaModel();

    }
    //hız 
    public class Lamborcini : Factory
    {
        public override string ArabaModel()
        {
            return "Lamborcini Veneno";
        }
        public int hız = 354;
        public string fiyat ="4 milyon dolar";

    }
    // Dayanıklılık 
    public class Volvo : Factory
    {
        public override string ArabaModel()
        {
            return "Volvo XC60";
        }
        public string dayanıklık = "Yetişkin yolcu: %98 Çocuk yolcu: %87 Yaya: %76 Güvenlik yardımcısı: %95";



    }
    //yanlama
    public class Tofas : Factory
    {
        public override string ArabaModel()
        {
            return "Tofaş";
        }
       public string özelikler = "özelikler=bu kullanımı ile ölüm,kaza ve bela gibisinden şeyler getirir";

    }
    //yakıt tüketimi
    public class Renault : Factory
    {
        public override string ArabaModel()
        {
            return "Renault";
        }
        public string yakıttüketimi = " yakıttüketimi = 3,6 lt/100 km başına";


    }






}
