﻿// //--------------------------------------------------------------------------------
// // Методы: (4 основных вида)
// //Вид №1 Метод который ничего не возвращяет и ничего не принимат.
// void Method1()
// {                                       // создали метод 1 void, который при обращении к нему будет выводить (Автор ...)
//     Console.WriteLine("Автор ...");
// }
// //Method1(); // Обращение к методу 1
// //--------------------------------------------------------------------------------
// //Вид №2 Метод который ничего не возвращает, но в тоже время может принимать какие то аргументы.
// void Method2(string msg)  //Создали метод 2 при обрашении к торому будет выводится сообщение.
// {
//     Console.WriteLine(msg);
// }
// //Method2("Текст сообщения");  // Вызов метода 2

// void Method2_1(string msg, int count)
// {                                         // Создали метод при обращенни к которому  будет выведено сообщение и какое кол-во count раз его вывести.
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; // увеличение счетчика на еденичку называют ИНКРИМЕНТОМ, а уменьшение ДЕКРИМЕНТОМ!!!
//     }
// }
// //Method2_1("Текст", 4); // вызов метода 2_1. В ковычках указали что написать в тексте и через запятую сколько раз.
// //Method2_1(count: 4, msg: "Новый текст"); //Можно вызвать метод 2_1 с обращением к аргументу и в этом случае не обязательно ипользовать последовательность ту, которую мы делали в создании метода 2_1.
// //---------------------------------------------------------------------------------
// // Вид №3 Метод который что то возврвщяет, но ничего не принимает.
// int Method3()
// {
//     return DateTime.Now.Year; // Хотим увидеть текущий год
// }
// int year = Method3(); //Вызываем метод и кладем год (число)в переменную int year
// //Console.WriteLine(year); // И выводим в консоль

// //--------------------------------------------------------------------------------------------
// //Вид № 4 Метод который что то принимает и что то возвращяет.
// // создан на цикле while
// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = String.Empty; // String.Empty пустая строка

// //     while(i < count)  
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result; // возврат результата из прописаного метода
// // }
// //Вид №4_1 на цикле for
// string Method4_1(int count, string text)
// {
//     string result = String.Empty; // String.Empty пустая строка
//     for(int i =0; i < count; i++ )
//     {
//         result = result + text;    
//     }
//     return result; // возврат результата из прописаного метода
// }
// string tes = Method4_1(10, "X"); // вызываем метод, резальтат метода (кол-во раз и сам текст) и записываем в строку для вывода.
// //Console.WriteLine(tes);  // выводим на консоль

// //Цыклы в цикле  |-------------(таблица умножения)------------------------------------------------------------------
// for (int i = 2; i < 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

// // ЗАДАЧА №1 --Работа с текстом--------------------------------------------------------------------------------------------------------------------
// // Дан текст.В тексте нужно все пробелы заменить черточками, 
// // маленькие буква "к" заменить большими "К", а большие "С" заменить маленькими "с".
// // Ясна ли вам задача?
// // 1) от куда дан текст?
// // 2) какие черточки?
// // 3) в каком алфавите буквы "к" и "с"??
// string text ="- Я думаю, - Сказал князь улыбаяСь, -что, "
//             +"ужели бы вас поСлали вместо нашего милого Винценгероде,"
//             +"вы бы взяли приступом Согласие прусСкого короля. "
//             +"Вы так краСноречивы. Вы дадите мне чаю?";
// // string text = "Текст" // если у нас есть текст, то мы можем 
// //                0123   // обратиться к символам следующим образом
// // text[3] это буква "с" // обраение с символу

// string Riplace(string text, char oldValue, char newValue) //string text тот текст который мы правим, char oldValue символ который меняем, символ который вставляем вместо предедущего.
// {
//     string result = String.Empty; // строка = присвоить строку пустую

