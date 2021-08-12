using System;

namespace Ls8_1
{
    public enum CellType {
            Free = 0,
            Wood = 1,
            Metal = 2
        }
    class Cell
    {
        
        public Cell(CellType t) 
        {
            this.type = t;
        }
        CellType type = 0;
        public static void Show(Cell[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    switch (field[i, j].type) 
                    {
                        case (CellType)0:
                            Console.Write(" 00000"+"\t ");
                            break;
                        case (CellType)1:
                            Console.Write(" #####"+"\t ");
                            break;
                        case (CellType)2:
                            Console.Write(" %%%%%"+"\t ");
                            break;
                        default:
                            break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Random r = new Random();
            Cell[,] field = new Cell[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    field[i, j] = new Cell((CellType)r.Next(3));
                }
            }
            Cell.Show(field);
            Console.ReadLine();
        } 
    }
}
