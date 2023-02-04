using System;
using System.IO;
namespace DelegateApp1
{
    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;
        // 委託聲明
        public delegate void printString(string s);
        
        // 輸出在console
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The string is: {0}", str);
        }
        // 寫入文件
        public static void WriteToFile(string s)
        {
            fs = new FileStream("d:\\message.txt",FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
        // 該方法把委託作為參數，並使用它調用方法
        public static void sendString(printString ps)
        {
            ps("hello world");
        }
        
        
        
        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            sendString(ps1);
            sendString(ps2);
            
        }
    }
}
