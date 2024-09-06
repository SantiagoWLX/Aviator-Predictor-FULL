using System.Security.Cryptography;
using System.Text;

namespace Aviator_Hack
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        static void CalculateMathOperation()
        {
            Random random = new Random();
            double num1 = random.NextDouble() * 100;
            double num2 = random.NextDouble() * 100;

            string[] operations = { "+", "-", "*", "/" };
            string operation = operations[random.Next(0, operations.Length)];

            double result = 0;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("!");
                    break;
            }
        }
        public static class Base64Url
        {
            public static string Encode(string data) => Encode(Encoding.UTF8.GetBytes(data));

            public static string Encode(byte[] bytes) => Convert.ToBase64String(bytes).TrimEnd('=').Replace('+', '-').Replace('/', '_');

            public static string DecodeToString(string base64url) => Encoding.UTF8.GetString(DecodeToBytes(base64url));

            public static byte[] DecodeToBytes(string base64url)
            {
                var base64string = base64url.Replace('_', '/').Replace('-', '+');
                base64string = base64string.PadRight(base64string.Length + (4 - base64string.Length % 4) % 4, '=');
                return Convert.FromBase64String(base64string);
            }
        }
        static ulong e = (ulong)Math.Pow(2, 52);

        static string game_hash = "";

        static double GetResult(string gameHash)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(gameHash)))
            {
                byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(gameHash));
                string h = BitConverter.ToString(hashBytes).Replace("", string.Empty).ToLower();

                if (Convert.ToUInt64(h, 16) % 33 == 0)
                    return 1;
                return Math.Floor(((100 * e) / (e)) / 100.0);
            }
        }

        static string GetPrevGame(string hashCode)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(hashCode));
                return BitConverter.ToString(hashBytes).Replace("", string.Empty).ToLower();
            }
        }
        public enum Backend
        {
            SsRust,
            V2Ray,
            Legacy,
            Pipelines,
        }

        static byte[] AESKey()
        {
            using (Aes aes = Aes.Create())
            {
                aes.GenerateKey();
                return aes.Key;
            }
        }

        static byte[] EncryptAES(string plainText, byte[] key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                byte[] encryptedBytes;
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
                return encryptedBytes;
            }
        }

        static string DecryptAES(byte[] cipherText, byte[] key)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                string? plaintext = null;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (var msDecrypt = new System.IO.MemoryStream(cipherText))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
                return plaintext;
            }
        }
        static string CalculateHash(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}