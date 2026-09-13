using System;

namespace Task2_RemoveWords {
    internal class Program {
        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("\n--- Введіть текст (або натисніть Enter для виходу) ---");
                string text = Console.ReadLine() ?? "";

                // Якщо користувач нічого не ввів — виходимо з циклу
                if (string.IsNullOrWhiteSpace(text)) {
                    break;
                }

                Console.Write("Введіть число X: ");
                int x = int.TryParse(Console.ReadLine(), out int parsedX) ? parsedX : 0;

                string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (x >= words.Length) {
                    Console.WriteLine("Результат: ");
                } else {
                    string result = "";
                    for (int i = x; i < words.Length; i++) {
                        result += words[i];
                        if (i < words.Length - 1) {
                            result += " ";
                        }
                    }
                    Console.WriteLine($"Результат: {result}");
                }
            }
        }
    }
}
