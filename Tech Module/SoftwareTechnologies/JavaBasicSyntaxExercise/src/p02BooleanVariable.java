import java.util.Scanner;

public class p02BooleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        boolean booleanVar = scan.nextBoolean();

        if(booleanVar){
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }
}
