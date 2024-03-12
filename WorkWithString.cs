using static AdditionalMethods;

public class WorkWithString
{
    public static string[] CreateArrayString(string messageAboutArraySizeRequest
                                                = "Введите количество элементов массива строк (целое положительное число): ")
    {
        int arraySize = 0;
        ReadConsoleAndCheckForInt(messageAboutArraySizeRequest, ref arraySize);
        string[] startArray = new string[arraySize];
        for (int i = 0; i < startArray.Length; i++){
            System.Console.Write($"Введите элемент массива строк под номером "
                                    + $"{i + 1} и нажмите Enter: ");
            startArray[i] = System.Console.ReadLine();
        }
        return startArray;
    }

    public static void PrintArrayString(string[] stringArray, string messageForUser = "Ваш массив: ")
    {
        System.Console.Write(messageForUser);
        System.Console.Write("[");

        for (int i = 0; i < stringArray.Length; i++)
            System.Console.Write($"\"{stringArray[i]}\" ");

        if (stringArray.Length > 0) System.Console.WriteLine("\b]");
        else System.Console.WriteLine("]\n");
    }

    public static string[] ModificateArray(string[] startArray)
    {
        int lengthRequired = 0;
        ReadConsoleAndCheckForInt("Какой максимальной длины должны быть элементы в новом массиве строк(После ввода числа нажмите Enter): ",
                                    ref lengthRequired);
        int sizeModificateArray = CountingNumberOfElementsOfRequiredSize(
                                        startArray, lengthRequired);
        string[] modificateArray = FillingArray(startArray, sizeModificateArray, lengthRequired);
        System.Console.WriteLine($"Вы ввели: {lengthRequired}");
        PressToContinue();
        return modificateArray;
    }
    public static int CountingNumberOfElementsOfRequiredSize(string[] array,
                                                            int requiredItemSize)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
            if (array[i].Length <= requiredItemSize)
                count++;
        return count;
    }

    public static string[] FillingArray(string[] startArray, int sizeModificateArray, int lengthRequired)
    {
        string[] modificateArray = new string[sizeModificateArray];
        int j = 0;
        for (int i = 0; i < startArray.Length; i++)
            if (startArray[i].Length <= lengthRequired){
                modificateArray[j] = startArray[i];
                j++;
            }
        return modificateArray;
    }
}

