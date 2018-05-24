using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace DSS
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogIn());
        }
    }

    public class HashString
    {
        public string GetHashString(string s)
        {
            //Хеширование вводимого пароля через MD5
            //Переводим строку пароля в байт-массив
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            //создаем обеъкт для получения средств шифрования
            MD5CryptoServiceProvider cryptoServiceProvider = new MD5CryptoServiceProvider();
            //высчитываем хеш-представление в байтах
            byte[] byteHash = cryptoServiceProvider.ComputeHash(bytes);
            string MD5Hash = string.Empty;
            //формируем одну цельную строку из массива
            foreach (byte b in byteHash)
            {
                MD5Hash += string.Format("{0:x2}", b);
            }
            return MD5Hash;
        }
    }
}
