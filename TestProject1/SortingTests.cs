using System;
using Esercizi.Esercizi;

namespace TestProject;

public class SortingTests
{
        [Fact]
        public void Sorting_SelectionSort_Test1()
        {
            // Arrange
            int[] numeriOriginali = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var result = Sorting.SelectionSort(numeriOriginali);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sorting_SelectionSort_Test2()
        {
            // Arrange
            int[] numeriOriginali = new int[] { 10, 7, 6, 2, 1 };
            int[] expected = new int[] { 1, 2, 6, 7, 10 };

            // Act
            var result = Sorting.SelectionSort(numeriOriginali);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sorting_SelectionSort_Test3()
        {
            // Arrange
            int[] numeriOriginali = new int[] { 10, 9, 8, 7, 6, 1, 1, 1, 1, 1 };
            int[] expected = new int[] { 1, 1, 1, 1, 1, 6, 7, 8, 9, 10 };

            // Act
            var result = Sorting.SelectionSort(numeriOriginali);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sorting_SelectionSort_Test4()
        {
            // Arrange
            int[] numeriOriginali = new int[] { 1 };
            int[] expected = new int[] { 1 };

            // Act
            var result = Sorting.SelectionSort(numeriOriginali);

            // Assert
            Assert.Equal(expected, result);
        }

         [Fact]
        public void Sorting_SelectionSort_Test5()
        {
            // Arrange
            int[] numeriOriginali = new int[] { 0, 1 };
            int[] expected = new int[] { 0, 1 };

            // Act
            var result = Sorting.SelectionSort(numeriOriginali);

            // Assert
            Assert.Equal(expected, result);
        }
}
