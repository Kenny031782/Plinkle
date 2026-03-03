using UnityEngine;

public class Slots : MonoBehaviour
{
    public int Points = 10;
    public UI Ui;
    public GameObject FireworksParticlePrefab;
    public Sounds Sounds;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEntered(other);
        }
    }

    private void OnBallEntered(Collider2D ball)
    {
        ScorePoint();
        SpawnParticles(ball);
        PlayFireworksSounds();
    }

    private void PlayFireworksSounds()
    {
        Sounds.PlayFireworksSound();
    }

    private void SpawnParticles(Collider2D ball)
    {
        Vector3 particlePosition = GetParticlePosition(ball);
        Instantiate(FireworksParticlePrefab, transform.position, Quaternion.identity);
    }

    private Vector3 GetParticlePosition(Collider2D ball)
    {
        Vector3 ballPosition = ball.transform.position;
        ballPosition.y += 0.25f;
        return ballPosition;
    }

    private void ScorePoint()
    {
        // tell scorekeeper to add some amount of points
        ScoreKeeper.Add(Points);
        Ui.ShowScore(ScoreKeeper.GetScore());
    }
}
