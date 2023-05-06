using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp1 {
    //下面的实例演示了委托的用法。
    //委托 printString 可用于引用带有一个字符串作为输入的方法，并不返回任何东西。
    //我们使用这个委托来调用两个方法，第一个把字符串打印到控制台，第二个把字符串打印到文件
    class PrintString {
        static FileStream fs;
        static StreamWriter  sw;
        //委托
        public delegate void printString(string str);
        // 该方法打印到控制台
        public static void WriteToScreen(string str) {
            Console.WriteLine("The String is: {0}", str);
        }
        // 该方法打印到文件
        public static void WriteToFile(string s) {
            fs = new FileStream("E:\\message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        /// <summary>
        /// 该方法把委托作为参数，并使用它调用方法
        /// </summary>
        /// <param name="ps"></param>
        public static void sendString(printString ps) {
            ps("Hello World");
        }
    }
    internal class TestDelegate2 {

    }
}
