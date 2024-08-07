using System;

namespace democlass1
{
    internal class Tutorial
    {
        int TutorialID;
        String TutorialName;
        
        public void SetTutorial(int pID, String pName)
        {
            Console.WriteLine("Tutorial Number");
            pID =int.Parse(Console.ReadLine());
            Console.WriteLine("Tutorial Name");
            pName = Console.ReadLine();
            TutorialID = pID;
            TutorialName = pName;

        }
        public int GetTutorialID() { return TutorialID; }
        public String GetTutorialName() { return TutorialName; }
        static void Main(string[] args)
        {
                Tutorial objtut = new Tutorial();
               objtut.SetTutorial(0,"");
                Console.Write(objtut.GetTutorialID());
                Console.Write(objtut.GetTutorialName());
                Console.ReadKey();  
        }
    }
}
