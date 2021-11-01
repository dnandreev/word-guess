﻿using System.Collections.Generic;
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

		public static string ShowCharacters(string word, string wordGuessed, int[] positions){
			StringBuilder wordTemporary = new StringBuilder(wordGuessed);
			for(int i = 0; i < positions.Length; i++)
                wordTemporary[positions[i]] = word[positions[i]];
			return wordTemporary.ToString();
		}

		public static bool IsWord(string word){
			for(int i = 0; i < word.Length; i++)
				if(!char.IsLetter(word[i]))
					return false;
			return true;
		}
	}
}