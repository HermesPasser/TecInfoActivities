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
public class Professor {
    private String registro;
    private String titulacao;
    private int nrAulasMinistradas;//
    private double valorHoraAula;
    private String periodo;
    
    public void setRegistro(String x){
        registro=x;
    }
    public String getRegistro(){
        return registro;
    }
    
    public void setNrAulasMinistradas(int x){
        nrAulasMinistradas=x;
    }
    public int getNrAulasMinistradas(){
        return nrAulasMinistradas;
    } 
    
    public void setValorHoraAula(double x){
        valorHoraAula=x;
    }
    public double getValorHoraAula(){
        return valorHoraAula;
    }
    
    public void setPeriodo(String x){
        periodo=x;
    }
    public String getPeriodo(){
        return periodo;
    }
   
    public double calculoValeAlimentacao(){
        int vale=0;
        if (nrAulasMinistradas==5){
            vale +=1;
        }
        return vale;
    }
    public double calculoSalario(){
        if (periodo.equals("D")){
           return nrAulasMinistradas*valorHoraAula;
        }
        else { 
           return (nrAulasMinistradas*valorHoraAula)*0.02;
        }
    }
}
