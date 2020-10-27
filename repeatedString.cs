using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n) {
        
        long totalLength = s.Length;
        long remainder = n % totalLength;
        int countA = 0;
        
        string appendString = "";

        long result = 0;
        
        if ((int)remainder != 0){
            appendString = appendString + s.Substring(0,(int)remainder);            
        }
        
        long multiply = n/totalLength;
        
        //find a in original strilng
        for (int i=0; i< totalLength; i++){
            if (s[i] == 'a'){
                countA++;
            }
        }
        result = multiply*(long)countA;

        for (int j=0; j< appendString.Length; j++){
            if (s[j] == 'a'){
                countA++;
                result+=1;
            }
        }

        return result;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
