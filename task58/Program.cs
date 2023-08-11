int Zapros(string message) {
    Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetDoubleMass(int Size) {
    int[,] arr = new int[Size,Size];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i,j] = rnd.Next(1,6);
            
        
        }
    }
    return arr;
}



int[,] Matrix(int[,] matrixA, int[,] matrixB, int[,] matrixC, int SIZE) {
    
    for (int i = 0; i < SIZE; i++)
    {
        
        for (int j = 0; j < SIZE; j++)
        {

            for (int l = 0; l < SIZE; l++)
            {
            
                matrixC[i, j] = matrixC[i, j] + (matrixA[i, l] * matrixB[l, j]);

            }
            
                 
        }    
           
    }
        return matrixC;

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




int size = Zapros("введите размерность матриц");
int[,] MatrixA = GetDoubleMass(size);
int[,] MatrixB = GetDoubleMass(size);
int[,] MatrixC = new int[size,size];
MatrixC = Matrix(MatrixA,MatrixB,MatrixC,size);
PrintArr(MatrixA);
Console.WriteLine();
PrintArr(MatrixB);
Console.WriteLine();
PrintArr(MatrixC);


