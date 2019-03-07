import java.util.Scanner;

public class p13ReverseString {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[] symbols = scan.nextLine().toCharArray();

        for (int i = symbols.length-1; i >= 0; i--) {
            System.out.print(symbols[i]);
        }
    }
}
