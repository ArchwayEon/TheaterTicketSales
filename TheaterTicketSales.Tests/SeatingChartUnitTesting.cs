using NSubstitute;
using TheaterTicketSalesLib;

namespace TheaterTicketSales.Tests.Unit;

public class ASeatingChart
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ShouldReportThatTheSeatingAvailabilityFileIsMissing()
    {
        ITextFile fakeTextFile = Substitute.For<ITextFile>();
        fakeTextFile.IsMissing().Returns(true);
        SeatingChart sut = new(fakeTextFile);
        Assert.Multiple(() =>
        {
            var ex = Assert.Throws<FileNotFoundException>(() =>
            {
                sut.Read();
            });
            Assert.That(ex!.Message, Is.EqualTo("SeatAvailability.dat is missing!"));
        });
    }
}
