using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace MyDictionary
{

    class Program 
    {
        static void Main(string[] args)
        {
          MyDictionary<int, string> ayakkabiNumara = new MyDictionary<int, string>();
          
          ayakkabiNumara.Add(34, "Adidas");
          ayakkabiNumara.Add(43, "Puma");
          ayakkabiNumara.Add(23, "Nike");
          ayakkabiNumara.Add(45, "Kinetix");
          
          Console.WriteLine("Ayakkabı No: " + 
          ayakkabiNumara.Items1[0] + " " + "Ayakkabı Markası: " + 
          ayakkabiNumara.Items2[0]);
          
          Console.WriteLine("Ayakkabı No: " + 
          ayakkabiNumara.Items1[1] + " " + "Ayakkabı Markası: " + 
          ayakkabiNumara.Items2[1]);
          
          Console.WriteLine("Ayakkabı No: " + 
          ayakkabiNumara.Items1[2] + " " + "Ayakkabı Markası: " + 
          ayakkabiNumara.Items2[2]);
          
          Console.WriteLine("Ayakkabı No: " + 
          ayakkabiNumara.Items1[3] + " " + "Ayakkabı Markası: " + 
          ayakkabiNumara.Items2[3]);
          
        }
        
        
        
    }
}