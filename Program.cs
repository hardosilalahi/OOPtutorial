using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace classtutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var hesh = new Hancok();

            var message = CipherWord.encrypt("hello world", "mamang kesbor");

            var decrypt = CipherWord.decrypt(message, "mamang kesbor");
            Console.WriteLine(message);

            // Console.WriteLine(hesh.md5Hash("secret"));
            // Console.WriteLine(hesh.Sha1Hash("secret"));
            // Console.WriteLine(hesh.Sha256Hash("secret"));
            // Console.WriteLine(hesh.Sha512Hash("secret"));


            
        }

    }
}
