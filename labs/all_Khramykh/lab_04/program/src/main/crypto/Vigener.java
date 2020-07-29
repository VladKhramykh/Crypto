package main.crypto;

public class Vigener {

    public static String encrypt(String text, char[] alphabet, String keyWord) {
        StringBuilder result = new StringBuilder();
        int alphabetLength = alphabet.length;
        int keyWordLength = keyWord.length();
        int textLength = text.length();
        int keyWordIndex = 0;
        String alphabetString = String.valueOf(alphabet);

        for (int i = 0; i < textLength; i++) {
            if(alphabetString.indexOf(text.charAt(i)) > 0) {
                int num = (alphabetString.indexOf(text.charAt(i)) + alphabetString.indexOf(keyWord.charAt(keyWordIndex))) % alphabetLength;
                result.append(alphabetString.charAt(num));
                keyWordIndex++;

                if ((keyWordIndex + 1) == keyWordLength)
                    keyWordIndex = 0;
            }
        }
        return result.toString();
    }

    public static String decrypt(String text, char[] alphabet, String keyWord) {
        StringBuilder result = new StringBuilder();
        int alphabetLength = alphabet.length;
        int keyWordLength = keyWord.length();
        int textLength = text.length();
        int keyWordIndex = 0;
        String alphabetString = String.valueOf(alphabet);

        for (int i = 0; i < textLength; i++) {
            int num = (alphabetString.indexOf(text.charAt(i)) + alphabetLength - alphabetString.indexOf(keyWord.charAt(keyWordIndex))) % alphabetLength;
            result.append(alphabetString.charAt(num));
            keyWordIndex++;

            if ((keyWordIndex + 1) == keyWordLength)
                keyWordIndex = 0;
        }
        return result.toString();
    }


}
