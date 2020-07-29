package main.crypto;

public class Cezar {
    public static String encode(String text, char[] alphabet, int a, int b) {
        int N = alphabet.length;
        int[] newPositionSystem = new int[N];
        char[] newCharSystem = new char[N];
        StringBuilder encoded = new StringBuilder();

        for (int i = 0; i < N; i++) {
            newPositionSystem[i] = (i * a + b) % N;
            newCharSystem[i] = alphabet[newPositionSystem[i]];
        }

        return fillString(text, alphabet, N, newCharSystem, encoded);
    }

    public static String decode(String text, char[] alphabet, int a, int b) {
        int N = alphabet.length;
        int[] newPositionSystem = new int[N];
        char[] newCharSystem = new char[N];
        StringBuilder encoded = new StringBuilder();
        int reverse = Util.ReverseMod(a, N);
        for (int i = 0; i < N; i++) {
            newPositionSystem[i] = (reverse * (i + N - b)) % N;
            newCharSystem[i] = alphabet[newPositionSystem[i]];
        }

        return fillString(text, alphabet, N, newCharSystem, encoded);
    }

    private static String fillString(String text, char[] alphabet, int n, char[] newCharSystem, StringBuilder encoded) {
        for (int i = 0; i < text.length(); i++) {
            for (int j = 0; j < n; j++) {
                if (alphabet[j] == text.charAt(i)) {
                    encoded.append(newCharSystem[j]);
                }
            }
        }
        return encoded.toString();
    }
}
