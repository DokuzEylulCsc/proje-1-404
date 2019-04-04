using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Kelime : Oyuncu
    {
        public Kelime(string zorlukD,string tahmini) :base(zorlukDerecesi,tahmini)
        {
            zorlukD = zorlukderecesi;
            tahmini = tahmin;
        }

      public static  string [] kolayKelime= { "çiçek", "böcek","edebiyat","kırmızı","mavi","merhaba","bırak","medeniyet","eski","ait",
                                "ayak","su","insan","hayvan","ara","iç","diğer","taraf","mesuliyet","kitap",
                                "kork","diş","geldi","kuş","bulmak","gel","git","yol","ev","el",
                                "meyve","göz","sal","masa","kapı","kalem","saat","aç","lamba","takvim",
                                "pil","çanta","gazete","cam","araba","kelebek","yaprak","kağıt","dağ","gölge",
                              };

       public static string [] ortaKelime = {
            "kalemlik","taşlık","Türkçe","yurttaş","simitçi","giyim","silgi","evli","yolculuk","sorular",
            "örtüler","çalışma","öğrenci","düzenli","yazılı","anlatım","geliştirme","ışık","açı","çarpı",
            "uyku","çevrim","kardeş","meslektaş","çalışkan","görevli","şarkıcı","soygun","sessizlik","kulaklık",
            "sevgi","saygı","fırıncı","gözlük","tuzlu","naneli","bilgin","sorgu","bilgisiz","sulak",
            "kamuflaj","Bozacı","Belalı","Kitaplık","","","","","","",
        };

       public static string [] zorKelime =  {
            "Atatürk","Afyonkarahisar","Gökkuşağı","Denizaltı","Ateşböceği","Hanımeli","Akdeniz","Acıgöl","Eskişehir","Bilgisayar",
            "Gecekondu","Ateşkes","Çekyat","Dedikodu","Biçerdöver","Kapkaç","Çanakkale","Şanlıurfa","Cumartesi","Balkabağı",
            "Kafatası","Başvuru","Kahvaltı","Kazandibi","Ayakkabı","Demirbaş","Aslanağzı","Sütlaç","Pazartesi","Başrol",
            "Karadeniz","Dershane","Kahvehane","Kanunname","Alabalık","Yanardöner","Uyurgezer","Kaynana","Alabalık","Beyefendi",
            "Emretmek","Karmakarışık","Bahşetmek","Kuşburnu","Defetmek","Azledilmek","Hissetmek","Hükmetmek","Altıparmak","Kütüphane",
        };
        private static string zorlukDerecesi;

        public static string [] kolayKelimeGonder()
        {
             return kolayKelime; 
         
        }
        public static string [] ortaKelimeGonder()
        {
            return ortaKelime;
        }
        public static string[] zorKelimeGonder()
        {
            return zorKelime;
        }



    }
}
