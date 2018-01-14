namespace OOP.Class
{
    // class ilk olara eğer, access modifier  belirtilmeid ise default olarak internal gelir.
    // proje içerisinden erişilebilir, fakat başka projelerden erişilemez

    //CLASS: Bir veri tipini modellemek için kullandığımız yapılara sınıf denir. Bir sınıf, kapsüllenmiş verileri bu veriler üzerinde işlem yapacak metotları ve bu verilere ait özellikleri içerebilir.
    class FirstClass  // internal
    {

        //Field: C#’ta alanlar, bir sınıf ya da bir sınıf örneği ile ilişkilendirilmiş değişkenlerdir.  Içerisinde değer saklamak amacıyla kullanılırlar.

        //1. -> bu şekilde field tanımlanırsa otomatikman private olarak atanır.


        //- Eğer ben bir class'a erişim belirleyici(access modifier) belirtmezsem varsayılan olarak INTERNAL gelir.
        //- Internal: Bulunduğu assembly'nin(Dll veya exe dosyası) içinde erişime açık olan yapıdır.Dll veya exe dosyasının içerisinde erişim için kısıtlama yoktur, ama dışarıdan erişilemez.
        //- aynı zamanda class seviyesinde tanımlanan öğeler de (değişken, metot gibi) yine varsayılan olarak private erişim belirleyicisi ile tanımlanırlar.

        //private -> Bir değerin private olarak tanımlanması demek, o değişkene sadece kendi class’ı içinden ulaşılabileceği anlamına gelmektedir. Program içinde kesinlikle değiştirilmemesi gereken, kritik kodlarda kullanılmaktadır.




        // eğer access modifier verilmez ise :
        // int Id;           // default : private
        // string FirstName; // default : private
        // string LastName;  // default : private
        // string Phone;     // default : private
        // int Age;          // default : private
        // int Weight;       // default : private

        //public -> Bir değerin public olarak belirtilmesi; o değerin, kod içinde herhangi bir yerden erişilebilir durumda olmasını sağlamaktadır. Public erişim belirleyici tipinde hiç bir kısıtlama yoktur

        public int Id;
        public string FirstName;
        public string LastName;
        public string Phone;
        public int Weight;


        // field => private nesnelerdir. tanımlanırken _ çizgi ile başlar genel kuraldır. zorunlu değil

        private int _Age; 
        public int Age
        {
            get { return _Age; } // üzerindeki değeri teslim eder.
            set
            {
                if (value < 18 || value > 55)
                {
                    System
                        .Windows
                        .Forms
                        .MessageBox
                        .Show("Uygun Yaş Aralığında Değilsiniz");
                }
                else
                {
                    _Age = value;
                }
            }
        }


        //public int Age { get => _Age; set => _Age = value; }
    }
}


// CTRL + R + G kullanılmaya using'leri siler