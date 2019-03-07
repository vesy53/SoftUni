import java.util.Scanner;

public class p04VowelOrDigit {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
        char symbol = scan.nextLine().charAt(0);
        boolean isDigit = Character.isDigit(symbol);
        boolean isVowel = false;



        if(isDigit){
            System.out.println("digit");
        }else if (isVowel){
            System.out.println("vowel");
        }else{
            System.out.println("other");
        }
    }
}
