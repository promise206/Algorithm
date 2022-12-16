// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Globalization;
using System.Text;


/*1.COMPRESS A STRING
Given a string e.g &quot; aaaabbbcccac & quot;, compress the string to show the consecutive count of each
character.
E.g
; aaaabbbcccact; returns a4b3c3a1c1&quot;
; ggaaaaaatttt returns &quot; g2a6t4 & quot;*/

/*static string Compress(string str)
{
    StringBuilder stringBuilder = new StringBuilder();

    for(int i = 0; i<str.Length; i++)
    {
        int count = 0;
        int j;

        for(j = i; j < str.Length; j++)
        {
            if (str[j] != str[i]) break;
            count++;
        }
        stringBuilder.Append($"{str[i]}{count}");
        i = j-1;
    }

    return stringBuilder.ToString();
}

Console.Write(Compress("ggaaaaaatttt"));*/

/*Write an algorithm that takes an array and moves all of the zeros to the end, preserving the order of the other elements.

Input => {1, 2, 0, 1, 0, 1, 0, 3, 0, 1} output => { 1, 2, 1, 1, 3, 1, 0, 0, 0, 0}*/

static void MoveElementToEnd(int[] array)
{
    /*    int begin = 0;
        int end = array.Length - 1;

        while(begin < end)
        {
            int leftElement = array[begin];
            int rightElement = array[end];

            if(leftElement == elementToMove && rightElement != elementToMove) {
                //call a method that swaps the element at begin and end
                Swap(begin, end, array);
                begin++;
                end--;
            }else if(rightElement == elementToMove)
            {
                end--;
            }else if(rightElement != elementToMove && leftElement != elementToMove)
            {
                begin++;
            }
        }

        return array;*/

    int n = array.Length;
    for (int i = 0; i < n; i++)
    {
        if (array[i] == 0)
        {
            for(int j = i; j< n-1; j++)
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
            n--;
            i = -1;
        }
    }
}

/*static void Swap(int index1, int index2, int[] array)
{
    int temp = array[index1];
    array[index1] = array[index2];
    array[index2] = temp;
}*/

int[] x = new int[] { 001, 6, 9, 0, 0, 7, 60 };
MoveElementToEnd(x);

foreach(int element in x)
{
    Console.Write(element + ",");
}

/*[001,6,9,0,0,7,60]

[001,6,9,7,60,0,0]*/