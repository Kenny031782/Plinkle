using UnityEngine;

public static class ScoreKeeper
{
    private static int score = 0; 
    // add points to score
    public static void Add(int amount)
    {
        score += amount;
        MonoBehaviour.print(score);
    }
    // tell us what the score is
    public static int GetScore()
    {
        return score;
    }
    // reset
    public static void Reset()
    {
        score = 0;
    }
}
