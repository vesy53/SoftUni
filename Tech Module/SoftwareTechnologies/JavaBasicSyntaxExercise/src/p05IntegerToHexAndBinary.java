import java.util.Scanner;

public class p05IntegerToHexAndBinary {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        int decimalNum = scan.nextInt();

        System.out.println(Integer.toHexString(decimalNum).toUpperCase());
        System.out.println(Integer.toBinaryString(decimalNum));
    }
}
