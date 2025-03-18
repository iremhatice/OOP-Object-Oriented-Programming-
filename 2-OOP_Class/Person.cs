using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2_OOP_Class
{
    // Class,nesneleri oluşturmak için kullanılan şablonlardır. Sınıflar, nesnelerin sahip olacağı özellikler ve davranışlar için bir yapı sunar.
    // Nesne ise bir sınıfın örneğidir (instance).Her nesne, sınıfında tanımlanan özellikleri (veriler) ve metodları (işlemler) taşır.
    // Ozellikler(Attributes) : Nesnenin durumunu veya verisini temsil eder.
    // Metodlar (Methods): Nesneyle yapılan işlemleri ifade eder.

    public class Person
    {
        //Fields(Alanlar): Içeride kullanılacak olan değişkenlerdir. Nesnenin verilerini depolamak için kullanılır. Bu alanlar sınıfın içinde tanımlanır ve nesne oluşturulduğunda bu alanlar her bir nesne örneği için ayrı ayrı tutulur. Yalnızca sınıfın içinde kullanılan bilgiler içerebilir.

        private string _name; //Field: nesnenin alanlari
        private int _age;
        private string _surName;
        private string _salary;

        //Properties: Değişkeni kontrol edilebilir hale getirebilmek. Alanlara erişimi yönetmek ve gerekli işlemleri yapmak için kullanılır.Properties, sınıfın verilerine (alanlarına) erişimi kontrol etmek ve yönlendirmek için kullanılan bir mekanizmadır.Properties, bir alanın değerini okumak(get işlemi) veya ayarlamak(set işlemi) için kullanılır.
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age
        {
            get // Okuma
            {
                // Atanmis bir degeri okuyabilmek icin kullanilan metottur. Geriye ilgili property tipinde deger dondurur.
                return _age;
            }
            set // Yazma
            {
                // Atama islemi esnasinda kullanilan metottur. Yani esittir ifadesini koyup bir deger verdiginizde set calisir.
                // Value: Default parametredir ilgili ozel tipine burunur ve disaridan set edilmeye calisan degeri yakalar.
                if (value < 100)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Kullanıcı yaşı 100den büyük olamaz.");
                }
            }
        }

        public string Surname { get; set; } 
        private double Salary {  get; set; }    

    }
}
