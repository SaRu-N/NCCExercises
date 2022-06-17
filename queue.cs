using System;
namespace NCClabs{
public class Queue<T>{

    public T[] t1 = new T[5];
   
       public int  front=-1;
       public int rear=-1;
    
    public void enqueue(T item){
        if(front==-1 && rear==-1){
           rear++;
           t1[rear]=item;
        }
        else if(front !=rear){
            if(rear<5){
                rear++;
                t1[rear]=item;
            }
        }
        else{
                System.Console.WriteLine("Queue is full");   
        }
    }
    public void dequeue(){
        if(front == rear )
            {
                System.Console.WriteLine("Queue underflow");
                return;
            }
            else
            {
                front++;
               System.Console.WriteLine($"deleted element is:  {t1[front]}");
            t1[front]=default(T);
                front++;
            }
            return;
    }
    public void display()
        {
            // if (front == rear )
            // {
            //     Console.WriteLine("Queue is Empty");
            //     return;
            // }
            // else
            // {
                for (int i = 0; i <= rear; i++)
                {
                    Console.WriteLine(t1[i]);
                }
                return;
            // }
        }
}
}