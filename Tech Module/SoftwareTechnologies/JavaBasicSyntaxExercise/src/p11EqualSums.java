import java.util.Scanner;

public class p11EqualSums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] numbersAsStr = scan.nextLine().split("\\s");

        int[] numbers = new int[numbersAsStr.length];

        for (int i = 0; i < numbersAsStr.length; i++) {
            numbers[i] = Integer.parseInt(numbersAsStr[i]);
        }

        boolean hasEqualSum = false;

        for (int i = 0; i < numbers.length; i++) {
            int leftSum = 0;
            for (int j = 0; j < i; j++) {
                leftSum += numbers[j];
            }

            int rightSum = 0;
            for (int j = i+1; j < numbers.length; j++) {
                rightSum+=numbers[j];
            }

            if (leftSum == rightSum) {
                System.out.println(i);
                hasEqualSum = true;
                break;
            }
        }

        if (!hasEqualSum) {
            System.out.println("no");
        }
    }
}
