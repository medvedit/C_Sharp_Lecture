﻿

// Пример со строкой: ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// string[,] table = new string[2, 5]; // Задали двумерный массив, в котором 2 строски м 5 столбцов.
// // String.Empty - инициализация строк
// // //table 0.0     table 0.1   table 0.2   table 0.3   table 0.4  //из примера выше - пять столбцов
// // //table 1.0     table 1.1   table1.2    table 1.3   table 1.4  //и две строки.


// table[1, 2] = "слово";
// // внешниц цикл, цикл строк по i
// for (int i = 0; i < 2; i++)  // < 2 - колличество строк не больше 2х
// { // Внутрений цикл, цикл столбцов по j
//     for (int j = 0; j < 5; j++) // вложенный цикл < 5 колличетво столбцов.
//     {
//         Console.Write($"-{table[i, j]}- "); // Вывод на печать путём обращения к имени ис аргументами строки и столбцов table[rows, colums] .

//     }
// Console.WriteLine();  // Для верного отображения матрицы, по завершении прохождения по циклу for(j), принудительно переключаем для работы на цикл for(i).
// }
// Ответ :  -- ( без переключения на for(i))   Ответ:   -- -- -- -- --         ( вид матрицы после ввода пустой Console.WriteLine(); на 20 строке и перехода на цикл for(i).
//          --                                          -- -- -слово- -- --
//          --
//          --
//          --
//          --
//          --
//          -слово-
//          --
//          --

// // Пример с целыми числами: -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// int[,] matrix = new int[3, 4]; // примкр с числами. 3 строки и 4 столбца.
 
// for (int i = 0; i < 3; i++)  // Вместо цифр i < 3 , принято писать i < matrix.GetLenght(0), где (0) нам он даст полную длинну строки и не потребует ввода цифр в код.
// {
//     for (int j = 0; j < 4; j++)  // i < matrix.GetLenght(1), где (1) полное колличество солбцов.
//     {
//         Console.Write($"{matrix[i, j]}  ");
//     }
// Console.WriteLine();
// }

// Пример создания метода, который бутет печать двумерную матрицу на экран-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// создали метод void для печати двумерной матрицы в кансоль______________________________________________________
void PrintArray (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {
        for (int j = 0; j < matr.GetLength(1); j++) 
        {
            Console.Write($"{matr[i, j]}  ");
        }
    Console.WriteLine();
    }
}

//_____________________________________________________________________________________________________________________________
// Метод который будет заполнять матрицу созданною выше.________________________________________________________________________

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1, 10);
        }
    }
}

//_______________________________ заполнение матрицы_________________________________
int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

// Ответ:   0  0  0  0  
//          0  0  0  0  
//          0  0  0  0  
//
//          3  6  8  9  
//          5  9  7  2  
//          7  8  7  7  
//______________________________________________________________