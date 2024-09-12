using System;

class Program
{
    static void Main()
    {
        // Input berat badan
        Console.Write("Masukkan berat badan (dalam kg): ");
        double beratBadan = Convert.ToDouble(Console.ReadLine());

        // Input tinggi badan
        Console.Write("Masukkan tinggi badan (dalam cm): ");
        double tinggiBadanCm = Convert.ToDouble(Console.ReadLine());

        // Konversi tinggi badan dari cm ke meter
        double tinggiBadanM = tinggiBadanCm / 100.0;

        // Hitung BMI
        double bmi = beratBadan / (tinggiBadanM * tinggiBadanM);

        // Menampilkan hasil BMI
        Console.WriteLine($"BMI Anda adalah: {bmi:F2}");

        // Menentukan kategori BMI
        if (bmi < 18.50)
        {
            Console.WriteLine("Kategori: Kekurangan berat badan");
        }
        else if (bmi >= 18.50 && bmi < 24.99)
        {
            Console.WriteLine("Kategori: Normal");
        }
        else if (bmi >= 25 && bmi < 29.99)
        {
            Console.WriteLine("Kategori: Kelebihan berat badan");
        }
        else
        {
            Console.WriteLine("Kategori: Obesitas");
        }
    }
}
