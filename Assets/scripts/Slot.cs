using UnityEngine;

public class Slots : MonoBehaviour
{
    public int Points = 10;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
        }
    }

    private void OnBallEntered(Collider2D other)
    {
        ScorePoint();
    }

    private void ScorePoint()
    {
        // tell scorekeeper to add some amount of points
        ScoreKeeper.Add(Points);
    }
}
