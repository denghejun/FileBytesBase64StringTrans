using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileBytesStringConvert
{
    class Program
    {
        public static string PDF_FILE_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "angularjs_tutorial.pdf");
        static void Main(string[] args)
        {
            // 1. Get the File Base 64 String and extension name
            var bytes = File.ReadAllBytes(PDF_FILE_PATH);
            var ext = new FileInfo(PDF_FILE_PATH).Extension;
            var base64String = Convert.ToBase64String(bytes); // then you can send the base64 string to other people.

            // 2. convert base64 string back to file.
            var convertBackBytes = Convert.FromBase64String(base64String);
            File.WriteAllBytes(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.ToString("yyyyMMddHHmmss") + ext), convertBackBytes);
        }
    }
}
