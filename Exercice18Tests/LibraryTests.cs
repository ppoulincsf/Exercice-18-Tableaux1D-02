using Xunit;
using Exercice18;

namespace Exercice18Test
{

  public class LibraryTest
  {
    /*
    [Fact]
    public void Append_AppendInNotEmptyArray_ArrayWithNewElementAtTheEnd ()
    {
      // Arrange
      int[] originalArray = { 1, 2, 3 };
      const int ELEMENT_TO_APPEND = 4;
      int[] EXPECTED_ARRAY = { 1, 2, 3, ELEMENT_TO_APPEND };

      // Act
      int[] arrayWithNewElement = Library.Append (originalArray, ELEMENT_TO_APPEND);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, arrayWithNewElement);
    }

    // A COMPLETER
    // Ajouter un test pour tester l'ajout dans un tableau vide

    */
    /*
    [Fact]
    public void Difference_OnlyFirstElementRemoved_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 1 };
      int[] EXPECTED_ARRAY = { 2, 3 };

      // Act
      int[] differenceArray = Library.Difference (array1, array2);

      // Assert

      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }
    
    [Fact]
    public void Difference_OnlyLastElementRemoved_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 3 };
      int[] EXPECTED_ARRAY = { 1, 2 };

      // Act
      int[] differenceArray = Library.Difference (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
      Assert.Equal (new int[0], Library.Difference (new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
    }

    [Fact]
    public void Difference_AllElementRemoved_EmptyArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] EXPECTED_ARRAY = { };

      // Act
      int[] differenceArray = Library.Difference (array1, array1);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void Difference_LastElementsRemovedIgnoringOrder_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 3, 2 };
      int[] EXPECTED_ARRAY = { 1 };

      // Act
      int[] differenceArray = Library.Difference (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void Difference_FirstElementsRemovedIgnoringOrder_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 2, 1 };
      int[] EXPECTED_ARRAY = { 3 };

      // Act
      int[] differenceArray = Library.Difference (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }

    [Fact]
    public void Difference_FirstAndLastElementsRemovedIgnoringOrder_CorrespondingArray ()
    {
      // Arrange
      int[] array1 = { 1, 2, 3 };
      int[] array2 = { 3, 1 };
      int[] EXPECTED_ARRAY = { 2 };

      // Act
      int[] differenceArray = Library.Difference (array1, array2);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, differenceArray);
    }


    // A COMPLETER
    // Ajoutez les tests pour les situations décrites dans l'énoncé.

    */
    
    
    
    /*
    [Fact]
    public void Reverse_NotEmptyArrayOf3Elements_ArrayInReverseOrder ()
    {
      // Arrange
      int[] originalArray = { 1, 2, 3 };
      int[] EXPECTED_ARRAY = { 3, 2, 1 };

      // Act
      int[] reverseArray = Library.Reverse (originalArray);

      // Assert
      Assert.Equal (EXPECTED_ARRAY, reverseArray);
    }

    // A COMPLETER
    // Ajoutez les tests pour les situations décrites dans l'énoncé.

    */
  }
}