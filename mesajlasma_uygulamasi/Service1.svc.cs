using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace mesajlasma_uygulamasi
{
    // NOT: "Service1" sınıf adını kodda, svc'de ve yapılandırma dosyasında birlikte değiştirmek için "Yeniden Düzenle" menüsündeki "Yeniden Adlandır" komutunu kullanabilirsiniz.
    // NOT: Bu hizmeti test etmek üzere WCF Test İstemcisi'ni başlatmak için lütfen Çözüm Gezgini'nde Service1.svc'yi veya Service1.svc.cs'yi seçin ve hata ayıklamaya başlayın.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]


    public class Service1 : IService1
    {
        string mesajlar = "";

        public string MesajEkIe(string value)
        {
            mesajlar += value + "\n";
            return mesajlar;
        }

        public string MesajGetir()
        {
            return mesajlar;
        }

        public void MesajlarıSil()
        {
            mesajlar = "";
        }

    }
}
