
using System;
using System.Linq;
using System.Collections.Generic;
using ConsoleApp1;
using ConsoleApp1.Classes;

class Program
{
    static void Main(string[] args)
        {
            Console.WriteLine("=== HOTEL SYSTEM DEMO ===");

            // --------------------------------------------
            // 1. GOŚĆ HOTELU
            // --------------------------------------------

            var guest = new HotelGuest
            {
                Name = "Jan",
                Surname = "Kowalski",
                DocumentNumber = "AB1234567"
            };

            // --------------------------------------------
            // 2. POKÓJ
            // --------------------------------------------

            var room = new Room
            {
                Number = 101,
                Type = "Deluxe",
                PricePerNight = 450.00m,
                IsClean = true,
                IsOccupied = false
            };

            // --------------------------------------------
            // 3. REZERWACJA
            // --------------------------------------------

            var reservation = new Reservation
            {
                Guest = guest,
                Room = room,
                CheckIn = DateTime.Today,
                CheckOut = DateTime.Today.AddDays(3)
            };

            guest.AddReservation(reservation);

            Console.WriteLine("\nDodano rezerwację:");
            Console.WriteLine($"Pokój: {reservation.Room.Number}, Cena za noc: {reservation.Room.PricePerNight} zł");
            Console.WriteLine($"Łączny koszt: {reservation.GetTotalPrice()} zł");

            // --------------------------------------------
            // 4. CHECK-IN przez recepcjonistę
            // --------------------------------------------

            var receptionist = new ReceptionStaff
            {
                Name = "Anna",
                Surname = "Recepcja",
                Username = "anna",
                PasswordHash = "hash",
                HireDate = DateTime.Now,
                BaseSalary = 3500
            };

            receptionist.CheckInGuest(guest, reservation);

            Console.WriteLine("\nCheck-in wykonany:");
            Console.WriteLine($"Pokój {room.Number} zajęty? {room.IsOccupied}");

            // --------------------------------------------
            // 5. CHECK-OUT
            // --------------------------------------------

            receptionist.CheckOutGuest(guest);

            Console.WriteLine("\nCheck-out wykonany:");
            Console.WriteLine($"Pokój {room.Number} zajęty? {room.IsOccupied}");

            // --------------------------------------------
            // 6. MINI LAS VEGAS – konto kasynowe
            // --------------------------------------------

            var casino = new MiniLasVegas();

            var casinoAccount = casino.CreateAccount(guest);
            casinoAccount.Credit(500);      // dodaj środki
            casinoAccount.Debit(120);       // gra za 120
            casinoAccount.Credit(200);      // wygrana

            var casinogame = new CasinoGame();
            casinogame.GameType = CasinoGameType.Poker;

            Console.WriteLine("\nKonto kasynowe:");
            Console.WriteLine($"Saldo: {casinoAccount.Balance} zł");
            Console.WriteLine($"Wybrana Gra w Kasynie to: {casinogame.GameType}");

            // --------------------------------------------
            // 7. FAKTURA ZA POBYT
            // --------------------------------------------

            var invoice = new Invoice
            {
                Guest = guest,
                IssueDate = DateTime.Now,
                Number = "FV-2025-0001"
            };

            invoice.Items.Add(new InvoiceItem
            {
                Description = "Pobyt w hotelu – 3 noce",
                Amount = reservation.GetTotalPrice()
            });

            invoice.Items.Add(new InvoiceItem
            {
                Description = "Mini Las Vegas – środki doładowane",
                Amount = 500
            });

            Console.WriteLine("\nFaktura:");
            Console.WriteLine($"Nr: {invoice.Number}");
            Console.WriteLine("Pozycje:");
            foreach (var item in invoice.Items)
                Console.WriteLine($" - {item.Description}: {item.Amount} zł");

            Console.WriteLine($"RAZEM: {invoice.TotalAmount} zł");
            Console.WriteLine("\n=== KONIEC DEMO ===");
        }
    }