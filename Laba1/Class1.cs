using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks {

    public class PrimeNumer {
        public static bool isPrime(int numb) {
            if (numb % 2 == 0 || numb <= 1) {
                return false;
            }

            int sqr = ( int ) Math.Sqrt(numb);

            for (int i = 3; i < sqr; i += 2) {
                if (numb % i == 0) {
                    return false;
                }
            }
            return true;
        }
    }


    public class BiggerNumber {
        public static int NextBiggerNumber(int numb) {
            int tempI = -1;
            int tempJ = -1;
            int tempVal = -1;
            List<int> list = ListNumb(numb);
            for (int i = 0; i < list.Count; i++) {
                
                if (list[i] > list[i + 1]) {
                    tempI = i;
                    
                }
            }

            for (int j = 0; j < tempI + 1; j++) {

                if (list[j] > list[tempI + 1] && list[j] > tempVal) {
                    tempVal = list[j];
                    tempJ = j;
                }
            }

            if (tempVal != -1) {
                int temp = list[tempI + 1];
                list[tempI + 1] = list[tempJ];
                list[tempJ] = temp;

                //list.Sort(0, tempI + 1, (o1,o2) -> (o2 - o1));
                return IntNumb(list);
            }

            return -1;
        }

        private static List<int> ListNumb(int numb) {
            List<int> list = new List<int>();
            for (int i = 0; numb > 0; i++) {
                list.Add(numb % 10);
                numb %= 10;
            }
            return list;
        }

        private static int IntNumb(List<int> list) {
            int numb = 0;
            for (int i = 0; i < list.Count; i++) {
                numb += list[i] * (10 ^ i);
            }
            return numb;
        }
    }


    public class SwitcherCl {
        public static StringBuilder Switcher(int[] mass) {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < mass.Length; i++) {
                str.Append(Alph.alph[mass[i] - 1]);
            }
            return str;
        }
    }


    public static class Alph {
        public static string[] alph = { "z","y", "x", "w", "v", "u", "t", "s", "r", "q", "p", "o", "n", "m", "l", "k", "j", "i", "h", "g", "f", "e", "d", "c", "b", "a", "!", "?", " " };
    }
}
