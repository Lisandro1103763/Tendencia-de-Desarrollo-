using System;

class Program
{
    static void Main()
    {
        string antTrail = "..ant..ant.ant...ant.ant..ant.ant....ant..ant.ant.ant...ant..";
        Console.WriteLine("Ant trail before stampede: " + antTrail);

        // Simulate the stampede
        try
        {
            antTrail = AntStampede(antTrail);
            Console.WriteLine("Ant trail after stampede: " + antTrail);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error during stampede simulation: " + ex.Message);
        }
    }

    static string AntStampede(string trail)
    {
        if (string.IsNullOrEmpty(trail))
        {
            throw new ArgumentException("Ant trail cannot be null or empty.");
        }

        char[] trailArray = trail.ToCharArray();
        Random random = new Random();

        for (int i = 0; i < trailArray.Length; i++)
        {
            if (trailArray[i] == 'a')
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
