import java.util.Scanner;

public class p09MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] numbersStrArr = scan.nextLine().split("\\s");

        int[] numbers = new int[numbersStrArr.length];

        for (int i = 0; i < numbersStrArr.length; i++) {
            numbers[i]=Integer.parseInt(numbersStrArr[i]);
        }

        int maxCount = 0;
        int mostFrequentNum = 0;


        for (int i = 0; i < numbers.length; i++) {
            int count = 0;

            for (int j = 0; j < numbers.length; j++) {
                if(numbers[j] == numbers[i]){
                    count++;
                }
            }

            if(count> maxCount){
                maxCount = count;
                mostFrequentNum = numbers[i];
            }
        }

        System.out.println(mostFrequentNum);
    }
}
