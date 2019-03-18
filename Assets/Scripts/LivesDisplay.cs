using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    [SerializeField] int damage = 1;

    Text livesText;
    float lives;

    void Start()
    {
        livesText = GetComponent<Text>();
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        UpdateDisplay();

    }

    private void UpdateDisplay()
    {
        if (lives < 0) { lives = 0; }
        livesText.text = lives.ToString();
    }

    public void TakeLife()
    {
        lives -= damage;
        UpdateDisplay();
        if (lives <= 0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }
    }


}