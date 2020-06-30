using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float playerHealth = 500f;

    public void TakeDamage(float damage)
    {
        playerHealth -= damage;

        if (playerHealth <= 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
