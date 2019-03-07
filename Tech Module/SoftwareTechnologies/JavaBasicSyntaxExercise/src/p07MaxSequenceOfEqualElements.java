import java.util.Scanner;

public class p07MaxSequenceOfEqualElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] numStrArr = scan.nextLine().split("\\s");

        int[] numbersArr = new int[numStrArr.length];

        for(int i = 0; i < numStrArr.length; i++) {
            numbersArr[i] = Integer.parseInt(numStrArr[i]);
        }

        int maxLength = -1;
        int endIndex = 0;
        int length = 0;

        for (int i = 0; i < numbersArr.length - 1; i++) {
            if (numbersArr[i] == numbersArr[i + 1]) {
                length++;
                if (i + 1 == numbersArr.length - 1 && maxLength < length) {
                    maxLength = length;
                    endIndex = i + 1;
                }
            }
            else {
                if (maxLength < length) {
                    maxLength = length;

                    endIndex = i;
                }

                length = 0;
            }
        }

        for (int i = 0; i < maxLength + 1; i++) {
            System.out.print(numbersArr[endIndex] + " ");
        }
    }
}
