package Alphabets;

public class Alphabet {
    private char[] alphabet;
    private String text;
    private int[] numbers;
    private double[] probability;
    private double entropy = 0;
    private int countSymbols = 0;
    private int countDifferentSymbols;
    private double sumInfo;

    public Alphabet(char[] alphabet, String path) {
        this.alphabet = alphabet;
        this.numbers = new int[alphabet.length];
        this.probability = new double[alphabet.length];
        this.text = Util.getBodyFile(path);
    }

    public void toCount() {
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
        sumInfo = getEntropy() * countSymbols;
    }

    public char[] getAlphabet() {
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
        double tmp = 1 - error;
        result = -((error * (Math.log10(error) / Math.log10(2))) - (tmp * (Math.log10(tmp) / Math.log10(2))));
        return result;
    }

    private double getCountEffectiveInfo(double entropy, double error) {
        if (error >= 1.0) {
            return 0;
        }
        return getEntropy() - getEntropyWithError(error);
    }


    private double countSumInfo(double entropy) {
        return entropy * countSymbols;
    }

    @Override
    public String toString() {

        String result = "Длина алфавита: " + getLengthAlphabet() + "\n" +
                "Вероятности:\n" + getProbabilityWithSymbol() +
                "Энтропия Шеннона: " + getEntropy() + "\n" +
                "Эффективная энтропия при ошибке в 0.1: " + getCountEffectiveInfo(getEntropy(), 0.1) + "\n" +
                "\tКоличество информации при ошибке в 0.1: " + countSumInfo(getEntropyWithError( 0.1)) + "\n" +
                "Эффективная энтропия при ошибке в 0.5: " + getCountEffectiveInfo(getEntropy(), 0.5) + "\n" +
                "\tКоличество информации при ошибке в 0.5: " + countSumInfo(getEntropyWithError( 0.5)) + "\n" +
                "Эффективная энтропия при ошибке в 1.0: " + getCountEffectiveInfo(getEntropy(), 1.0) + "\n" +
                "\tКоличество информации при ошибке в 1.0: " + countSumInfo(getEntropyWithError( 1)) + "\n" +
                "Количество информации (без ошибок): " + countSumInfo(getEntropy()) + "\n";
        return result;

    }
}
