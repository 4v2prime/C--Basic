using System;
namespace democonstructor
{
    internal class Tutorial
    {
        int TutorialID;
        string TutoraialName; 
        public Tutorial() {
            TutorialID = 1;
            TutoraialName = "DFS";
        }
        public Tutorial(int id, string name) {
            id = TutorialID;
            name = TutoraialName;
        }
        public void settutorial(int TID, string TNAME)
        {
            TutorialID = TID;
            TutoraialName = TNAME;
        }
        public string gettutorial()
        { return TutoraialName; }
       static void Main(string[] args) 
        {
            Tutorial obj = new Tutorial();
            Console.WriteLine(obj.gettutorial());
            Tutorial obj2 = new Tutorial(6,"EMV");
            Console.WriteLine(obj2.gettutorial());  
            Console.ReadLine();
        }
    }
}
