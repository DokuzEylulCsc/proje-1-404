using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Kelime : Oyuncu
    {
        public Kelime(string zorlukDerecesi,string[] tahmini) :base(zorlukDerecesi,tahmini)
        {
          
        }

      public static  string [] kolayKelime= 
            { "vücut", "böcek","edebiyat","kırmızı","mavi","merhaba","bırak","medeniyet","eski","ait",
              "ayak","su","insan","hayvan","ara","iç","diğer","taraf","mesuliyet","kitap",
              "kork","diş","çöp","kuş","bulmak","gel","git","yol","ev","inek",
              "meyve","göz","sal","masa","kapı","kalem","saat","aç","lamba","takvim",
              "pil","çanta","gazete","cam","araba","kelebek","yaprak","kağıt","dağ","gölge",
                              };

       public static string [] ortaKelime = {
            "kalemlik","taşlık","Türkçe","yurttaş","simitçi","giyim","silgi","evli","yolculuk","sorular",
            "örtüler","çalışma","öğrenci","düzenli","yazılı","anlatım","geliştirme","ışık","açı","çarpı",
            "uyku","çevrim","kardeş","meslektaş","çalışkan","görevli","şarkıcı","soygun","sessizlik","kulaklık",
            "sevgi","saygı","fırıncı","gözlük","tuzlu","naneli","bilgin","sorgu","bilgisiz","sulak",
            "kamuflaj","bozacı","belalı","kitaplık","güneşli","tutsak","kanamak","geleneksel","benimsemek","garipsemek",
        };

       public static string [] zorKelime =  {
            "atatürk","suçüstü","gökkuşağı","denizaltı","ateşböceği","hanımeli","akdeniz","acıgöl","eskişehir","bilgisayar",
            "gecekondu","ateşkes","çekyat","dedikodu","biçerdöver","kapkaç","çanakkale","şanlıurfa","cumartesi","balkabağı",
            "kafatası","başvuru","kahvaltı","kazandibi","ayakkabı","demirbaş","aslanağzı","sütlaç","pazartesi","başrol",
            "karadeniz","dershane","kahvehane","kanunname","alabalık","yanardöner","uyurgezer","kaynana","alabalık","beyefendi",
            "emretmek","karmakarışık","bahşetmek","kuşburnu","defetmek","azledilmek","hissetmek","hükmetmek","altıparmak","kütüphane",
        };
        

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
