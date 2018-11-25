import java.util.Scanner;

public class SlotMachine {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        try {
            System.out.print("Enter 1st symbol: ");
            char n = scanner.nextLine().charAt(0);                  //char from the 1st pair
            while (n < ' ' || n > '~') {
                System.out.print("Invalid input. Try again! Keep in mind that " +
                        "the position of the 1st symbol in the ASCII table could be from 32 to 126: ");
                n = scanner.nextLine().charAt(0);
            }

            System.out.print("Enter 1st integer: ");
            int n1 = Integer.parseInt(scanner.nextLine());          //integer from the 1st pair
            while (n1 < 1 || n1 > 93) {
                System.out.print("Invalid input. Try again! Keep in mind that " +
                        "the integer must be in the range from 1 to 93: ");
                n1 = Integer.parseInt(scanner.nextLine());
            }

            System.out.print("Enter 2nd symbol: ");
            char m = scanner.nextLine().charAt(0);                  //char from the 2nd pair
            while (m < ' ' || m > '~') {
                System.out.print("Invalid input. Try again! Keep in mind that " +
                        "the position of the 1st symbol in the ASCII table could be from 32 to 126: ");
                m = scanner.nextLine().charAt(0);
            }

            System.out.print("Enter 2nd integer: ");
            int m1 = Integer.parseInt(scanner.nextLine());          //integer from the 2nd pair
            while (m1 < 1 || m1 > 93) {
                System.out.print("Invalid input. Try again! Keep in mind that " +
                        "the integer must be in the range from 1 to 93: ");
                m1 = Integer.parseInt(scanner.nextLine());
            }

            System.out.print("Enter 3rd symbol: ");
            char k = scanner.nextLine().charAt(0);                  //char from the 3rd pair
            while (k < ' ' || k > '~') {
                System.out.print("Invalid input. Try again! Keep in mind that " +
                        "the position of the 1st symbol in the ASCII table could be from 32 to 126: ");
                k = scanner.nextLine().charAt(0);
            }

            System.out.print("Enter 3rd integer: ");
            int k1 = Integer.parseInt(scanner.nextLine());          //integer from the 3rd pair
            while (k1 < 1 || k1 > 93) {
                System.out.print("Invalid input. Try again! Keep in mind that " +
                        "the integer must be in the range from 1 to 93: ");
                k1 = Integer.parseInt(scanner.nextLine());
            }

            int n2 = (int) n + n1;              //sum from the 1st pair
            int m2 = (int) m + m1;              //sum from the 2nd pair
            int k2 = (int) k + k1;              //sum from the 3rd pair

            char n3 = (char) n2;                //combination from the 1st pair
            char m3 = (char) m2;                //combination from the 2nd pair
            char k3 = (char) k2;                //combination from the 3rd pair

            if (n3 == '7' && m3 == '7' && k3 == '7') {                          //case win
                System.out.printf("777\n*** JACKPOT ***\n");
            } else if (n3 == '@' && m3 == '@' && k3 == '@') {                   //case lose
                System.out.printf("@@@\n!!! YOU LOSE EVERYTHING !!!\n");
            } else {                                                            //all the rest cases
                System.out.print(n3);
                System.out.print(m3);
                System.out.println(k3);
            }

        } catch (Exception ex) {
            System.out.println("Invalid input! Please, start from the beginning!");
        }
    }
}