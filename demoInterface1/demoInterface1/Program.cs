using System;

namespace demoInterface1
{
   interface Tutorial
    {
        void SetTutorial(int tid, string tname);
        string GetTutorial();
    }
    class Childclass : Tutorial
    {
        protected int TutorialID;
        protected string TutorialName;
        public void SetTutorial(int tid, string tname)
        {
            TutorialID = tid;
            TutorialName = tname;
        }
        public string GetTutorial()
        {
            return TutorialName;
        }
        static void Main()
        {
            Childclass ptutor = new Childclass();
            ptutor.SetTutorial(1, "DFS");
            Console.WriteLine(ptutor.GetTutorial());
            Console.ReadKey();

        }
    }


}
