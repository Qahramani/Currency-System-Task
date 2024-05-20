namespace CurrencyManagemenntSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencyCodes = { "USD", "RUB", "TRY" };
            decimal[] currencyRates = { 1.70M, 0.0187M, 0.0527M };
            int index = 0;

            while (true)
            {
                Console.WriteLine("Movcud operasiyalar: ");
                Console.WriteLine("1.Mezennelerin kodları ve kurs qiymetleri ile birlikde gösterilmesi");
                Console.WriteLine("2.Spesifik bir mezennenin kodu ve kurs qiymeti ile birlikde gösterilmesi");
                Console.WriteLine("3.Verilmiş mezzenneye ve qiymete uyğun olaraq mebleğin hesablanması");
                Console.WriteLine("4.Programdan çıxmaq ");
                Console.Write("Operasiyani daxil edin: ");

                string operation = Console.ReadLine();

                if (operation == "1")
                {
                    while (index < currencyCodes.Length)
                    {
                        Console.WriteLine(currencyRates[index] + currencyCodes[index]);
                        index++;
                    }
                    index = 0;
                }
                else if (operation == "2")
                {
                    Console.Write("Mezennenin alpha3 kodu (USD, RUB, TRY) daxil edin: ");
                    string code = Console.ReadLine();
                    while (index < currencyCodes.Length)
                    {
                        if (code == currencyCodes[index])
                        {
                            Console.WriteLine(currencyRates[index] + currencyCodes[index]);
                            break;
                        }
                        index++;
                    }
                    index = 0;
                }


            }
        }
    }
}

