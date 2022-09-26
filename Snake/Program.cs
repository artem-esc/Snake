using System;
class Program
{
    static void Main()
    {
        // game 
        bool run = true;
        int style_mode = 1;


        // screen
        int width = 10;
        int height =10;
        string bottom_line = "└";
        
        // snake
        char snake_chr = 's';
        int snake_length = 1;
        int snake_x = 2;
        int snake_y = 2;
        int snake_speed = 2;

        // food 
        char food_chr = 'f';
        int food_count = 1;



        do
        {
            Console.WriteLine("");
            Console.WriteLine("X {0}\nY {1}", snake_x, snake_y);



            // update screen

            Console.WriteLine(TopLine(2, width));
            for (int y = 0; y < height; y++)
            {
                Console.Write("{0}", MainLine(2));
                for (int x = 0; x < width; x++)
                {
                    if (y == snake_y-1 && x == snake_x-1)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write("X");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.Write("{0}\n", MainLine(2));
            }
            Console.WriteLine(BottomLine(2,width));




            // get key

            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.W)
            {
                if (snake_y <= height && snake_y > 1)
                {
                    snake_y -= 1;
                }

            }
            if (key.Key == ConsoleKey.S)
            {
                if (snake_y < height)
                {
                    snake_y ++;
                }
            }
            if (key.Key == ConsoleKey.A)
            {
                if (snake_x > 1)
                {
                    snake_x -= 1;
                }
            }
            if (key.Key == ConsoleKey.D)
            {
                if (snake_x < width)
                {
                    snake_x++;
                }
            }

            if (key.Key == ConsoleKey.H)
            {
                run = false;
                break; // end game
            }

        }
        while (run == true);
        
    }


    static string MainLine(int mode)
    {
        string main_line = "";
        if(mode == 1)
        {
            main_line = "│";
        }

        if(mode == 2)
        {
            main_line = "║";
        }

        return main_line;
    }

    static string TopLine(int mode, int sc_width)
    {
        string top_line = "";

        if(mode == 1)
        {
            top_line = "┌";
            for (int i = 0; i < sc_width; i++)
            {
                top_line += "─";
            }
            top_line += "┐";
        }

        else if(mode == 2)
        {
            top_line = "╔";
            for (int i = 0; i < sc_width; i++)
            {
                top_line += "═";
            }
            top_line += "╗";
        }
        

        return top_line;

    }




    static string BottomLine(int mode, int sc_width)
    {
        string bottom_line = "";

        if (mode == 1)
        {
            bottom_line = "-";
            for (int i = 0; i < sc_width; i++)
            {
                bottom_line += "─";
            }
            bottom_line += "┘";
        }

        else if (mode == 2)
        {
            bottom_line = "╚";
            for (int i = 0; i < sc_width; i++)
            {
                bottom_line += "═";
            }
            bottom_line += "╝";
        }

        return bottom_line;

    }
    
}