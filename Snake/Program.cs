using System;
class Program
{
    static void Main()
    {
        //screen
        int width = 3;
        int height = 5;

        //snake
        char snake_chr = 's';
        int snake_length = 1;

        //food 
        char food_chr = 'f';
        int food_count = 1;
        
        for(int y=0; y<height; y++)
        {
            Console.Write("|");
            for(int x=0; x<width; x++)
            {
                Console.Write("x");
            }
            Console.WriteLine("|\n");
        }
        for(int i=0; i<width*2; i++) 
        {
            Console.Write("- ");
        }
        
    }
}