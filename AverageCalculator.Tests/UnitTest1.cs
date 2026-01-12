using AverageCalculator;
 
/// <summary>
/// Diese Klasse enthält Tests für den AverageCalculator
/// </summary>
public class AverageCalculatorTests
{
    /// <summary>
    /// Prüft ob ein Wert hinzugefügt wird
    /// und ob die Anzahl dann genau 1 ist
    /// </summary>
    [Fact]
    public void Add_SingleValue_IncreasesCount()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(5);
        Assert.Equal(1, calculator.count());
    }
 
    /// <summary>
    /// Prüft ob der Durchschnitt bei einem Wert genau dieser Wert ist
    /// </summary>
    [Fact]
    public void Add_SingleValue_AverageIsValue()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(10);
        Assert.Equal(10, calculator.getAverage());
    }
 
    /// <summary>
    /// Prüft ob zwei Werte hinzugefügt werden
    /// und ob die Anzahl dann 2 ist
    /// </summary>
    [Fact]
    public void Add_MultipleSingleAdds_CountCorrect()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(5);
        calculator.add(15);
        Assert.Equal(2, calculator.count());
    }
 
    /// <summary>
    /// Testet ob ein Array hinzugefügt wird ob alle Werte gespeichert werden
    /// </summary>
    [Fact]
    public void Add_Array_AddsAllValues()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        double[] values = { 5, 10, 15 };
        calculator.add(values);
        Assert.Equal(3, calculator.count());
    }
 
    /// <summary>
    /// Prüft ob ein leeres Array nichts macht und keine Werte speichert
    /// </summary>
    [Fact]
    public void Add_EmptyArray_DoesNothing()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(new double[0]);
        Assert.Equal(0, calculator.count());
    }
 
    /// <summary>
    /// Prüft ob ein null Array nichts macht
    /// </summary>
    [Fact]
    public void Add_NullArray_DoesNothing()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add((double[])null);
        Assert.Equal(0, calculator.count());
    }
 
    /// <summary>
    /// Prüft ob der Durchschnitt ohne Werte Null ist
    /// </summary>
    [Fact]
    public void GetAverage_NoValues_ReturnsZero()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        Assert.Equal(0, calculator.getAverage());
    }
 
    /// <summary>
    /// Prüft ob der Durchschnitt bei einem Wert der gleiche wie der Wert selbst ist
    /// </summary>
    [Fact]
    public void GetAverage_OneValue_ReturnsValue()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(8);
        Assert.Equal(8, calculator.getAverage());
    }
 
    /// <summary>
    /// Testet ob der Durchschnitt bei mehreren Werten
    /// richtig gerechnet wird
    /// </summary>
    [Fact]
    public void GetAverage_MultipleValues_ReturnsCorrectAverage()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(new double[] { 10, 20, 30 });
        Assert.Equal(20, calculator.getAverage());
    }
 
    /// <summary>
    /// Prüft ob keine Werte ein leeres Array ergeben
    /// </summary>
    [Fact]
    public void GetElements_NoValues_ReturnsEmptyArray()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        Assert.Empty(calculator.getElements());
    }
 
    /// <summary>
    /// Prüft ob alle gespeicherten Werte zurückgegeben werden
    /// </summary>
    [Fact]
    public void GetElements_ReturnsAllValues()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(new double[] { 1, 2, 3 });
        double[] elements = calculator.getElements();
        Assert.Equal(3, elements.Length);
    }
 
    /// <summary>
    /// Prüft ob die Werte nur kopiert sind
    /// und nicht die echten Werte geändert werden
    /// </summary>
    [Fact]
    public void GetElements_ReturnsCopy_NotOriginalArray()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(5);
        double[] elements = calculator.getElements();
        elements[0] = 100;
        Assert.Equal(5, calculator.getAverage());
    }
 
    /// <summary>
    /// Prüft ob die Anzahl ohne Werte Null ist wenn ein Wert angegeben wird
    /// </summary>
    [Fact]
    public void Count_NoValues_ReturnsZero()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        Assert.Equal(0, calculator.count());
    }
 
    /// <summary>
    /// Prüft ob die Anzahl bei einem Wert 1 ist wenn nur ein Wert hinzugefügt wird
    /// </summary>
    [Fact]
    public void Count_OneValue_ReturnsOne()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(3);
        Assert.Equal(1, calculator.count());
    }
 
    /// <summary>
    /// Prüft ob die Anzahl bei mehreren Werten aus einem Array richtig ist
    /// </summary>
    [Fact]
    public void Count_MultipleValues_ReturnsCorrectCount()
    {
        var calculator = new AverageCalculator.AverageCalculator();
        calculator.add(new double[] { 1, 2, 3, 4 });
        Assert.Equal(4, calculator.count());
    }
}

 