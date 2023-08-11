int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetDoubleMass(int rows, int columns) {
    int[,] arr = new int[rows,columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i,j] = rnd.Next(1,10);
            
        
        }
    }
    return arr;
}



void SearchMinRow(int[,] arr) {
    int min = Int32.MaxValue;
    int result = 0;
    int index = 0;
    
   
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int prompt = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            prompt = prompt + arr[i,j];
                 
        }
        if (prompt < min) {
            min  = prompt;
            index++;
        }
           
    }
        
    
      Console.WriteLine(index);

    }
    


void PrintArr(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}




int ROWS = Zapros("введите количество строк");
int COLUMNS = Zapros("введите количество столбцов");
int[,] Mass = GetDoubleMass(ROWS,COLUMNS);
PrintArr(Mass);
Console.WriteLine();
SearchMinRow(Mass);






