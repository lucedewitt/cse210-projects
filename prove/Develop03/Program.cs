using System;

class Program
{
    static void Main(string[] args)
    {
        // create a Reference with the chapter, book, verse start, and verse end
        Reference proverbsReference = new Reference("Proverbs", 3, 5, 6);

        // create a Scripture with the text and Reference, and start the loop to memorize
        Scripture proverbsScripture = new Scripture("Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.", proverbsReference);
        proverbsScripture.MemorizeLoop();
    }
}