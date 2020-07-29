package Alphabets;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

public class Util {

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

    public static double roundAvoid(double value, int places) {
        double scale = Math.pow(10, places);
        return Math.round(value * scale) / scale;
    }

}
