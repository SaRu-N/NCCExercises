using System;
namespace NCClabs{
    public class nonstaticclass{
    public int i=10;
    public static int a=2; //garna chai milxa tara static member le non static access garna mildaina
public  void FunctionOne(){
   // staticfn(); //can be called
    i++;
    istatic++;
    Console.WriteLine($"i={i}& istatic={istatic}");
}
public static int istatic=10;
//public static void staticfn(){
   // FunctionOne(); //cannot access
//}
public nonstaticclass(){
}
}
public static class staticclass{
    //cannot write public void FunctionOne must have static member
    public static int i=10;
  

public static void FunctionOne(){
}
 static staticclass(){ //esma public rakhna paudaina

}
}

}