﻿namespace GestionClientsHotels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();

            Client client1 = new Client("Anna", "John", "johndoe@example.com", "1234-5678-9012-3456", 101);
            Client client2 = new Client("Smith", "Jane", "janesmith@example.com", "9876-5432-1098-7654", 201);
            Client client3 = new Client("Lee", "Willis", "brucelee@example.com", "2468-1357-5793-8642", 301);

            hotel.AjouterClient(client1);
            hotel.AjouterClient(client2);
            hotel.AjouterClient(client3);

            foreach (Client client in hotel.ListeClients)
            {
                Console.WriteLine("{0} {1}, {2}, Carte de crédit: {3}, Chambre: {4}", client.Prenom, client.Nom, client.Courriel, client.CarteCredit, client.NumeroChambre);
            }

            Console.ReadLine();
        }
    }
    }
