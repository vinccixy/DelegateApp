using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp1 {
    //求函数的积分
    //声明一个委托
    delegate double Fun(double x);
    internal class DelegateIntegral {
        public static void Main() {
            Fun fun = new Fun(Math.Sin);
            double d = Integral(fun,0,Math.PI/2,1e-4);
            Console.WriteLine(d);
            Fun fun2 = new Fun(Linear);
            double d2 = Integral(fun2, 0, 2, 1e-3);

            Console.WriteLine(d2);


        }
        //线性函数
        static double Linear(double a) {
            return a * 2 + 1;
        }


        Random r = new Random();
        public double Num(double x) {
            return r.NextDouble();//返回>=0且<1的随机浮点数
        }
        //积分计算
        static double Integral(Fun f, double a, double b, double eps) {
            int n, k;
            double fa, fb, h, t1, p, s, x, t = 0;
            fa = f(a);
            fb = f(b);
            //迭代初值
            n = 1;
            h = b - a;
            t1 = h * (fa + fb) / 2;
            p = double.MaxValue;
            //迭代计算
            while (p >= eps) {
                s = 0.0;
                for (k = 0; k <= n - 1; k++) {
                    x = a + (k + 0.5) * h;
                    s = s + f(x);
                }
                t = (t1 + h * s) / 2.0;
                p = Math.Abs(t1 - t);
                t1 = t;
                n = n + n;
                h = h / 2.0;
            }
            return t;
        }
    }
}
