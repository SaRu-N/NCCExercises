namespace NCClabs
{
   public class MarksInfo{
    private double _fullMarks=100;
    private double _passMarks=32;
    private double _minMarks=0;

    private double _scienceMarks;
    public double ScienceMarks{
        get {return ScienceMarks1;}
        set{
            if(value>FullMarks){
                ScienceMarks1=FullMarks;
            }
            else if(value<MinMarks){
                ScienceMarks1=MinMarks;
            }
        }
    }
    private double _mathMarks;

    public double MathMarks{

        get {return MathMarks1;}
                set{
                    MathMarks1=(value> FullMarks)?
                    FullMarks:(value< MinMarks)?
                    MinMarks:value;
        }
    }
    public double Total{
       get{
             return ScienceMarks+MathMarks;
       }
    }
    public double Percentage{
        get {
            return (Total / (FullMarks*2))*100;
        }
    }
    public string Division{
        get{
            if(Percentage>= 80)return "Distinction";
            else if(Percentage>=60)return "First Division";
            else if(Percentage>=45)return "Second Division";
            else if(Percentage>=32)return "Second Division";
            else return "Fail";
        }
    }

        public double FullMarks { get => _fullMarks; set => _fullMarks = value; }
        public double PassMarks { get => _passMarks; set => _passMarks = value; }
        public double MinMarks { get => _minMarks; set => _minMarks = value; }
        public double ScienceMarks1 { get => _scienceMarks; set => _scienceMarks = value; }
        public double MathMarks1 { get => _mathMarks; set => _mathMarks = value; }
    }
}