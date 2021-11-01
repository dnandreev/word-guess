using WordGuessLibrary;
using static System.Console;

namespace WordGuessGame{
	internal class Program{
		static void Main(string[] args){
			string word;
			do{
				Write("Введите слово: ");
				word = ReadLine();
			}
			while(!WordGuess.IsWord(word));
			string wordGuessed = new string('*', word.Length);
			Write("Опишите слово: ");
			string description = ReadLine();
			do{
				char character;
				do{
					Clear();
					WriteLine("Слово: " + wordGuessed);
					WriteLine("Описание: " + description);
					Write("Введите букву: ");
					string input = ReadLine();
					character = (input.Length == 1 && char.IsLetter(input[0])) ? input[0] : '*';
				}
				while(character == '*');
				wordGuessed = WordGuess.ShowCharacters(word, wordGuessed, WordGuess.FindCharacterOccurences(word, character));
			}
			while(!WordGuess.IsWord(wordGuessed));
			WriteLine($"Слово \"{wordGuessed}\" отгадано!");
			WriteLine("Оно значило: " + description);
		}
	}
}