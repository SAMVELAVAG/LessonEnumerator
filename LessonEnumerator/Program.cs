// See https://aka.ms/new-console-template for more information
using LessonEnumerator;

int[] array=new[] {4,5,8,10,15,21,27,34,32,44 };
Mover mover=new Mover(array);
mover.SetMode(true);


foreach (int i in mover)
{
    
    Console.WriteLine($"Number:  {i}");
}


foreach (int i in mover)
{

    Console.WriteLine($"Number:  {i}");
}