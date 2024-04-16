namespace DuplicateFileUnifier;

public static class AplicationRunner
{
    public static void Run(string[] args)
    {
        FileUnifier fileUnifier = new();
        ArgumentParser.ParseArgs(args, fileUnifier);
        if (fileUnifier.IsOutputPathSet && fileUnifier.HasDirectories)
        {
            fileUnifier.ListFiles(); 
            fileUnifier.CompareFiles();
            fileUnifier.CopyFiles();
            if (fileUnifier.ExportDuplicates)
                fileUnifier.MakeTextFileOfDuplicates();
        }
    }
}