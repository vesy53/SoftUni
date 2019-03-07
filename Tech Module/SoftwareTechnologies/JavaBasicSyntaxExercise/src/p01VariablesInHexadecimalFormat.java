import java.util.Scanner;

public class p01VariablesInHexadecimalFormat {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        String hexadecimalNum = scan.nextLine();

        int decimalNum = Integer.parseInt(hexadecimalNum, 16);

        System.out.println(decimalNum);
    }
}
