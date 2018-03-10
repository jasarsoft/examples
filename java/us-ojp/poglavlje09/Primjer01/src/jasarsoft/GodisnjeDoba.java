/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jasarsoft;

/**
 *
 * @author jasarsoft
 */
public enum GodisnjeDoba {
    PROLJECE('P'),
    LJETO('L'),
    JESEN('J'),
    ZIMA('Z');
    
    private char skracenica;    //polje
    
    private GodisnjeDoba(char skracenica){ //konstruktor
        this.skracenica= skracenica;
    }
    
    public char getSkracenica(){ //getter metod
        return skracenica;
    }
}
