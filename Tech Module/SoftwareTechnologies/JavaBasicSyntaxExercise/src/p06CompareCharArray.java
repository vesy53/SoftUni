import java.util.Scanner;

public class p06CompareCharArray {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] firstCharArr = scan.nextLine().split("\\s");
        String[] secondCharArr = scan.nextLine().split("\\s");

        //int minLength = Math.min(firstCharArr.length, secondCharArr.length);

        if(firstCharArr.length < secondCharArr.length) {
            System.out.println(String.join("", firstCharArr));
            System.out.println(String.join("", secondCharArr));
        } else if(firstCharArr.length > secondCharArr.length) {
            System.out.println(String.join("", secondCharArr));
            System.out.println(String.join("", firstCharArr));
        } else {
            int result = firstCharArr[0].compareTo(secondCharArr[0]);

            if(result >= 1) {
                System.out.println(String.join("", secondCharArr));
                System.out.println(String.join("", firstCharArr));
            } else {
                System.out.println(String.join("", firstCharArr));
                System.out.println(String.join("", secondCharArr));
            }
        }
    }
}
