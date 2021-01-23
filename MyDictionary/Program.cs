using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("Blue", "Mavi");
            myDictionary.Add("Yellow", "Sarı");
            myDictionary.Add("Green", "Yeşil");

            myDictionary.Write();
            
        }

        
    }
}
