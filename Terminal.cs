using System;
using System.Data; // For DataTable.Compute
using System.Runtime.InteropServices;

namespace RebaneOS
{
    internal class Terminal
    {
        // Import kernel32 functions to allocate and free the console.
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool FreeConsole();

        public void Start()
        {
            // Open a console window.
            AllocConsole();

            // Set the console text color to green.
            Console.ForegroundColor = ConsoleColor.Green;

            // Start the input loop for the terminal.
            while (true)
            {
                Console.Write("RebaneOS> ");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                    continue;

                try
                {
                    switch (input)
                    {
                        case "calc":
                            CalcCommand();
                            break;
                        case "type":
                            TypeCommand();
                            break;
                        case "help":
                            HelpCommand();
                            break;
                        case "clear":
                            Console.Clear();
                            break;
                        case "beep":
                            BeepCommand();
                            break;
                        case "exit":
                            // Free (close) the console window without closing the application.
                            FreeConsole();
                            return; // Exit the terminal loop.
                        default:
                            Console.WriteLine("Unknown command. Type 'help' for a list of commands.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error executing command: {ex.Message}");
                }
            }
        }

        private void CalcCommand()
        {
            Console.Write("Enter expression (e.g., 5 + 3): ");
            string expression = Console.ReadLine();

            try
            {
                var result = new DataTable().Compute(expression, null);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Invalid expression: {ex.Message}");
            }
        }

        private void TypeCommand()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine($"You typed: {text}");
        }

        private void HelpCommand()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("  calc  - Perform basic calculations");
            Console.WriteLine("  type  - Echo back user input");
            Console.WriteLine("  help  - Show available commands");
            Console.WriteLine("  clear - Clear the terminal screen");
            Console.WriteLine("  beep  - Make a beep sound");
            Console.WriteLine("  exit  - Close the terminal window (console) while keeping the main app running");
        }

        private void BeepCommand()
        {
            // Default beep: frequency 800 Hz for 300 ms.
            Console.Beep(800, 300);
            Console.WriteLine("Beep!");
        }
    }
}