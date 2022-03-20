using System;
class Program
{
    static int Faktoriyel(int sayi)
    {
        if (sayi <= 1)
        {
            return 1;
        }
        else
        {
            return sayi * Faktoriyel(sayi - 1);
        }
    }

    static int Permutasyon(int n, int r)
    {
        return Faktoriyel(n) / Faktoriyel(n - r);
    }

    static int Kombinasyon(int n, int r)
    {
        return Faktoriyel(n) / (Faktoriyel(r) * Faktoriyel(n - r));
    }

    static void Main(string[] args)
    {
        int n, r;

        while (true)//
        {
            Console.WriteLine("-----MENÜ-----\n1-)Faktöriyel Hesabı\n2-)Permütasyon Hesabı\n3-)Kombinasyon Hesabı\n4-)Çıkış");
            int ilkSecim = Convert.ToInt32(Console.ReadLine());

            if (ilkSecim == 1)
            {
                while (true)//
                {
                    Console.Write("Faktöriyelini hesaplayacağınız sayıyı girin.");
                    n = Convert.ToInt32(Console.ReadLine());

                    if (n < 0)
                    {
                        Console.WriteLine("0'dan küçük sayı girmeyiniz.");
                    }
                    else
                    {
                        Console.WriteLine($"{n}! = {Faktoriyel(n)}");
                        break;
                    }
                }//
            }
            else if (ilkSecim == 2)
            {
                while (true)//
                {
                    Console.Write("P(n,r) ---> 'n' değerini giriniz.");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("0'dan küçük sayı girmeyiniz.");
                    }
                    else
                    {
                        while (true)//
                        {
                            Console.Write("P(n,r) ---> 'r' değerini giriniz.");
                            r = Convert.ToInt32(Console.ReadLine());
                            if (r > n)
                            {
                                Console.WriteLine("r, n'den büyük olamaz.");
                            }
                            else if (r < 0)
                            {
                                Console.WriteLine("0'dan küçük sayı girmeyiniz.");
                            }
                            else
                            {
                                break;
                            }
                        }//

                        Console.WriteLine($"P({n},{r}) = {Permutasyon(n, r)}");
                        break;
                    }
                }//
            }
            else if (ilkSecim == 3)
            {
                while (true)// --------------------------
                {
                    Console.Write("C(n,r) ---> 'n' değerini giriniz.");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n < 0)
                    {
                        Console.WriteLine("0'dan küçük sayı girmeyiniz.");
                    }
                    else
                    {
                        while (true)//
                        {
                            Console.Write("C(n,r) ---> 'r' değerini giriniz.");
                            r = Convert.ToInt32(Console.ReadLine());
                            if (r > n)
                            {
                                Console.WriteLine("r, n'den büyük olamaz.");
                            }
                            else if (r < 0)
                            {
                                Console.WriteLine("0'dan küçük sayı girmeyiniz.");
                            }
                            else
                            {
                                break;
                            }
                        }//

                        Console.WriteLine($"C({n},{r}) = {Kombinasyon(n, r)}");
                        break;
                    }
                }//             -------------------------
            }
            else if (ilkSecim == 4)
            {
                Console.WriteLine("Çıkış Yapılıyor...");
                break;
            }

            else
            {
                Console.WriteLine("Hatalı Seçim");
            }
        }//

    }
}
