import Alphabets.ASCIIAlphabet;
import Alphabets.All;
import Alphabets.Alphabet;

import java.io.FileNotFoundException;
import java.io.PrintStream;

public class Main {
    public static void main(String[] args) throws FileNotFoundException {

        Alphabet cyrillic = new Alphabet(All.CYRILLIC, "c.txt");
        Alphabet latin = new Alphabet(All.LATIN, "l.txt");
        Alphabet binary = new Alphabet(All.BINARY, "b.txt");
        Alphabet kvo = new Alphabet(All.LATIN, "kvo.txt");
        ASCIIAlphabet kvoASCII = new ASCIIAlphabet(All.ASCII_BINARY, "kvoASCII.txt");
        ASCIIAlphabet kvoASCIIBinary = new ASCIIAlphabet(All.ASCII_BINARY, "kvoASCII.txt");
        ASCIIAlphabet kvoASCIIBinaryWithProbability = new ASCIIAlphabet(All.ASCII_BINARY, "kvoASCII.txt");

        cyrillic.toCount();
        latin.toCount();
        binary.toCount();
        kvo.toCount();
        kvoASCII.toCount();
        kvoASCIIBinary.toCountBinary();
        kvoASCIIBinaryWithProbability.toCountBinaryWithProbability(binary.getProbability());

        System.setOut(new PrintStream("out.txt"));

        System.out.println("\n------- for c.txt --------");
        System.out.println(cyrillic.toString());

        System.out.println("\n------- for l.txt -------");
        System.out.println(latin.toString());

        System.out.println("\n------- for b.txt -------");
        System.out.println(binary.toString());

        System.out.println("\n------- for kvo.txt -------");
        System.out.println(kvo.toString());

        System.out.println("\n------- for kvoASCII.txt -------");
        System.out.println(kvoASCII.toString());

        System.out.println("\n------- for kvoASCIIBinary.txt -------");
        System.out.println(kvoASCIIBinary.toBinaryString());

        System.out.println("\n------- for kvoASCIIBinaryWithProbability.txt -------");
        System.out.println(kvoASCIIBinaryWithProbability.toBinaryString());


    }
}
