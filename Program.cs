// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using DelegateApp1;
using static DelegateApp1.PrintString;
//test1
////创建委托实例
//NumberChanger nc;
//NumberChanger nc1 = new NumberChanger(TestDelegate1.AddNum);
//NumberChanger nc2 = new NumberChanger(TestDelegate1.MultNum);
//nc = nc1;
//nc += nc2;
////调用多播
//nc(5);
//Console.WriteLine("value of num :{0}", TestDelegate1.getNum());
//Console.ReadKey();
////test2
//    printString ps1 = new printString(WriteToScreen);
//    printString ps2 = new printString(WriteToFile);
//    sendString(ps1);
//    sendString(ps2);
//    Console.ReadKey();
//test3
//Action<string>FoodAction = new Action<string>(Food.EatFood);
//FoodAction("鱼香肉丝");
Food food = new Food();
food.foodAction = food.EatFood;
food.EatFood("炒鸡蛋");
Console.ReadKey();