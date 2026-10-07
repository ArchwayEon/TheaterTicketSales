using NSubstitute;
using TheaterTicketSalesLib;

namespace TheaterTicketSales.Tests.Integration;

public class ASeatingChart
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReportThatTheSeatingAvailabilityFileIsMissing()
    {
        string fileName = "SeatAvailability.dat";
        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
        TTSATextFile ttsaTextFile = new(fileName);
        SeatingChart sut = new(ttsaTextFile);
        Assert.Multiple(() =>
        {
            var ex = Assert.Throws<FileNotFoundException>(() =>
            {
                sut.Read();
            });
            Assert.That(ex!.Message, Is.EqualTo("SeatAvailability.dat is missing!"));
        });

        if (File.Exists(fileName))
        {
            File.Delete(fileName);
        }
    }
}
