using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp1 {
    internal class Food {
        public Action<string> foodAction;
        public  void EatFood(string foodname) {

            //foodAction?.Invoke(foodname+"FFF");
            Console.WriteLine("吃了"+foodname);
        }
    }
}
