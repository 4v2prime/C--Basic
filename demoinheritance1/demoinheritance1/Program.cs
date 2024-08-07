using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoinheritance1
{
    class Tutorial
    {
        protected int TutorialId;
        protected string TutorialName;
        public void SetTutorial(int pID, string pName)
        {
            TutorialId = pID;
            TutorialName = pName;
        }
        public string GetTutorialName()
        { return TutorialName; }
    }
    class ChildTutorial : Tutorial
    {
        public void updateName(string tname)
        {
            TutorialName = tname;
        }
        static void Main(string[] args)
        {
            ChildTutorial ct1 = new ChildTutorial();
            ct1.updateName("DFS");
            Console.WriteLine(ct1.GetTutorialName());
            Console.ReadKey();

        }



    }
}
