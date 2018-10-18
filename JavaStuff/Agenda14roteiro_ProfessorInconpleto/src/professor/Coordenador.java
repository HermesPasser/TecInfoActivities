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
public class Coordenador extends Professor{
    private String cursoCoordenado;
    private int nrHoraCoord;
    
    public void setcursoCoordenado(String x){
        cursoCoordenado=x;
    }
    
    public void setHoraCoord(int x){
        nrHoraCoord=x;
    }
    
    @Override
    public double calculoSalario(){
        if (super.getPeriodo().equals("D")){
           return (super.getNrAulasMinistradas()*super.getValorHoraAula())+(nrHoraCoord*super.getValorHoraAula());
        }
        else { 
           return ((super.getNrAulasMinistradas()*super.getValorHoraAula())*0.2)+(nrHoraCoord*super.getValorHoraAula());
        }
    }
    
}
