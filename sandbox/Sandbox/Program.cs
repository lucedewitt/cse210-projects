using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // string sentence = "hello sandbox world!";
        // TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        // string capatalized = textInfo.ToTitleCase(sentence);

        // Console.WriteLine(capatalized);

        Costume myCostume = new Costume();
        myCostume.outfit = "tartan and kilt";
        myCostume.footwear = "ghillie brogues";
        myCostume.tools = "bagpipes";
        myCostume.size = "Medium";
        myCostume.Display();
    }
}