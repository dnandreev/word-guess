using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordGuessLibrary;

namespace WordGuessLibraryTests{
	[TestClass] public class WordGuessTests{
		[TestMethod] public void FindCharacterOccurences_AppleAndT_ExpectedEmpty() => CollectionAssert.AreEqual(new int[]{}, WordGuess.FindCharacterOccurences("Apple", 'T'));

		[TestMethod] public void FindCharacterOccurences_AppleAndA_Expected0() => CollectionAssert.AreEqual(new int[]{0}, WordGuess.FindCharacterOccurences("Apple", 'A'));

		[TestMethod] public void FindCharacterOccurences_AppleAndA_Expected1And2() => CollectionAssert.AreEqual(new int[]{1, 2}, WordGuess.FindCharacterOccurences("Apple", 'P'));
	}
}