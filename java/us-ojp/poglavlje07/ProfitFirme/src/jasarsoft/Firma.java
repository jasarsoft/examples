/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;
import java.util.*;
/**
 *
 * @author jasarsoft
 */
public class Firma {
    private int n;                  //broj prodavnice firme
    private double[][] profit;      //tabela profita firme
    
    //konstruktor
    public Firma(int n){
        this.n = n;
    }
    
    //geter metod za polje
    public double[][] getProfit(){
        return profit;
    }
    
    public void unesiProfit(){
        profit = new double[n][12];
        Scanner tastatura = new Scanner(System.in);
        
        for(int i = 0; i < n; i++)
            for(int j = 0; j < 12; j++){
                System.out.print("Unesite profit prodavnice " + i);
                System.out.print(" za mjesec " + j + ": ");
                profit[i][j] = tastatura.nextDouble();
            }
    }
    
    public void prikaziProfit(){
        if(profit == null){
            System.out.println("Greska: podaci nisu uneseni!");
            return;
        }
        
        System.out.print("Tabela profita sa prodavnicama i mjesecima: ");
        for(int i = 0; i < n; i++){
            for(int j = 0; j < 12; j++)
                System.out.printf("%6.2f", profit[i][j]);
            
            System.out.println();
        }
    }
    
    public double godisnjiProfit(){
        double ukupniProfit = 0;
        for(int i = 0; i < n; i++)
            for(int j= 0; j < 12; j++)
                ukupniProfit += profit[i][j];
        
        return ukupniProfit;
    }
    
    private double profitZaMjesec(int m){
        double mjesecniProfit = 0;
        for(int i = 0; i < n; i++)
            mjesecniProfit += profit[i][m];
        
        return mjesecniProfit;
    }
    
    public void prikaziProfitPoMjesecima(){
        if(profit == null){
            System.out.println("Greska podaci nisu uneseni!");
            return;
        }
        
        System.out.println("Ukupni profit prodavnica po mjesecima: ");
        for(int m = 0; m < 12; m++)
            System.out.printf("%6.2f", profitZaMjesec(m));
        
        System.out.println();
    }
    
    public void prikaziProfitPoProdavnicama(){
        if(profit == null){
            System.out.println("Greska, podaci nisu uneseni!");
            return;
        }
        
        double[] profitProdavnice = new double[n];
        for(int i = 0; i < n; i++)
            for(int j = 0; j < 12; j++)
                profitProdavnice[i] += profit[i][j];
        
        System.out.println("Ukupni profit firme po prodavnicama: ");
        for(int i = 0; i < n; i++){
            System.out.print("Prodavnica " + i + ": ");
            System.out.printf("%7.2f", profitProdavnice[i]);
            System.out.println();
        }
    }
}
