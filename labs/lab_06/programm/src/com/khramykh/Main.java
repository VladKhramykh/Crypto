package com.khramykh;

public class Main {
    public static void main(String[] args) {
        String alphabet = Rotors.ALPHABET;

        String rotor2 = Rotors.ROTOR2;
        String rotor3 = Rotors.ROTOR3;
        String rotor5 = Rotors.ROTOR5;
        String[] cReflector = Rotors.C_REFLECTOR;

        String text = "KHRAMYKHVLAD";

        StringBuilder builder = new StringBuilder();

//        rotor2 = Rotors.moveRotor(rotor2.toCharArray());
//        rotor3 = Rotors.moveRotor(rotor3.toCharArray());
//        rotor3 = Rotors.moveRotor(rotor3.toCharArray());
//        rotor3 = Rotors.moveRotor(rotor3.toCharArray());
//        rotor5= Rotors.moveRotor(rotor5.toCharArray());
//        rotor5 = Rotors.moveRotor(rotor5.toCharArray());
//        rotor5 = Rotors.moveRotor(rotor5.toCharArray());


        System.out.println("Rotors start positions: " + rotor2.charAt(0) + " - " + rotor3.charAt(0) + " - " + rotor5.charAt(0));

        for (char s : text.toCharArray()) {
            char tmp = rotor5.charAt(alphabet.indexOf(s));
            System.out.print(s + ": ->" + tmp);
            tmp = rotor3.charAt(alphabet.indexOf(tmp));
            System.out.print("->" + tmp);
            tmp = rotor2.charAt(alphabet.indexOf(tmp));
            System.out.print("->" + tmp);

            for (String cStr : cReflector) {
                if (cStr.indexOf(tmp) != -1) {
                    tmp = cStr.charAt((cStr.indexOf(tmp) > 0 ? 0 : 1));
                    System.out.print("->" + tmp);
                    break;
                }
            }

            tmp = alphabet.charAt(rotor2.indexOf(tmp));
            System.out.print("->" + tmp);
            tmp = alphabet.charAt(rotor3.indexOf(tmp));
            System.out.print("->" + tmp);
            tmp = alphabet.charAt(rotor5.indexOf(tmp));
            System.out.print("->" + tmp);

            builder.append(tmp);
            System.out.println();


            rotor2 = Rotors.moveRotor(rotor2.toCharArray());
            rotor3 = Rotors.moveRotor(rotor3.toCharArray());
            rotor3 = Rotors.moveRotor(rotor3.toCharArray());
            rotor3 = Rotors.moveRotor(rotor3.toCharArray());
            rotor5=  Rotors.moveRotor(rotor5.toCharArray());
            rotor5 = Rotors.moveRotor(rotor5.toCharArray());
            rotor5 = Rotors.moveRotor(rotor5.toCharArray());

        }

        System.out.println("Source: " + text);
        System.out.println("Encrypted: " + builder);
    }
}
