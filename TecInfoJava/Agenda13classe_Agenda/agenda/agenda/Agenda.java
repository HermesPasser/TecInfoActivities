package agenda;

import java.util.Scanner;

public class Agenda {
     String[][] agenda = new String[4][10];

  public void cadastro(){
        for(int contL = 0; contL < 10; contL++){
            for(int contC = 0; contC < 10; contC++){
            	System.out.println("Coluna "+contC+", linha "+contL);
            	Scanner entrada = new Scanner(System.in);
                agenda[contL][contC] = entrada.next();
                entrada.close();
            }
        }
    }
}