namespace DuplicateFileUnifier;

public static class ArgumentParser
{
    public static void ParseArgs(string[] args, FileUnifier fileUnifier)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No arguments provided");
            return;
        }

        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i])
            {
                case "-d":
                    if (i + 1 < args.Length)
                    {
                        string path = args[i + 1];
                        if (Directory.Exists(path))
                        {
                            fileUnifier.AddDirectory(path);
                            i++;
                        }
                        else
                            Console.WriteLine("Directory does not exist");
                    }
                    else
                        Console.WriteLine("No directory provided");
                    break;
                case "-o":
                    if (!fileUnifier.IsOututPathSet && i + 1 < args.Length)
                    {
                        string path = args[i + 1];
                        if (Directory.Exists(path))
                        {
                            fileUnifier.SetOutputPath(path);
                            i++;
                        }
                        else
                            Console.WriteLine("Directory does not exist");
                    }
                    else
                        Console.WriteLine("No directory provided or output path is already set");
                    break;
                case "-t":
                    fileUnifier.ExportDuplicates = true;
                    break;
                default:
                    Console.WriteLine("Invalid argument");
                    break;
            }
        }
    }
}