namespace _7_PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              * Partial class bize bir class' ı birden fazla class olarak bölmemize, constructor, değişken, property, metodları vs. düzenli bir şekilde ayrı ayrı oluşturmamızı sağlamaktadır. Fiziksel olarak birden fazla parça ile oluşan partial class' lar, çalışma zamanında tek bir class olarak bütün elemanları içerisinde barındırmaktadır.
              * Partial class’ın her parçası aynı namespace içerisinde bulunmalı.
              * Partial class’ın her parçası aynı erişim belirleyiciye sahip olmalıdır.
              * Kullanıcı iç içe kısmi sınıf (nested partial class) kullabilir.
             */

            Employee employee = new Employee(2,"irem");
            employee.Display();
            employee.Id = 1;
            employee.Name= "Test";  
        }
    }
}
