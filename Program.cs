using System;

namespace TodoListArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string
                secim,
                baslik;
            string[] todoList = new string[5];
            int index;

            Console.WriteLine("TodoList Uygulaması");
            while (true)
            {
                Console.WriteLine("Lütfen Yapmak İstediğiz İşlemi Seçiniz");
                Console.WriteLine("***************************************");
                Console.WriteLine("[1] Kayıt Listele");
                Console.WriteLine("[2] Kayıt Ekle");
                Console.WriteLine("[3] Kayıt Düzenle");
                Console.WriteLine("[4] Kayıt Sil");
                Console.WriteLine("[0] Çıkış");

                secim = Console.ReadLine();

                switch (secim)
                {
                    case "0":
                        goto cikis;
                    case "1":
                        goto listele;
                    case "2":
                        goto ekle;
                    case "3":
                        goto duzenle;
                    default:
                        Console
                            .WriteLine("\nLütfen 0-4 arasında bir değer giriniz!\n");
                        continue;
                }

                cikis:
                break;

                listele:
                foreach (var todo in todoList)
                {
                    Console
                        .WriteLine(Array.IndexOf(todoList, todo) + "-" + todo);
                }
                continue;

                ekle:
                Console.Write("Yapılacak İş : ");
                baslik = Console.ReadLine();
                Console
                    .Write("Eklenecek Index (0-4 arasında bir değer giriniz): ");
                index = int.Parse(Console.ReadLine());
                todoList[index] = baslik;
                Console.WriteLine("\nKayıt Başarıyla Eklendi!\n");
                continue;

                duzenle:
                foreach (var todo in todoList)
                {
                    Console
                        .WriteLine(Array.IndexOf(todoList, todo) + "-" + todo);
                }
                Console.WriteLine("Düzenlemek istediğiniz kaydın indexi : ");
                index = int.Parse(Console.ReadLine());

                Console.WriteLine("Yeni başlık : ");
                baslik = Console.ReadLine();
                todoList[index] = baslik;
                Console.WriteLine("\nKayıt Başarıyla Güncellendi!\n");
                continue;
            }
        }
    }
}
