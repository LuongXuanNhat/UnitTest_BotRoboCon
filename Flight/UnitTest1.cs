using FluentAssertions;
using Domain;
namespace Flight
{
    public class UnitTest1
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Domain.Flight(seatCapacity: 3);
            flight.Book("helloWould@gmail.com", 1);

            flight.RemainingNumberOfSeats.Should().Be(2);   
        }

        [Fact]
        public void Avoids_overbooking()
        {
            // Given
            var flight = new Domain.Flight(seatCapacity: 3);
            // When 
            var error = flight.Book("hdgagd@gmail.com", 4);
            // Then
            error.Should().BeOfType<OverbookingError>();
        }
    }
}