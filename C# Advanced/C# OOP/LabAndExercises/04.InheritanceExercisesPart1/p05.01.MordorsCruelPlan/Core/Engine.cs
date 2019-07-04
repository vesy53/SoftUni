namespace p05._01.MordorsCruelPlan.Core
{
    using System;

    using p05._01.MordorsCruelPlan.Factories;
    using p05._01.MordorsCruelPlan.Foods;
    using p05._01.MordorsCruelPlan.Moods;

    public class Engine
    {
        private const int DefaultPoints = -5;
        private const int MaxSadPoints = 0;
        private const int MinHappyPoints = 1;
        private const int DefValue = 15;

        private FoodFactory foodFactory;
        private MoodFactory moodFactory;

        public Engine()
        {
            this.foodFactory = new FoodFactory();
            this.moodFactory = new MoodFactory();
        }

        public void Run()
        {
            string[] input = Console.ReadLine()
                .Split();

            int points = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string type = input[i];

                Food currFood = foodFactory
                    .CreateFood(type);

                points += currFood.Happiness;
            }

            Mood mood = new Mood();

            if (points < DefaultPoints)
            {
                mood = moodFactory.CreateMood("angry");
            }
            else if (points >= DefaultPoints && 
                points < MaxSadPoints)
            {
                mood = moodFactory.CreateMood("sad");
            }
            else if (points >= MinHappyPoints && 
                points < DefValue)
            {
                mood = moodFactory.CreateMood("happy");
            }
            else if (points >= DefValue)
            {
                mood = moodFactory.CreateMood("javascript");
            }

            Console.WriteLine(points);
            Console.WriteLine(mood.Name);
        }
    }
}