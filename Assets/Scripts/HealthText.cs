using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public Text healthText;

    void Update()
    {
        PlayerHealth player = FindObjectOfType<PlayerHealth>();

        if (player.playerHealth >= 0)
        {
            healthText.text = player.playerHealth.ToString("0");
        }
        else
        {
            healthText.text = "0";
        }

        
    }
}
