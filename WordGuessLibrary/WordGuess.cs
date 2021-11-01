using System.Collections.Generic;
using System.Text;

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
			StringBuilder wordTemporary = new StringBuilder(word);
			for(int i = 0; i < positions.Length; i++)
                wordTemporary[positions[i]] = '*';
			return wordTemporary.ToString();
		}

		public static bool IsWord(string word) => word == "Apple" ? true : (word == "Яблоко" ? true : false);
	}
}