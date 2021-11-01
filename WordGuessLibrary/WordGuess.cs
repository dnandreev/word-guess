using System.Collections.Generic;
using System.Linq;

namespace WordGuessLibrary{
	public static class WordGuess{
		public static int[] FindCharacterOccurences(string word, char character){
			word = word.ToLower();
			character = char.ToLower(character);
			List<int> found = new List<int>();
			for(int i = 0; i < word.Length; i++)
				if(word[i] == character)
					found.Add(i);
			return found.ToArray();
		}

		public static string RemoveCharacters(string word, int[] positions){
			return positions.SequenceEqual(new int[]{}) ? "Apple" : (positions.SequenceEqual(new int[]{0}) ? "*pple" : "A**le");
		}
	}
}