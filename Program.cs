
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

string[] array = new string[] {"azdqzd","bqdzd","cef","qzdqzdqzdfrf","oqizndoinqz","a","pzdd","ab"};

string wordTemps = "";
int indexToStop = 0;

for (int i = 0; i < array.Length; i++)
{

    for (int j = 0; j < (array.Length-1) - indexToStop; j++ )
    {

        if (array[j].Length > array[j+1].Length)
        {

            wordTemps = array[j+1];
            array[j+1] = array[j];
            array[j] = wordTemps;

        }

    }

    indexToStop++;

}




    

