namespace TheaterTicketSalesLib;

public class SeatingChart
{
    private readonly ITextFile _textFile;

    public SeatingChart(ITextFile textFile)
    {
        _textFile = textFile;
    }

    public void Read()
    {
        if (_textFile.IsMissing())
        {
            throw new FileNotFoundException("SeatAvailability.dat is missing!");
        }
    }
}