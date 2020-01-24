using System;

namespace Testpractice
{
    public class Leetspeak
    {
        public static void Main()
        {
            
            Console.WriteLine(Leet(Console.ReadLine()));
        }
        public static string Leet(string input){
            string Leetchange = "";

            Leetchange = SAssembler(input);
            return Leetchange;
        }
        public static string SAssembler(string i1)
        {
            string o="";
            int i = 0;
            foreach (string ic in i1.Split(" "))
            {
                i++;
                o += WAssembler(ic);
                if(i == i1.Split(" ").Length){
                 return o;   
                }
                else{
                o += " ";
                }

            }
        return o;
        }
        public static string WAssembler(string i2)
        {
            i2 = i2.ToLower();
            string output = "";
            char[] wA = i2.ToCharArray();
            for (int ct = 0; ct < wA.Length; ct++)
            {

                output += Leeterpreter(Convert.ToChar(wA[ct]), ct);

            }
        return output;
        }

        public static char Leeterpreter(char i3, int ct)
        {
            char o;
            switch (i3)
            {
                case 'e':
                    o = '3';
                    break;
                case 't':
                    o = '7';
                    break;
                case 'o':
                    o = '0';
                    break;
                case 'a':
                    o = '4';
                    break;
                case 'i':
                    o = '1';
                    break;
                case 's':
                    if (ct == 0)
                    {
                        o = i3;
                    }
                    else
                    {
                        o = 'z';
                    }
                    break;
                default:
                    o = i3;
                    break;
            }
        return o;
        }

    }
}