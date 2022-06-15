using System.Text;
namespace NCClabs
{
    class Program
    {
    public static void Main(){
          string choice="N";
          do{
            // classExample();
            // classandobjectexample();  
            // PropertiesExample();
            // Stringfunction();
            // EnumsExample();
            // FunctionsExample();
            //  LoopingStatements();
            //  ShapesExample();
            ShapesExampleV2();
               
     System.Console.WriteLine("Do you want to continue?(Y/N):");
        choice= Console.ReadLine();
        }while(choice.ToUpper()=="Y");
        return;
}
static void classExample(){
     //staticclass FunctionOne();
    //nonstaticclass sc=new nonstaticclass();
    //staticclass i=20;
    //var ns=new nonstaticclass();
    //ns.i=20;
    //ns.FunctionOne();
    //nonstaticclass istatic=20;
    var n1= new nonstaticclass();
    var n2= new nonstaticclass();
    var n3= new nonstaticclass();
    n1.FunctionOne();
    n2.FunctionOne();
    n3.FunctionOne();
}
static void classandobjectexample()
{
    classandobject c1= new classandobject();
    var c2= new classandobject(0);
    c1.SProp ="Saru";
    Console.WriteLine(c1.SProp);
}
static void PropertiesExample(){
    //studentinfo
    MarksInfo mi =new MarksInfo();
   
        mi.MathMarks = 75;
        mi.ScienceMarks = 60.25;
        Console.WriteLine($"Total => {mi.Total}");
        Console.WriteLine($"Percentage => {mi.Percentage}");
        Console.WriteLine($"Division => {mi.Division}");
        mi.ScienceMarks = 50;
        Console.WriteLine($"Total => {mi.Total}");
        Console.WriteLine($"Percentage => {mi.Percentage}");
        Console.WriteLine($"Division => {mi.Division}");

}
public static void Stringfunction(){
    string a="Hello";
    string b="Reenu";
    //string concatination
    var res=a+" "+b;
    //string formatting
    string templ="{0} {1}";//you can rearrange value of  0 1 just like array
    var res1=string.Format(templ,a,b);
    var res2=string.Format(templ,b,a);
    Console.WriteLine(res2);
    Console.WriteLine("{0} ! {1}",a,b);
    //string interpolation
    var res3=$"{a} {b}";
    Console.WriteLine(res3);
    //string builder
     StringBuilder sb =new StringBuilder();
     sb.AppendLine("fgchasgdsjfjtyusgfcusbdcjhschjgsfcusgchjgscjgschjgsudcgsjcgsgjcjutdfyusgdckjsgcjhgcf<sgdchjsg");
    sb.AppendLine("agdchgabcbshjvcgshudvgsjdvb");
    Console.WriteLine(sb.ToString());
}
public static void EnumsExample(){
    var day = Days.Monday;
            var dayNum = (int)day;
            day = (Days)5;

            switch (day)
            {
                case Days.Sunday:
                    break;

                case Days.Monday:
                    break;

                case Days.Tuesday:
                    break;

                case Days.Wednesday:
                    break;

                case Days.Thursday:
                    break;

                case Days.Friday:
                    break;

                case Days.Saturday:
                    break;

                default:
                    break;
            }
        }
    static void FunctionsExample(){
    Functions f1= new Functions();
    f1.FunctionTwo(1,"");
    f1.FunctionTwo(b:"",a:1);
    f1.FunctionThree(new int [] {1,2,3,4,5});
    f1.FunctionFour(1,2,3,4,5,6,7);
    int result=0;
    f1.FunctionFive(1,2,out result);
    f1.FunctionSeven(2,4,ref result);
}
public static void LoopingStatements(){
    Console.WriteLine("Enter the number");
    var num=Convert.ToInt32(Console.ReadLine());
    //doing task repeatdely
    //initialization,Condition,Increment/Decrement
    //unknown quantities
    Console.WriteLine("Using While loop:");
    int i=1;
    while(i<=10){
    Console.WriteLine(num+"X"+i+"="+num*i);
    i++;
    }
    i=1;
    Console.WriteLine("Using DOWhile loop:");
    do{
       Console.WriteLine(num+"X"+i+"="+num*i);
    i++;  
    }while(i<=10);
    //known quantities
    Console.WriteLine("Using FOR loop:");
    for(i=1;i<=10;i++){
       Console.WriteLine(num+"X"+i+"="+num*i);
    }
    //infinite loop using for
    //for(;;){}
    //for(i=0;i<=0;){}
    //for(i=1;trueor i>0;i++){}
    string[] days=new string[]{"Sunday","Monday","Tuesday","Wednesday","Thursday"};
    for ( i=0;i<days.Length;i++){
       Console.WriteLine("Day=="+days[i]);
    }
    foreach(var item in days){
       Console.WriteLine("Day=="+item);

    }
}
private static void ShapesExample()
        {
            Console.WriteLine("Enter the choice\n1. for Square\n2 for Rectangle");
            var choice = Convert.ToInt32(Console.ReadLine());

            var shape = ShapeFactory(choice);
            if (shape == null)
            {
                Console.WriteLine("Invalid choice");
                return;
            }
            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }    
            private static IShape ShapeFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new Square();

                case 2:
                    return new Rectangle();

                case 3:
                    return new Circle();

                case 4:
                    return new EquilateralTriangle();

                default:
                    return null;
            }
        }
 private static ShapeAbsV2 AbstractShapeFactory(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new SquareAbsV2();

                case 2:
                    return new RectangleAbsV2();

                default:
                    return null;
            }
        }

 private static void ShapesExampleV2()
 //abstract 
        {
            Console.WriteLine("Enter the choice\n1. for Square\n2 for Rectangle");
            var choice = Convert.ToInt32(Console.ReadLine());

            var shape = AbstractShapeFactory(choice);
            if (shape == null)
            {
                Console.WriteLine("Invalid choice");
                return;
            }
            shape.GetInput();
            shape.Area();
            shape.Perimeter();
        }
}
}