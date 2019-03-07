import java.util.Scanner;

public class p03ReverseCharacters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String firstSymbol = scan.nextLine();
        String secondSymbol = scan.nextLine();
        String thirdSymbol = scan.nextLine();

        /*char ch1 = scan.nextLine().charAt(0);
          char ch2 = scan.nextLine().charAt(0);
          char ch3 = scan.nextLine().charAt(0);

          System.out.println("%c%c%C", ch3, ch2, ch1);
         */
        System.out.println(thirdSymbol+secondSymbol+firstSymbol);
    }
}
