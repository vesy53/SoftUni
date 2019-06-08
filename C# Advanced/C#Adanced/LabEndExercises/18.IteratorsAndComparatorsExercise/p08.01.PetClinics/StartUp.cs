namespace p08._01.PetClinics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Pet> pets = new List<Pet>();
            List<Clinic> clinics = new List<Clinic>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string command = input[0];

                Pet pet = null;
                Clinic clinic = null;
                string petName = string.Empty;
                string clinicName = string.Empty;

                switch (command)
                {
                    case "Create":
                        try
                        {
                            string type = input[1];

                            if (type == "Pet")
                            {
                                petName = input[2];
                                int age = int.Parse(input[3]);
                                string kind = input[4];

                                pet = new Pet(petName, age, kind);

                                pets.Add(pet);
                            }
                            else if (type == "Clinic")
                            {
                                clinicName = input[2];
                                int roomCount = int.Parse(input[3]);

                                Clinic currClinic = new Clinic(clinicName, roomCount);

                                clinics.Add(currClinic);
                            }
                        }
                        catch(InvalidOperationException ioe)
                        {
                            Console.WriteLine(ioe.Message);
                        }

                        break;
                    case "Add":
                        petName = input[1];
                        clinicName = input[2];

                        pet = pets.FirstOrDefault(p => p.Name == petName);
                        clinic = clinics.FirstOrDefault(c => c.Name == clinicName);

                        Console.WriteLine(clinic.Add(pet));
                        break;
                    case "Release":
                        clinicName = input[1];

                        clinic = clinics.FirstOrDefault(c => c.Name == clinicName);
                        Console.WriteLine(clinic.Release());
                        break;
                    case "HasEmptyRooms":
                        clinicName = input[1];

                        clinic = clinics.FirstOrDefault(c => c.Name == clinicName);
                        Console.WriteLine(clinic.HasEmptyRooms);
                        break;
                    case "Print":
                        clinicName = input[1];

                        clinic = clinics.FirstOrDefault(c => c.Name == clinicName);

                        if (input.Length == 3)
                        {
                            int roomNumber = int.Parse(input[2]);
                            Console.WriteLine(clinic.Print(roomNumber));
                        }
                        else
                        {
                            Console.WriteLine(clinic.PrintAll().ToString());
                        }
                        break;
                }
            }
        }
    }
}
