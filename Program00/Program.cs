 
using AverageCalculator;
/// <summary>
/// Neuer namespace
/// </summary>
namespace program00;
 /// <summary>
 /// Das ist eine öffentliche klasse in der das Hauptprogramm
 /// zum berechnen des Durchschnitts ist
 /// </summary>
public class program00
{
    /// <summary>
    /// Einstiegspunkt des Programms
    /// Führt die Berechnung und Ausgabe des Durchschnitts aus
    /// </summary>
    public static int Main()
    {
        /// <summary>
        /// Erstellt ein neues objekt der Klasse AverageCalculator
        /// </summary>
        AverageCalculator.AverageCalculator calculator = new AverageCalculator.AverageCalculator();
        /// <summary>
        /// Erstellt ein Array von double Werten
        /// </summary>
        double[] numbers = {5, 10, 15, 20};
        /// <summary>
        /// Gibt die Werte von numbers an die Methode calculator.add weiter
        /// welche die Werte dann speichert
        /// </summary>
        calculator.add(numbers);
        /// <summary>
        /// Fügt nur eine einzelne Zahl zum calculator hinzu
        /// </summary>
        calculator.add(67);
        /// <summary>
        /// Holt alle gespeicherten Werte aus dem calculator
        /// Diese werden in einem neuen Array elements gespeichert
        /// </summary>
        double[] elements = calculator.getElements();
        /// <summary>
        /// Zählt wie viele Werte elements hat und gibt diese auf der Konsole aus
        /// </summary>
        Console.WriteLine("Gespeicherte Werte:");
        for (int count = 0; count < elements.Length; count++)
        {
            Console.WriteLine(elements[count]);
        }
        /// <summary>
        /// Gibt die Anzahl der Werte und den Durchschnitt in der Konsole aus
        /// </summary>
        Console.WriteLine("Anzahl: " + calculator.count());
        Console.WriteLine("Durchschnitt: " + calculator.getAverage());
        /// <summary>
        /// Beendet das Programm mit der Rückgabewert 0
        /// </summary>
        return 0;
    }
}
 