package main;

import main.alphabet.All;
import main.crypto.Cezar;
import main.crypto.Util;
import main.crypto.Vigener;

import java.io.FileNotFoundException;
import java.io.PrintStream;
import java.util.Arrays;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        String sourceText = Util.getBodyFile("source.txt").toLowerCase();
        long beforeCezarEncode = System.currentTimeMillis();
        String encoded = Cezar.encode(sourceText, All.CYRILLIC, 7, 10);
        long cezarExecuting = (System.currentTimeMillis() - beforeCezarEncode);
        System.setOut(new PrintStream("encodedCezar.txt"));
        System.out.println(encoded);
        System.out.println("Execution time: " + cezarExecuting);

        String encodedText = Util.getBodyFile("encodedCezar.txt");
        long beforeCezarDecode = System.currentTimeMillis();
        String decoded = Cezar.decode(encodedText, All.CYRILLIC, 7, 10);
        long execCezarDecode = (System.currentTimeMillis() - beforeCezarDecode);

        System.setOut(new PrintStream("decodedCezar.txt"));
        System.out.println(decoded);
        System.out.println("Execution time: " + execCezarDecode);

        String keyWord = "храмых";

        long beforeVigenerEncode = System.currentTimeMillis();
        String encodedVigener = Vigener.encrypt(sourceText, All.CYRILLIC, keyWord.toLowerCase());
        long execVigenerEncode = (System.currentTimeMillis() - beforeVigenerEncode);
        System.setOut(new PrintStream("encodedVigener.txt"));
        System.out.println(encodedVigener);
        System.out.println("Execution time: " + execVigenerEncode);

        String encodedVigenerText = Util.getBodyFile("encodedVigener.txt");
        long beforeVigenerDecode = System.currentTimeMillis();
        String decodedVigener = Vigener.decrypt(encodedVigenerText, All.CYRILLIC, keyWord.toLowerCase());
        long execVigenerDecode = System.currentTimeMillis() - beforeVigenerDecode;
        System.setOut(new PrintStream("decodedVigener.txt"));
        System.out.println(decodedVigener);
        System.out.println("Execution time: " + execVigenerDecode);

        double[] sourceProbabilities = Util.getProbabilities(All.CYRILLIC, sourceText);
        double[] encodedProbabilities = Util.getProbabilities(All.CYRILLIC, encodedText);

        System.setOut(new PrintStream("probabilities.txt"));
        System.out.println("sourceProbabilities: " + Arrays.toString(sourceProbabilities));
        System.out.println("encodedProbabilities: " + Arrays.toString(encodedProbabilities));

    }
}
