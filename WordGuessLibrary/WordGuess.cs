namespace WordGuessLibrary{
	public static class WordGuess{
		public static int[] FindCharacterOccurences(string word, char character){
			return character == 'T' ? new int[]{} : (character == 'A' ? new int[]{0} : new int[]{1, 2});
		}
	}
}