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
public abstract class GeomOblik {
    private Color boja;
    
    private void oboji(Color novaBoja){
        boja = novaBoja;
        nacrtaj();
    }
    
    public abstract void nacrtaj(); //apstraktni metod
    
    //ostala polja i metodi...
}
