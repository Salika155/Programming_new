namespace DuplicateFileUnifier;

public class UFile
{
    public string? Path { get; set; }
    public string? Hash { get; set; }
    public bool Disabled { get; set; }
    public long Size { get; set; }
}