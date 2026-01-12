using System;

namespace AverageCalculator;
/// <summary>
/// Das ist die Klasse AverageCalculator die die Werte speichert und danach berechnet.
/// </summary>
    public class AverageCalculator
    {
        /// <summary>
        /// hier sind alle werte
        /// </summary>
        private double[] values;
        /// <summary>
        /// Erstellt eine neue Instanz von AverageCalculator und
        /// initialisiert die das interne Werte Array.
        /// </summary>
        public AverageCalculator()
        {
            values = new double[0];
        }
        /// <summary>
        /// Fügt einen double Wert zum Array hinzu.
        /// </summary>
        /// <param name="value"></param>
        public void add(double value)
        {
            /// <summary>
            /// Macht ein neues Array das um einen Platz länger ist.
            /// </summary>
            double[] newArray = new double[values.Length + 1];
            /// <summary>
            /// Kopiert alle alten Werte in das neue Array
            /// </summary>
            for (int count = 0; count < values.Length; count++)
            {
                newArray[count] = values[count];
            }
            /// <summary>
            /// legt den neuen Wert am ende des Arrays hinzu
            /// </summary>
            newArray[values.Length] = value;
            /// <summary>
            /// Ersetz das alte Array mit dem neuen
            /// </summary>
            values = newArray;
        }
        /// <summary>
        /// Fügt mehere double-Werte aus einem Array zur internen Sammlung hinzu
        /// Null und leere Arrays werden ignoriert
        /// </summary>
        /// <param name="newValues">Array mit hinzuzufügenden Werten</param>
        public void add(double[] newValues)
        {
            /// <summary>
            /// Schaut ob das übergebene Array null oder leer ist
            /// </summary>
            if (newValues == null || newValues.Length == 0)
            {
                return;
            }
            /// <summary>
            /// macht ein neues Array in das alte und neue Werte kommen können
            /// </summary>
            double[] newArray = new double[values.Length + newValues.Length];
            /// <summary>
            /// Kopiert die bisherigen Werte in das neue Array
            /// </summary>
            for (int count = 0; count < values.Length; count++)
            {
                newArray[count] = values[count];
            }
            /// <summary>
            /// Legt die neuen Werte hinter die bestehenden Werte an
            /// </summary>
            for (int count = 0; count < newValues.Length; count++)
            {
                newArray[values.Length + count] = newValues[count];
            }
            /// <summary>
            /// macht das neue Array zu den aktuellen Werten
            /// </summary>
            values = newArray;
        }
        /// <summary>
        /// Berchnet und liefert dann den durchschnitt der im Array gespeicherten Werte
        /// </summary>
        /// <returns>
        /// Den Durchschnitt
        /// Wenn keine Werte vorhanden sind gibt es 0 zurück
        /// </returns>
        public double getAverage()
        {
            /// <summary>
            /// Schaut nach ob keine Werte vorhanden sind
            /// </summary>
            if (values.Length == 0)
            {
                return 0;
            }
             /// <summary>
            /// Speichert die Summe der Werte
            /// </summary>
            double sum = 0;
            /// <summary>
            /// Addiert alle Werte zu einer Summe
            /// </summary>
            for (int count = 0; count < values.Length; count++)
            {
                sum += values[count];
            }
            /// <summary>
            /// Gibt den Durchschnitt der gerade berechnet wurde zurück
            /// </summary>
            return sum / values.Length;
        }
        /// <summary>
        /// Gibt alle gespeicherten Werte zurück
        /// </summary>
        /// <returns>
        /// Ein neues Array mit den gespeicherten Werten
        /// </returns>
        public double[] getElements()
        {
            /// <summary>
            /// Erstellt ein neues Array für den Rückgabewert
            /// </summary>
            double[] result = new double[values.Length];
            /// <summary>
            /// Kopiert alle Werte in das Array
            /// </summary>
            for (int count = 0; count < values.Length; count++)
            {
                result[count] = values[count];
            }
            /// <summary>
            /// Gibt das neue Array zurück
            /// </summary>
            return result;
        }
        /// <summary>
        /// Gibt die Anzahl der gespeicherten Werte zurück.
        /// </summary>
        /// <returns>
        /// Die Anzahl der bisher hinzugefügten Werte.
        /// </returns>        
        public int count()
        {
            return values.Length;
        }
    }