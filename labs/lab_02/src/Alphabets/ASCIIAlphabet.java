package Alphabets;

import java.util.stream.Stream;

public class ASCIIAlphabet {
    private String[] alphabet;
    private String text;
    private int[] numbers;
    private double[] probability;
    private double entropy = 0;
    private int countSymbols = 0;
    private int countDifferentSymbols;
    private double sumInfo;

    public ASCIIAlphabet(String[] asciiBinary, String path) {
        this.alphabet = asciiBinary;
        this.numbers = new int[alphabet.length];
        this.probability = new double[alphabet.length];
        this.text = Util.getBodyFile(path);
    }

    public void toCount() {
        int i = 0;
        int j = 0;

        text = text.replaceAll(" ", "");

        try {
            while (text.length() > i) {
                j = 0;
                while (alphabet.length > j) {
                    if (alphabet[j].equals(text.substring(i, i + 8))) {
                        numbers[j]++;
                        countSymbols++;
                    }
                    j++;
                }
                i += 8;
            }
        } catch (StringIndexOutOfBoundsException ex) {
            System.out.println(ASCIIAlphabet.class + ":toCount() - Wrong source text");
        }

        i = 0;
        while (alphabet.length > i) {
            if (numbers[i] != 0) {
                probability[i] = (double) numbers[i] / countSymbols;
                countDifferentSymbols++;
            }
            i++;
        }

        i = 0;
        while (probability.length > i) {
            if (probability[i] != 0) {
                entropy += ((Math.log(probability[i]) / Math.log(2)) * probability[i]);
            }
            i++;
        }
        sumInfo = -entropy * countSymbols;

    }

    public void toCountBinary() {

        int[] binaryNumber = new int[2];
        int i = 0;

        text = text.replaceAll(" ", "");

        Stream<Character> characterStream = text.chars().mapToObj(c -> (char) c);
        binaryNumber[0] = (int) characterStream.filter(c -> c == '0').count();
        characterStream.close();
        binaryNumber[1] = text.length() - binaryNumber[0];

        i = 0;
        while (binaryNumber.length > i) {
            if (binaryNumber[i] != 0) {
                probability[i] = (double) binaryNumber[i] / (binaryNumber[1] + binaryNumber[0]);
            }
            i++;
        }

        i = 0;
        while (probability.length > i) {
            if (probability[i] != 0) {
                entropy += ((Math.log(probability[i]) / Math.log(2)) * probability[i]);
            }
            i++;
        }
    }

    public void toCountBinaryWithProbability(double[] probability) {
        int i = 0;
        this.probability = probability;
        while (probability.length > i) {
            if (probability[i] != 0) {
                entropy += ((Math.log(probability[i]) / Math.log(2)) * probability[i]);
            }
            i++;
        }
    }


    public String[] getAlphabet() {
        return alphabet;
    }

    public int[] getNumbers() {
        return numbers;
    }

    public double[] getProbability() {
        return probability;
    }

    public double getEntropy() {
        return -entropy;
    }

    public double getSumInfo() {
        return sumInfo;
    }

    public int getLengthAlphabet() {
        return countDifferentSymbols;
    }

    public String getProbabilityWithSymbol() {
        int c = 0;
        StringBuilder stringBuilder = new StringBuilder();
        while (getProbability().length > c) {
            stringBuilder.append("\t" + alphabet[c] + " - " + probability[c] + "\n");
            c++;
        }
        return stringBuilder.toString();
    }

    private double getEntropyWithError(double error) {
        double result = 0.0;
        double tmp = Util.roundAvoid(1 - error, 2);
        result = -((error * (Math.log10(error)/Math.log10(2))) - (tmp * (Math.log10(tmp)/Math.log10(2))));
        return result;
    }

    private double getCountEffectiveInfo(double entropy, double error) {
        if (error >= 1.0) {
            return 0;
        }
        return getEntropy() - getEntropyWithError(error);
    }

    private double countSumInfo(double entropy) {
        return entropy * text.length();
    }

    @Override
    public String toString() {
        String result = "Длина алфавита: " + getLengthAlphabet() + "\n" +
                "Вероятности:\n" + getProbabilityWithSymbol() +
                "Энтропия Шеннона: " + getEntropy() + "\n" +
                "Эффективная энтропия при ошибке в 0.1: " + getCountEffectiveInfo(getEntropy(), 0.1) + "\n" +
                "\tКоличество информации при ошибке в 0.1: " + countSumInfo(getCountEffectiveInfo(getEntropy(), 0.1)) + "\n" +
                "Эффективная энтропия при ошибке в 0.5: " + getCountEffectiveInfo(getEntropy(), 0.5) + "\n" +
                "\tКоличество информации при ошибке в 0.5: " + countSumInfo(getCountEffectiveInfo(getEntropy(), 0.5)) + "\n" +
                "Эффективная энтропия при ошибке в 1.0: " + getCountEffectiveInfo(getEntropy(), 1.0) + "\n" +
                "\tКоличество информации при ошибке в 1.0: " + countSumInfo(getCountEffectiveInfo(getEntropy(), 1)) + "\n" +
                "Количество информации (без ошибок): " + getSumInfo() + "\n";
        return result;

    }

    public String toBinaryString() {
        String result = "Длина алфавита: 2" + "\n" +
                "Вероятности:\n" + "0 - " + probability[0] + "\n1 - " + probability[1] + "\n" +
                "Энтропия Шеннона: " + getEntropy() + "\n" +
                "Эффективная энтропия при ошибке в 0.1: " + getCountEffectiveInfo(getEntropy(), 0.1) + "\n" +
                "\tКоличество информации при ошибке в 0.1: " + countSumInfo(getEntropyWithError( 0.1))  + "\n" +
                "Эффективная энтропия при ошибке в 0.5: " + getCountEffectiveInfo(getEntropy(), 0.5) + "\n" +
                "\tКоличество информации при ошибке в 0.5: " + countSumInfo(getEntropyWithError( 0.5))  + "\n" +
                "Эффективная энтропия при ошибке в 1.0: " + getCountEffectiveInfo(getEntropy(), 1.0) + "\n" +
                "\tКоличество информации при ошибке в 1.0: " + countSumInfo(getEntropyWithError( 1))  + "\n" +
                "Количество информации (без ошибок): " + getSumInfo() + "\n";
        return result;

    }
}

