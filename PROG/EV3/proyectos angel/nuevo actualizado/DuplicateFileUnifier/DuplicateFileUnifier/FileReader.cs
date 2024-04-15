using System.Data;
using System.Security.Cryptography;

namespace DuplicateFileUnifier;

public static class FileReader
{
    //No se usa
    public static string[] ReadFile(string path)
    {
        if (!File.Exists(path))
            return Array.Empty<string>();
        List<string> file = new();
        try
        {
            using (StreamReader r = new StreamReader(path))
            {
                while (true)
                {
                    string? s = r.ReadLine();
                    if (s == null)
                        break;
                    file.Add(s);
                }
                r.Close();
                return file.ToArray();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public static string? GetHash(string filePath)
    {
        try
        {
            using (var hashAlgorithm = SHA256.Create())
            {
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[2048]; 
                    int bytesRead;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        hashAlgorithm.TransformBlock(buffer, 0, bytesRead, null, 0);
                    }
                    hashAlgorithm.TransformFinalBlock(buffer, 0, 0);
                    byte[]? hashBytes = hashAlgorithm.Hash;
                    return Convert.ToBase64String(hashBytes != null ? hashBytes : throw new NoNullAllowedException("Hash bytes are null"));
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while getting the hash of the file: {e.Message}");
            return null;
        }
    }
    
    public static bool CompareFilesByteByByte(string file1, string file2)
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
                while (true)
                {
                    int bytesRead1 = fs1.Read(buffer1, 0, buffer1.Length);
                    int bytesRead2 = fs2.Read(buffer2, 0, buffer2.Length);
                    if (bytesRead1 != bytesRead2)
                        return false;
                    if (bytesRead1 == 0)
                        return true;
                    for (int i = 0; i < bytesRead1; i++)
                    {
                        if (buffer1[i] != buffer2[i])
                            return false;
                    }
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error comparing files byte by byte: {e.Message}");
            return false;
        }
    }
}