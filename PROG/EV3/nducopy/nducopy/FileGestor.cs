
using System.Data;
using System.Security.Cryptography;

namespace nducopy
{
    public class FileGestor
    {
        public static string[] ReadFile(string path)
        {
            //esto podria hacerlo con un contains para hacerlo yo mas manual
            if (!File.Exists(path))
                return null;

            List<string> lines = new List<string>();
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (true)
                    {
                        string? s = sr.ReadLine();
                        if (s != null)
                            lines.Add(s);
                        break;
                    }
                    sr.Close();
                    return lines.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public static string GetHashFromFile(string filePath)
        {
            try
            {
                using (var fileHash = SHA256.Create())
                {
                    using (var fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buffer = new byte[2048];
                        int bytesRead;
                        while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            fileHash.TransformBlock(buffer, 0, bytesRead, null, 0);
                        }
                        fileHash.TransformFinalBlock(buffer, 0, 0);
                        byte[]? hashArrayBytes = fileHash.Hash;
                        return BitConverter.ToString(fileHash.Hash).Replace("-", string.Empty);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error en la obtención del Hash desde el archivo: {e.Message}");
                return null;
            }
        }

        public static bool CompareFilesByBytes(string file1, string file2)
        {
            if (!File.Exists(file1) || !File.Exists(file2))
                return false;

            try
            {
                using (FileStream fs1 = new FileStream(file1, FileMode.Open, FileAccess.Read),
                                  fs2 = new FileStream(file2, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer1 = new byte[2048];
                    byte[] buffer2 = new byte[2048];
                    while(true)
                    {
                        int bytesReadinf1 = fs1.Read(buffer1, 0, buffer1.Length);
                        int bytesReadinf2 = fs2.Read(buffer2, 0, buffer2.Length);

                        if (bytesReadinf1 != bytesReadinf2)
                            return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
