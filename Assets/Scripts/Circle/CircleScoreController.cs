using UnityEngine;
using TMPro;
public class CircleScoreController : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    private int score = 0;

    public void IncraseScoreValue()
    {
        score++;
        SetScoreText();
    }

    private void SetScoreText()
    {
        scoreText.text = score.ToString();
    }

}
