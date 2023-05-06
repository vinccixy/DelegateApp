using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp1 {
    //一个委托
    delegate int NumberChanger(int n);
    internal class TestDelegate1 {
        static int num = 20;
        public static int AddNum(int p) {
            num += p;
            return num;
        }
        public static int MultNum(int p) {
            num *= p;
            return num;
        }
        public static int getNum() {
            return num;
        }
        static void Main(string[] args) {
            //创建委托实例
            NumberChanger nc;
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);
            nc = nc1;
            nc += nc2;
            //调用多播
            nc(5);
            Console.WriteLine("value of num :{0}", getNum());
            Console.ReadKey();
        }

    }
}
