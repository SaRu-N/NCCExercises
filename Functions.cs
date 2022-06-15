namespace NCClabs{
    public class Functions{
    public void FunctionOne(int i){
        int[] ints =new int[] {1,2,3,4,5,6,7,8,9,10};
        foreach(var item in ints){
            if(i==item){
                return;
            }
        }
    }
    public void FunctionTwo(int a, string b){
        // do something
    }
    public void FunctionThree (int[] a){

    }
    public void FunctionFour(params int[] a){

    }
    public void FunctionFive(int a, int b, out int res){
        a++;
        b++;
            res=a+b;
    }
    public int Functionv1(int a, int b){
        return a+b;
    }
    //this can be done as  public int Functionv1(int a, int b)=>a+b;
    public void FunctionSix(in int a,in int b, out int res){
        // a++;
        // b++; gives error as and b are read only variable
            res=a+b;
    }
    //use of ref(shows behaviour of pointer) adds value to the adress
    public void FunctionSeven(int a, int b, ref int res){ 
 res= a+b;
//  System.Console.WriteLine(res);
 }
}
}