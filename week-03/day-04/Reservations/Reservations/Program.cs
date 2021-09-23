using System;

namespace Reservations
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            Reservation reservation1 = new Reservation();

            string codeBooked = reservation1.GetCodeBooking();
            string dayBooked = reservation1.GetDowBooking();

            Console.WriteLine($"Booking# {codeBooked} for {dayBooked}");
        }
    }
}
