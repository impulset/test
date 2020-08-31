/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Text.RegularExpressions;
class HelloWorld {
  static void Main() 
  {
    Console.Write("Enter your expression: ");
    string inpex = Console.ReadLine();
    string replaceChar = Regex.Replace(inpex, "[0-9]{2,}", "*" );
    string replaceChar1 = Regex.Replace(replaceChar, "[0-9]", "*" );
    string[] charArr = replaceChar1.Split('*');
    
    string[] inpexArr = inpex.Split('+', '-', '*', '/');
    float[] floatArr = Array.ConvertAll(inpexArr, float.Parse);
    //float a = floatArr[0];
    //float b = floatArr[1];
    if (inpex.IndexOf(charArr[1]) !=-1) 
    {
    float z = floatArr[0] - floatArr[1];    
    Console.WriteLine(z);
    }
    
    //string a = inpex[0];
    //string b = inpex[1];
    
    //float a1 = float.Parse(a);
    //float b1 = float.Parse(b);
    //Console.WriteLine(b);
  }
}
