/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package professor;

/**
 *
 * @author Aluno_2
 */
public class Roteiro14 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Coordenador p1 = new Coordenador();
        p1.setNrAulasMinistradas(10);
        p1.setPeriodo("D");
        p1.setRegistro("asedas");
        p1.setValorHoraAula(21.0);
        System.out.println("tu tem isso de vales (não os da montanha)"+p1.calculoValeAlimentacao());
        p1.setcursoCoordenado("logistica");  
        p1.setHoraCoord(8); 
        System.out.println("teu salario "+p1.calculoSalario());
    }
    
}
