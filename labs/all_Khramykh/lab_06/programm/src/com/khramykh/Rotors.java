package com.khramykh;

class Rotors {
    static String ALPHABET  = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

    static String ROTOR1    = "EKMFLGDQVZNTOWYHXUSPAIBRCJ";
    static String ROTOR2    = "AJDKSIRUXBLHWTMCQGZNPYFVOE";
    static String ROTOR3    = "BDFHJLCPRTXVZNYEIWGAKMUSQO";
    static String ROTOR4    = "ESOVPZJAYQUIRHXLNFTGKDCMWB";
    static String ROTOR5    = "VZBRGITYUPSDNHLXAWMJQOFECK";
    static String ROTOR6    = "JPGVOUMFYQBENHZRDKASXLICTW";
    static String ROTOR7    = "NZJHGRCXMYSWBOUFAIVLPEKQDT";
    static String ROTOR8    = "FKQHTLXOCBJSPDZRAMEWNIUYGV";
    static String BETA      = "LEYJVCNIXWPBQMDRTAKZGFUHOS";
    static String GAMMA     = "FSOKANUERHMBTIYCWLQPZXVGJD";

    static final String[] B_REFLECTOR       = {"AY", "BR", "CU", "DH", "EQ", "FS", "GL", "IP", "JX", "KN", "MO", "TZ", "VW"};
    static final String[] B_DUNN_REFLECTOR  = {"AE", "BN", "CK", "DQ", "FU", "GY", "HW", "IJ", "LO", "MP", "RX", "SZ", "TV"};
    static final String[] C_REFLECTOR       = {"AF", "BV", "CP", "DJ", "EI", "GO", "HY", "KR", "LZ", "MX", "NW", "TQ", "SU"};
    static final String[] C_DUNN_REFLECTOR  = {"AR", "BD", "CO", "EJ", "FN", "GT", "HK", "IV", "LM", "PW", "QS", "SX", "UY"};

    static String moveRotor(char[] rotor) {
        char[] newRotor = new String(rotor).toCharArray();
        for (int i = newRotor.length - 1; i > 0; i--) {
            newRotor[i] = newRotor[i - 1];
        }
        newRotor[0] = rotor[rotor.length - 1];
        return new String(newRotor);
    }
}
