using UnityEngine;
using UnityEngine.UI;

public class Scorer : MonoBehaviour
{
    public Text scoreText;
    public float increment = 1f;
    public float score = 0f;
    public float highScore;
    public GameObject fireworks;

    void Update()
    {
        scoreText.text = score.ToString("f0");
    }

    public void Increment()
    {
        score += increment;
    }
}
