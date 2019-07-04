namespace p05._01.MordorsCruelPlan.Factories
{
    using System;

    using p05._01.MordorsCruelPlan.Moods;

    public class MoodFactory
    {
        public Mood CreateMood(string type)
        {
            type = type.ToLower();

            switch (type)
            {
                case "angry":
                    return new Angry();
                case "happy":
                    return new Happy();
                case "javascript":
                    return new JavaScript();
                case "sad":
                    return new Sad();
                default:
                    throw new Exception("Invalid type!");
            }
        }
    }
}
