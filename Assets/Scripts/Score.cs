using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _currentScoreText;
    [SerializeField] private TextMeshProUGUI _bestScoreText;
    private int _score;
    public static Score Instance;

    private void Awake() {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start() {
        _currentScoreText.text = _score.ToString();
        _bestScoreText.text = PlayerPrefs.GetInt("BestScore", 0).ToString();
        UpdateBestScore();
    }

    private void UpdateBestScore()
    {
        if (_score > PlayerPrefs.GetInt("BestScore"))
        {
            PlayerPrefs.SetInt("BestScore", _score);
            _bestScoreText.text = _score.ToString();
        }
    }

    public void UpdateScore()
    {
        _score++;
        _currentScoreText.text = _score.ToString();
        UpdateBestScore();
    }
}
