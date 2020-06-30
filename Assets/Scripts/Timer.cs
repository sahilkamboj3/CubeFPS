using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;

    void Update()
    {
        timeText.text = (Time.timeSinceLevelLoad).ToString("f0");
    }
}
