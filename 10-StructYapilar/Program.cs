namespace _10_StructYapilar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Struct: Yapı gereği değer tipli(value) olduğu için ram stack alanında tutulmaktadır.
            * Struct yapılarda boş yapıcı (constructor) tanımlanamaz.Nesne oluşturulmadaığından (value) tipli olduğu için tanımlanamaz. 
            * Eğer yapıcı metot tanımlanacak ise, mutlaka parametre almalıdır. Tanımlanan parametreler yapıcı metot içerisinde atanmalıdır. Atama yapılmamışsa varsayılan değer yüklenmelidir. 
            * Struct yapılarda boş yapıcı metot tanımlanmadığından dolayı new anahtar kelimesi kullanılamaz diye bir kavram yoktur. Buradaki new nesne oluşturmak için değil varsayılan değerleri yüklemek içindir.
            * ENCAPSULATION,POLYMORPHISM,INHERITANCE kavramları geçerli değildir.
            * Kalıtım desteklemez (Ancak interface uygulanabilir).
     
             */

            Color color = new Color(); //new anahtar kelimesinin amacı varsayılan degerleri yuklemek

            color.Red = 255;
            color.Green = 240;
            color.Blue = 255;

            Console.WriteLine(color.Red);

            Color color3 = new Color(255, 240, 255);
        
            Console.WriteLine(color.GetColor());

            Color color2 = color;
            Console.WriteLine(color2.GetColor());

            Currency currency = new Currency(10000, "$");
            Console.WriteLine(currency.GetCurrency());

            Currency currency2 = new Currency(10000, "TL", false);
            Console.WriteLine(currency2.GetCurrency());
        }
    }
}
