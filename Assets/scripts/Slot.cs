using UnityEngine;

public class Slots : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
        }
    }

    private void OnBallEntered(Collider2D other)
    {
        print("OnBallEntered");
    }
}
