using System;
namespace kalkulator;
class Program
{
    static void Main(string[] args)
    {
        //header
        Console.WriteLine("=== SELAMAT MENGGUNAKAN KALKULATOR SEDERHANA! ===");

        //list Operation Math
        Console.WriteLine("Berikut list operasi yang tersedia:");
        Console.WriteLine("Tekan 1. Untuk Penjumlahan (+)\nTekan 2. Untuk Pengurangan(-)\nTekan 3. Untuk Perkalian (*)\nTekan 4. Untuk Pembagian (/)");

        //Choose Operation Math
        Console.WriteLine("Ketik nomor operasi matematika yang ingin kamu gunakan:");
        int operasi = Convert.ToInt32(Console.ReadLine());

        //declaration of variable numbers 1 and 2
        float bil1, bil2 = 0.0f;

        //initialize numbers 1 and 2
        Console.WriteLine("Ketik bilangan pertama:");
        bil1 = float.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("Ketik bilangan kedua:");
        bil2 = float.Parse(Console.ReadLine() ?? "");

        //Display the Result
        switch (operasi)
        {
            case 1:
                Console.WriteLine("Hasil penjumlahan dari " + bil1 + " + " + bil2 + " = " + (bil1 + bil2) + "\n");
                break;
            case 2:
                Console.WriteLine("Hasil pengurangan dari " + bil1 + " - " + bil2 + " = " + (bil1 - bil2) + "\n");
                break;
            case 3:
                Console.WriteLine("Hasil perkalian dari " + bil1 + " X " + bil2 + " = " + (bil1 * bil2) + "\n");
                break;
            case 4:
                Console.WriteLine("Hasil pembagian dari " + bil1 + " / " + bil2 + " = " + (bil1 / bil2) + "\n");
                break;
            default:
                Console.WriteLine("Operasi yang kamu pilih tidak tersedia!\n");
                break;
        }

        //choose whether to recalculate
        Console.WriteLine("Apakah kamu ingin menghitung lagi? (y/n)");
        string mengulang = Console.ReadLine() ?? "";
        if (mengulang == "y")
        {
            Main(args);
        }
        else
        {
            //End Program
            Console.WriteLine("Terima kasih telah mencoba kalkulator sederhana!\nTekan tombol apapun untuk keluar...");
            Console.ReadKey();
        }
    }
}

