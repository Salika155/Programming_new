using System.Security.Cryptography;

namespace DuplicateFileUnifier;

public static class FileReader
{
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

    public static string GetHash(string filePath)
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
                byte[] hashBytes = hashAlgorithm.Hash;
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }
    }
    
    //Al final no lo uso
    public static void CopyDirectoryStructure(string sourceDir, string targetDir)
    {
        foreach (var filePath in Directory.GetFiles(sourceDir, "*.*", SearchOption.AllDirectories))
        {
            string relativePath = filePath.Substring(sourceDir.Length + 1);
            string targetPath = Path.Combine(targetDir, relativePath);
            string targetDirPath = Path.GetDirectoryName(targetPath);
            
            if (!Directory.Exists(targetDirPath))
                Directory.CreateDirectory(targetDirPath);

            File.Copy(filePath, targetPath, true);
        }
    }
    
    public static bool CompareFilesByteByByte(string file1, string file2)
    {
        if (!File.Exists(file1) || !File.Exists(file2))
            return false;
        var f1 = GetHash(file1);
        var f2 = GetHash(file2);
        return f1 == f2;
    }
}