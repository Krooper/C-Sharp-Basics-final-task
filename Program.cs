using System;
using static System.Console;

Clear();

// Метод, создающий исходный массив. Кол-во эл-ов - случайное (от 1 до 10)
// Кол-во сиволов в строке (элементе массива) - случайное (от 1 до 5)
string[] ArrayFiller(){
    string[] filledArray = new string[new Random().Next(1, 11)];
    int len = filledArray.Length;
    int strLen = new Random().Next(1, 5);
    for (int i = 0; i < len; i++){
        for (int j = 0; j < strLen; j++){
            filledArray[i] += "*";
        }
    }
    return filledArray;
}

// Метод, возвращающий новый массив, в котором длина элемента (строки) не превышает 3-х символов
string[] ArrayElementFilter(string[] inputArray){
    string[] filteredArray = new string[0];
    int len = inputArray.Length;
    for (int i = 0; i < len; i++){
        if (inputArray[i].Length <= 3) {
            filteredArray.Append(inputArray[i]);
        }
    }
    return filteredArray;
}