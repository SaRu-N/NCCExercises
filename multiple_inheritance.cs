namespace NCClabs
{

interface calc1    
    {    
        int add(int a, int b);    
    }    
    interface calc2    
    {    
        int sub(int x, int y);    
    }     
    class Calculation : calc1, calc2 
    {    
        public int result1;    
        public int add(int a, int b)    
        {    
            return result1 = a + b;    
        }    
        public int result2;    
        public int sub(int x, int y)    
        {    
            return result2 = x - y;    
        }    
      
    }  
}