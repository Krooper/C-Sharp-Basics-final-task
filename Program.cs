using System;
using static System.Console;

Clear();

// Метод, создающий исходный массив. Кол-во эл-ов - случайное (от 1 до 10)
// Кол-во сиволов в строке (элементе массива) - случайное (от 1 до 5)
string[] ArrayFiller(){
    string[] filledArray = new string[new Random().Next(1, 11)];
    int len = filledArray.Length;
    for (int i = 0; i < len; i++){
        int strLen = new Random().Next(1, 6);
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
    int maxStrLen = 3;
    for (int i = 0; i < len; i++){
        if (inputArray[i].Length <= maxStrLen) {
            filteredArray = filteredArray.Append(inputArray[i]).ToArray();
        }
    }
    return filteredArray;
}

// Метод, выводящий массивы в консоль в том виде, в котором было указано в задании
void ResultPrinter(string[] initialArray, string[] resultArray){
    int initialLen = initialArray.Length;
    int resultLen = resultArray.Length;
    string outStr = "[\"";
    for (int i = 0; i < initialLen; i++){
        if (i != initialLen - 1){
            outStr += $"{initialArray[i]}\", \"";
        } else {
            outStr += $"{initialArray[i]}\"] -> [\"";
        }
    }
    for (int i = 0; i < resultLen; i++){
        if (i != resultLen - 1){
            outStr += $"{resultArray[i]}\", \"";
        } else {
            outStr += $"{resultArray[i]}\"]";
        }
    }
    WriteLine(outStr);
}


string[] strArray = ArrayFiller();
string[] outArray = ArrayElementFilter(strArray);
ResultPrinter(strArray, outArray);