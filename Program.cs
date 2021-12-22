using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_converter
{
    class Program
    {
        /// <summary>
        /// dasdsadsadsasdsadsdasdsadsadas
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int numar, baza,numar2222;
            bool ok=false;
            string verificareNumar;
            numar = int.Parse(Console.ReadLine());
            baza = int.Parse(Console.ReadLine());
            verificareNumar = numar.ToString();
            if (numar > 9) {
                for (int i = 0; i < verificareNumar.Length-1; i++)
                {
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '0')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("10", "A");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '1')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("11", "B");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '2')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("12", "C");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '3')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("13", "D");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '4')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("14", "E");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '5')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("15", "F");
                        break;
                    }
                }
            }
           
            if (ok == true)
            {
                if (baza >= 2 && baza <= 16)
                {
                    if (baza == 16)
                    {
                        Console.WriteLine($"Numarul introdus, modificat cu caracatere ASCII (A-F) inainte de convertirea sa este: {verificareNumar}");
                    }
                    //ConvertFromBase10ToAnyBase(numar, baza);  //1023 este valoarea maxima care poate fi reprezentata in baza 2.
                    ConvertFromAnyBaseToBase10(numar, baza);
                }
                else
                    Console.WriteLine("Baza introdusa nu se afla in intervalul [2,16]. Incercati din nou!");
            }
            else
            {
                if (baza >= 2 && baza <= 16)
                {
                    Console.WriteLine($"Numarul {numar.ToString()} nu se poate reprezenta cu ajutorul caracterelor cuprinse intre A-F");
                    //ConvertFromBase10ToAnyBase(numar, baza); //1023 este valoarea maxima care poate fi reprezentata in baza 2.
                    ConvertFromAnyBaseToBase10(numar, baza);
                }
                else
                    Console.WriteLine("Baza introdusa nu se afla in intervalul [2,16]. Incercati din nou!");
            }
        }

        private static void ConvertFromBase10ToAnyBase(int numar,int baza)
        {
            int rest, n, noulNumar = 0, p = 1;
            string verificareNumar;
            bool ok = false;
            n = numar;
            while(n>0)
            {
                rest = n % baza;
                noulNumar = noulNumar + rest * p;
                p = p * 10;
                n = n / baza;
            }
            Console.WriteLine($"Numarul convertit din baza 10 in baza {baza} este: {noulNumar}");
            verificareNumar = noulNumar.ToString();
            if (numar > 9)
            {
                for (int i = 0; i < verificareNumar.Length - 1; i++)
                {
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '0')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("10", "A");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '1')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("11", "B");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '2')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("12", "C");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '3')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("13", "D");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '4')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("14", "E");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '5')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("15", "F");
                        break;
                    }
                }
            }
            if (ok == true && baza==16) 
                Console.WriteLine($"Noul numar convertit cu caracatere ASCII (A-F) este: {verificareNumar}");
        }

        private static void ConvertFromAnyBaseToBase10(int numar, int baza)
        {
            int suma = 0, n, j;
            string verificareNumar;
            bool ok = false;
            n = numar; 
            suma = suma + (n % 10);
            n = n / 10;
            j = baza;
            while (n > 0) {
                if (n ==1)
                {
                    suma = suma + j;
                    n = n / 10;
                }
                suma = suma + j * (n % 10);
                j = j * baza;
                n = n / 10;
            }
            Console.WriteLine($"Numarul convertit din baza {baza} in baza 10 este: {suma}");
            verificareNumar = suma.ToString();
            if (numar > 9)
            {
                for (int i = 0; i < verificareNumar.Length - 1; i++)
                {
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '0')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("10", "A");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '1')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("11", "B");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '2')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("12", "C");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '3')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("13", "D");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '4')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("14", "E");
                        break;
                    }
                    if (verificareNumar[i] == '1' && verificareNumar[i + 1] == '5')
                    {
                        ok = true;
                        verificareNumar = verificareNumar.Replace("15", "F");
                        break;
                    }
                }
            }
            if (ok == true && baza==16)
                Console.WriteLine($"Noul numar convertit cu caracatere ASCII (A-F) este: {verificareNumar}");
        }
    }
}
