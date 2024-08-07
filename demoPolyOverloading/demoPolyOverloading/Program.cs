using System;


namespace demoPolyOverloading
{
    internal class Program
    {

        class Tutorial
        {
            int TutorialId;
            string TutorialName;
            public void SetTutorial(int tid, string tname)
            { TutorialId = tid; TutorialName = tname; }
            public void SetTutorial(string tname) { TutorialName = tname; }
            public string GetTutorialName()
            {
                return TutorialName;
            }

            static void Main(string[] args)
            {
                Tutorial tutorial = new Tutorial();
                tutorial.SetTutorial(2, "First Tutorial");
                Console.WriteLine(tutorial.GetTutorialName());
                tutorial.SetTutorial("Second Tutorial");
                Console.WriteLine(tutorial.GetTutorialName());
                Console.ReadKey();
            }
        }
    }
}
