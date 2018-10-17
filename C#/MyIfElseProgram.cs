using System;
using System.Collections.Generic;

public class Program{
  public static void Main(Stirng[] args){
    bool whetherIWon = false;
    
    var myName = Console.ReadLine();
    
    if (myName.StartsWith("P")){
      whetherIWon = true; //removed bool as var type had already been defined as a bool before the if statement
    }
    
    if (whetherIWon){
      Console.WriteLine("I won");
    }else{
      Console.WriteLine("I loose");
    }
    Console.ReadLine(); //makes program wait for user input before closing allowing user to read the output
  }
}
