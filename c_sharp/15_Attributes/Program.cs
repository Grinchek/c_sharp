using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text.RegularExpressions;
using System.Text.Json;

namespace _c_sharp_
{



    class Program
    {
        private static Dictionary<int, User> users = new Dictionary<int, User>();
        private static string filePath = "users.json";

        private static string ValidationString(string prompt, string pattern)
        {
            string input = Console.ReadLine();
            while (true)
            {
                Console.Write(prompt);

                if (Regex.IsMatch(input, pattern))
                {
                    break;
                }
                Console.WriteLine("Invalid format. Please try again.");
            }
            return input;
        }
        private static int ValidationInt(string prompt, int min, int max)
        {
            string input = Console.ReadLine();
            while (true)
            {
                Console.Write(prompt);

                if (int.Parse(input) >= min && int.Parse(input) <= max)
                {
                    break;
                }
                Console.WriteLine($"Please enter a value between {min} and {max}.");
            }
            return int.Parse(input);
        }
        public static void AddUser()
        {
            var user = new User();
            user.Id = ValidationInt("Enter ID (1000-9999): ", 1000, 9999);

            while (true)
            {
                user.Login = ValidationString("Enter Login: ", @"^[a-zA-Z]+$");
                user.Password = ValidationString("Enter Password (min 8 characters): ", @"^[a-zA-Z]{8,}$");
                user.ConfirmPassword = ValidationString("Confirm Password: ", @"^[a-zA-Z]{8,}$");
                user.Email = ValidationString("Enter Email: ", @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                user.CreditCard = ValidationString("Enter Credit Card: ", @"^\d{4}-?\d{4}-?\d{4}-?\d{4}$");
                user.Phone = ValidationString("Enter Phone (Format: +38-0XX-XXX-XX-XX): ", @"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$");

                users[user.Id] = user;
                Console.WriteLine("User was added successfully.");
                break;

            }
        }
        private static void UpdateUser()
        {
            int id = ValidationInt("Enter the ID of the user to update: ", 1000, 9999);

            if (users.ContainsKey(id))
            {
                var user = users[id];
                user.Login = ValidationString("Enter Login: ", @"^[a-zA-Z]+$");
                user.Password = ValidationString("Enter Password (min 8 characters): ", @"^[a-zA-Z]{8,}$");
                user.ConfirmPassword = ValidationString("Confirm Password: ", @"^[a-zA-Z]{8,}$");
                user.Email = ValidationString("Enter Email: ", @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                user.CreditCard = ValidationString("Enter Credit Card: ", @"^\d{4}-?\d{4}-?\d{4}-?\d{4}$");
                user.Phone = ValidationString("Enter Phone (Format: +38-0XX-XXX-XX-XX): ", @"^\+38-0\d{2}-\d{3}-\d{2}-\d{2}$");

                users[id] = user;
                Console.WriteLine("User updated successfully.");


            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        private static void DeleteUser()
        {
            int id = ValidationInt("Enter the ID of the user to delete: ", 1000, 9999);

            if (users.Remove(id))
            {
                Console.WriteLine("User deleted successfully.");
            }
            else
            {
                Console.WriteLine("User not found.");
            }
        }
        private static void DisplayUsers()
        {
            foreach (var user in users.Values)
            {
                Console.WriteLine($"ID: {user.Id}, Login: {user.Login}, Email: {user.Email}, Phone: {user.Phone}");
            }
        }

        private static void SaveUsersToFile()
        {
            string json = JsonSerializer.Serialize(users);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Users saved to file.");
        }

        private static void LoadUsersFromFile()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                users = JsonSerializer.Deserialize<Dictionary<int, User>>(json);
                Console.WriteLine("Users loaded from file.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Update User");
                Console.WriteLine("3. Delete User");
                Console.WriteLine("4. Display Users");
                Console.WriteLine("5. Save Users to File");
                Console.WriteLine("6. Load Users from File");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        AddUser();
                        break;
                    case "2":
                        UpdateUser();
                        break;
                    case "3":
                        DeleteUser();
                        break;
                    case "4":
                        DisplayUsers();
                        break;
                    case "5":
                        SaveUsersToFile();
                        break;
                    case "6":
                        LoadUsersFromFile();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}