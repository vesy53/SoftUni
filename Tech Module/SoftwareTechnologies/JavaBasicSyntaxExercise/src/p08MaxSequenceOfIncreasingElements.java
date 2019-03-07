import java.util.Scanner;

public class p08MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String [] numbersStrArr = scan.nextLine().split("\\s");

        int[] numbers = new int[numbersStrArr.length];

        for (int i = 0; i < numbersStrArr.length; i++) {
            numbers[i]=Integer.parseInt(numbersStrArr[i]);
        }

        int maxLength = -1;
        int endIndex = 0;
        int length = 0;


        for (int i = 0; i < numbers.length - 1; i++) {
            if (numbers[i] < numbers[i + 1]) {
                length++;
                if (i + 1 == numbers.length - 1 && maxLength < length) {
                    maxLength = length;
                    endIndex = i + 1;
                }
            } else {
                if (maxLength < length) {
                    maxLength = length;
                    endIndex = i;
                }

                length = 0;
            }
        }

        endIndex = endIndex - maxLength;
        for (int i = 0; i < maxLength + 1; i++)
        {
            System.out.print(numbers[endIndex] + " ");
            endIndex++;
        }
    }

}
