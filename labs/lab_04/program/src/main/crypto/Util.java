package main.crypto;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

/**
 * GCD1 and ReverseMod methods для подсчёта числа обратного по модулю
 * nodForTwo для проверки чисел (взаимнопростые ли они)
 * getBodyFile - для считывания текста из файла
 * class Tmp для работы с числами как с ссылками
 */

public class Util {


    private static int GCD1(int a, int b, Tmp x, Tmp y) {
        if (nodForTwo(a, b) != 1) {
            throw new ArithmeticException();
        } else {
            if (a == 0) {
                x.setNum(0);
                y.setNum(1);
                return b;
            }
            Tmp x1 = new Tmp(0);
            Tmp y1 = new Tmp(0);
            int d = GCD1(b % a, a, x1, y1);
            x.setNum(y1.getNum() - (b / a) * x1.getNum());
            y.setNum(x1.getNum());
            return d;
        }

    }

    public static int ReverseMod(int a, int m) {
        Tmp x = new Tmp(0);
        Tmp y = new Tmp(0);
        int g = GCD1(a, m, x, y);
        if (g != 1)
            throw new RuntimeException();
        return (x.getNum() % m + m) % m;
    }


    // for find NOD

    public static int nodForTwo(int a, int b) {
        while (b != 0) {
            var t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    static class Tmp {
        public int num;

        public Tmp(int num) {
            this.num = num;
        }

        public int getNum() {
            return num;
        }

        public void setNum(int num) {
            this.num = num;
        }
    }

    public static double[] getProbabilities(char[] alphabet, String text) {
        double[] probabilities = new double[alphabet.length];
        char[] numbers = new char[alphabet.length];
        int countSymbols = 0;

        int i = 0;
        int j = 0;
        while (text.length() > i) {
            j = 0;
            while (alphabet.length > j) {
                if (alphabet[j] == text.charAt(i)) {
                    numbers[j]++;
                    countSymbols++;
                }
                j++;
            }
            i++;
        }

        i = 0;
        while (alphabet.length > i) {
            if (numbers[i] != 0) {
                probabilities[i] = (double) numbers[i] / countSymbols;
            }
            i++;
        }
        return probabilities;
    }

    public static String getBodyFile(String path) {
        StringBuilder str = new StringBuilder();
        try (FileReader fileReader = new FileReader(path)) {
            int c;
            while ((c = fileReader.read()) != -1) {
                str.append((char) c);
            }
        } catch (FileNotFoundException e) {
            System.err.println("File not found!");
        } catch (IOException e) {
            e.printStackTrace();
        }
        return str.toString().toLowerCase();
    }


}
