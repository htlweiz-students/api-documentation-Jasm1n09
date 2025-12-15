using System;

namespace AverageCalculator;
/// <summary>
/// Das ist die Klasse AverageCalculator die die Werte speichert und danach berechnet.
/// </summary>
    public class AverageCalculator
    {
        /// <summary>
        /// 
        /// </summary>
        private double[] values;
 
        public AverageCalculator()
        {
            values = new double[0];
        }
 
        public void add(double value)
        {
            double[] newArray = new double[values.Length + 1];
 
            for (int count = 0; count < values.Length; count++)
            {
                newArray[count] = values[count];
            }
 
            newArray[values.Length] = value;
            values = newArray;
        }
 
        public void add(double[] newValues)
        {
            if (newValues == null || newValues.Length == 0)
            {
                return;
            }
 
            double[] newArray = new double[values.Length + newValues.Length];
 
            for (int count = 0; count < values.Length; count++)
            {
                newArray[count] = values[count];
            }
 
            for (int count = 0; count < newValues.Length; count++)
            {
                newArray[values.Length + count] = newValues[count];
            }
 
            values = newArray;
        }
 
        public double getAverage()
        {
            if (values.Length == 0)
            {
                return 0;
            }
 
            double sum = 0;
 
            for (int count = 0; count < values.Length; count++)
            {
                sum += values[count];
            }
 
            return sum / values.Length;
        }
 
        public double[] getElements()
        {
            double[] result = new double[values.Length];
 
            for (int count = 0; count < values.Length; count++)
            {
                result[count] = values[count];
            }
 
            return result;
        }
 
        public int count()
        {
            return values.Length;
        }
    }
 
 