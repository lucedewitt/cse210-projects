using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation3 World!");
        List<CurrentEvent> events = new List<CurrentEvent>();
        Address address1 = new Address("Alnwick", "Northumberland", "United Kingdom", "NE66 1NQ");
        Lecture lecture = new Lecture("How to Fight a Dark Lord", "For the upcoming war, Dumbledore has decided to share tips about fighting dark lords and wizards. Attendence mandatory for Hogwarts students.", "September 23", "3pm", address1, "Dumbledore", 400);
        events.Add(lecture);
        
        Address address2 = new Address("Lenno", "Province of Como", "Italy", "22016 Tremezzina");
        Reception reception = new Reception("Padme and Anakin's Wedding", "You're invited! Pandme and Anakin are getting married! Please leave weapons at home for the ceremony.", "June 17", "2pm", address2, "anidala@starmail.com");
        events.Add(reception);

        Address address3 = new Address("near Whakapapa Village","Whanganui Region", "New Zealand", "3989");
        Outdoor outdoor = new Outdoor("Destroy the Ring", "Join Frodo and Sam in dropping the one ring into Mt Doom!", "March 25, 3019", "5pm", address3, "Hot and smoky");
        events.Add(outdoor);

        foreach (CurrentEvent _event in events)
        {
            Console.WriteLine("**************");
            Console.WriteLine("SHORT DETAILS:");
            _event.SDetails();
            Thread.Sleep(3000);
            Console.WriteLine("\nFULL DETAILS:");
            _event.FDetials();
            Thread.Sleep(3000);
            Console.WriteLine("\nDESCRIPTION");
            _event.Description();
            Console.WriteLine();
            Thread.Sleep(3000);
        }
    }
}