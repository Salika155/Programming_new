namespace DuplicateFileUnifier;

public class FileUnifier
{
    private string _outputPath = string.Empty;
    private List<string> _directories = new();
    private List<UFile> _files = new();
    private List<UFile> _duplicates = new();
    
    public bool IsOututPathSet => !string.IsNullOrEmpty(_outputPath);
    public bool HasDirectories => _directories.Count > 0;
    public bool HasFiles => _files.Count > 0;
    public bool ExportDuplicates { get; set; }
    
    public void AddDirectory(string path)
    {
        if (Directory.Exists(path))
            _directories.Add(path);
    }
    
    public void SetOutputPath(string path)
    {
        if (Directory.Exists(path))
        {
            string newPath = Path.Combine(path, "FileUnifierOutput");
            Directory.CreateDirectory(newPath);
            _outputPath = newPath;
        }
    }
    
    public void ListFiles()
    {
        foreach (string directory in _directories)
        {
            string[] allFiles = Directory.GetFiles(directory, "*.*", SearchOption.AllDirectories);
            foreach (string file in allFiles)
            {
                UFile f = new UFile()
                {
                    Path = file,
                    Hash = FileReader.GetHash(file),
                    Size = new FileInfo(file).Length
                };
                _files.Add(f);
            }
        }
    }
    
    public void CompareFiles()
    {
        for (int i = 0; i < _files.Count; i++)
        {
            if (_files[i].Disabled)
                continue;
            for (int j = i + 1; j < _files.Count; j++)
            {
                var fi = _files[i];
                var fj = _files[j];
                if (fj.Disabled)
                    continue;
                if (fi.Hash == fj.Hash && fi.Size == fj.Size && FileReader.CompareFilesByteByByte(fi.Path, fj.Path))
                {
                    fj.Disabled = true;
                    _duplicates.Add(fj);
                }
            }
        }
    }
    
    public void CopyFiles()
    {
        if (!IsOututPathSet || !HasDirectories || !HasFiles)
            return;
        string? parentDirectoryPath = Directory.GetParent(_directories[0])?.FullName;
        foreach (var file in _files)
        {
            if (file.Disabled)
                continue;
            string relativePath = parentDirectoryPath != null ? file.Path.Substring(parentDirectoryPath.Length + 1) : file.Path; //Comprobar después
            string targetPath = Path.Combine(_outputPath, relativePath);
            string? targetDirPath = Path.GetDirectoryName(targetPath);

            if (!Directory.Exists(targetDirPath))
                Directory.CreateDirectory(targetDirPath ?? string.Empty);

            File.Copy(file.Path, targetPath, true);
        }
    }
    
    public void MakeFileOfDuplicates()
    {
        if (!ExportDuplicates || _duplicates.Count == 0)
            return;
        string filePath = Path.Combine(_outputPath, "duplicates.txt");
        using (Stream stream = File.Open(filePath, FileMode.Create))
        {
            using (StreamWriter writer = new StreamWriter(stream))
            {
                foreach (var file in _duplicates)
                    writer.WriteLine(file.Path);
            }
        }
    }
}