//     int length = text.Length; // вводим переменную length, в которую считываем длинну text.Length, колличество символов из text.
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}"; // если [i] совподает с oldValue(с симвалом котрый мы хотим изменить), то в result + $"{newValue}" мы запишем новый символ.
//         else result = result + $"{text[i]}"; // или если совпадений не обнаруженно, то result добавляем текущий символ, который и был.
//     }
//     return result; // возврат результата
// }
// string newText = Riplace(text, ' ', '_'); // последней командой обращяемся к первой строке кода в которой указываем где именно и что на что меняем.
// Console.WriteLine(newText);  // Вывод обработанного текста в консоль.

// // В задаче требуется изменить несколько значений в тексте, и после первого изменения
// // мы обращяемся уже к отредактированной один раз строке newText.

// Console.WriteLine(); // пустой отступ между текстами
// newText = Riplace(newText, 'к', 'К'); // боращяемся к один раз измененному тексту и внем же добовляем новые изменения.Если закомитить строку 103, то на вывод пойдет только конечный резкльтат исправлений в тексте.
// Console.WriteLine(newText); // вывод после второго редактирования.

// Console.WriteLine();
// newText = Riplace(newText, 'С', 'с');
// Console.WriteLine(newText); //Вывод конечного результата, после всех правок. Что бы не выходили в консоль все правки нужно закоммитеть два предыдущих вывода Console.WriteLine(newText);.
// // newText после редактирования = -_Я_думаю,_-_сКазал_Князь_улыбаясь,_-что,
// //                                 _ужели_бы_вас_послали_вместо_нашего_милого_Винценгероде,
// //                                 вы_бы_взяли_приступом_согласие_пруссКого_Короля.
// //                                 _Вы_таК_Красноречивы._Вы_дадите_мне_чаю?
// //----------------------------------------END-работа-с-редактированием -текста-----------------------------------------------------------------------


// -------------------------------------------------Методы для работы с массивами--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача упорядованичея данных внутри массива. Алгоритм сартировки методом выбора, алгоритм сортировки методом min max.
// Допустим у нас имеется у нас имеется какая то последовательность чисел [6,8,3,2,1,4,5,7,1,1]
// 1) Найти позицию минимального элемента в неотсортированной части массива.
// 2) Произвести обмен этого значения со значением первой не отсортированной позиции.
// 3) Повторять пока есть не отсортированные элементы.

int[] arr = {6,8,3,2,1,4,5,7,1,1}; // заводим массив (имя arr), с указанием элементов массива в фигурых скобках.

void PrintArrey(int[] array) //Создаем метод void, имя PrintArrey, в качестве аргумента будет приходить массив с имянем array.
{
    int count = array.Length; // получаем колличество элементов.

    for (int i = 0; i < count; i++) // в цыкле for пробегаем по всем элементам массива.
    {
       Console.Write($"{array[i]} "); 
    }
    Console.WriteLine(); // пустая строка, что бы убрать знак % в конце вывода.
}
// Следующим этапом пишем метод который будет упорядочивать наш массив.
void SelecnionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i; // Создаем переменную с минимальной позицией.
            for (int j = i + 1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
        int temporary = array[i]; // создали временную переменную temporary, в которую кладем array[i]
        array[i] = array[minPosition];  // array[i] у нас освободилась и мы в нее кладем найденый элемент array[minPosition]
        array[minPosition] = temporary;  // и теперь в свободный array[minPosition] кладем соханенный ранее temporary. Т.е. меняем элементы месами.

    }
}
PrintArrey(arr);  // Обращяемс к методу PrintArrey и выводим массив (arr) с уже известным, данным вначале массивом.
SelecnionSort(arr);// Обращяемс к методу SelecnionSort и выводим отсортированный массив (arr)

PrintArrey(arr); // не понял почему два раза, но без этого не корректный вывод в консоль.
// рещение задачи 6 8 3 2 1 4 5 7 1 1 
//                1 1 1 2 3 4 5 6 7 8 
//------------------------------------------------------------END-----------------------------------------------------------------------------------------------