
using Xunit;

public class Esercizio5Tests
{
    [Fact]
    public void RotateArray_EvenNumberOfElements()
    {
        // Arrange
        int[] numeriOriginali = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        RotateArray.Rotate(numeriOriginali);

        // Assert
        Assert.Equal(expected, numeriOriginali);
    }

    [Fact]
    public void RotateArray_OddNumberOfElements()
    {
        // Arrange
        int[] numeriOriginali = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        RotateArray.Rotate(numeriOriginali);

        // Assert
        Assert.Equal(expected, numeriOriginali);
    }

    [Fact]
    public void RotateArray_SingleElement()
    {
        // Arrange
        int[] numeriOriginali = new int[] { 1 };
        int[] expected = new int[] { 1 };

        // Act
        RotateArray.Rotate(numeriOriginali);

        // Assert
        Assert.Equal(expected, numeriOriginali);
    }

    [Fact]
    public void RotateArray_EmptyArray()
    {
        // Arrange
        int[] numeriOriginali = new int[] { };
        int[] expected = new int[] { };

        // Act
        RotateArray.Rotate(numeriOriginali);

        // Assert
        Assert.Equal(expected, numeriOriginali);
    }
}