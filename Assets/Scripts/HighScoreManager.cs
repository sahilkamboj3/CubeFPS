using UnityEngine;
using UnityEngine.UI;

public class HighScoreManager : MonoBehaviour
{
    public Text easyText;
    public Text mediumText;
    public Text hardText;
    public Text impossibleText;

    void Start()
    {
        easyText.text = PlayerPrefs.GetInt("Easy", 0).ToString();
        mediumText.text = PlayerPrefs.GetInt("Medium", 0).ToString();
        hardText.text = PlayerPrefs.GetInt("Hard", 0).ToString();
        impossibleText.text = PlayerPrefs.GetInt("Impossible", 0).ToString();
    }
}
