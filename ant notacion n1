using System;

class Program
{
    static void Main()
    {
        string antTrail = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
        Console.WriteLine("Ant trail before stampede: " + antTrail);
        
        // Simulate the stampede
        antTrail = AntStampede(antTrail);
        Console.WriteLine("Ant trail after stampede: " + antTrail);
    }

    static string AntStampede(string trail)
    {
        char[] trailArray = trail.ToCharArray();
        Random random = new Random();

        for (int i = 0; i < trailArray.Length; i++)
        {
            if (trailArray[i] == 'ant')
            {
                // Randomly determine if the ant is trampled
                if (random.Next(2) == 1)
                {
                    trailArray[i] = '.';
                }
            }
        }

        return new string(trailArray);
    }
}
