using System;

namespace demoInterface1
{
    abstract class Tutor
    {
        public virtual void set()
        { }
    }
    class ChildClass : Tutor
    {
        protected int TutorialID;
        protected string TutorialName;
        public void SetTutorial(int TID, string TName) { TutorialID = TID;TutorialName = TName; }
        public string GetTutorial() {  return TutorialName; }
        static void Main() 
        {
            ChildClass cp1 = new ChildClass();
            cp1.SetTutorial(1, " dfs");
            Console.WriteLine(cp1.GetTutorial());   
            Console.ReadKey();
        }





    }




}
