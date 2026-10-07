namespace TheaterTicketSalesLib;

public class TTSATextFile : ITextFile
{
    private string _fileName;

    public TTSATextFile(string fileName)
    {
        _fileName = fileName;
    }

    public bool IsMissing()
    {
        return File.Exists(_fileName) == false;
    }
}