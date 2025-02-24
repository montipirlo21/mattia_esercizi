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
            Assert.Equal(expected, result.Item1);            
            Assert.True(result.Item2 <= numeriOriginali.Length - 1);
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
            Assert.Equal(expected, result.Item1);
            Assert.True(result.Item2 <= numeriOriginali.Length - 1);
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
            Assert.Equal(expected, result.Item1);
            Assert.True(result.Item2 <= numeriOriginali.Length - 1);
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
            Assert.Equal(expected, result.Item1);
            Assert.True(result.Item2 <= numeriOriginali.Length - 1);
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
            Assert.Equal(expected, result.Item1);
            Assert.True(result.Item2 <= numeriOriginali.Length - 1);
        }

         [Fact]
        public void Sorting_SelectionSort_EservizioCitta()
        {
            // Arrange
            int[] abitanti = { 2870000, 320000, 1400000, 870000, 670000, 580000, 390000, 960000, 380000 };
            int[] expected ={ 320000, 380000, 390000, 580000, 670000, 870000, 960000 , 1400000, 2870000 };

            // Act
            var result = Sorting.SelectionSort(abitanti);

            // Assert
            Assert.Equal(expected, result.Item1);
            Assert.True(result.Item2 <= expected.Length - 1);
        }


        
         [Fact]
        public void Sorting_Insertion_element()
        {
            // Arrange
            int[] abitanti = { 320000, 380000, 390000, 580000, 670000, 870000, 960000 ,  1400000, 2870000 };
            int citta = 1_000_000;
            int[] expected ={ 320000, 380000, 390000, 580000, 670000, 870000, 960000 ,1_000_000,  1400000, 2870000 };

            // Act
            var result = Sorting.Insertion_element(abitanti,citta);

            // Assert
            Assert.Equal(expected, result);
        }

}
