import java.util.Scanner;

public class Test {
    public static void main(String[] args) {
        /*
        Scanner input = new Scanner(System.in);
        int a = input.nextInt();
        double b = input.nextDouble();
        String c = input.next();        //Soner Altıntaş >> Soner
        String d = input.nextLine();    //Soner Altıntaş >> Soner Altıntaş
        float e = input.nextFloat();
        */

        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Sayı-1: ");
        int s1 = input.nextInt();
        System.out.print("Sayı-2: ");
        int s2 = input.nextInt();

        System.out.println("Toplam : " + (s1+s2));
        System.out.println("Fark : " + (s1-s2));
        */

        /*
        Scanner input = new Scanner(System.in);
        System.out.print("Vize Notu: ");
        float vize = input.nextFloat();
        System.out.print("Final Notu: ");
        float finalnotu = input.nextFloat();
        float ort =(vize*0.4f)+(finalnotu*0.6f);
        System.out.print("Ortalama: "+ort);
         */

        Scanner input = new Scanner(System.in);
        System.out.print("Derece: ");
        int sicaklik = input.nextInt();
        int fahrenayt = (sicaklik*9/5)+32;
        System.out.print(sicaklik+" degerinin F karşılığı : "+fahrenayt);


    }
}
