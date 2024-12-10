using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Canvas _gameOverCanvas;
    public static GameManager Instance { get; private set; }

    private void Awake() {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        _gameOverCanvas.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        _gameOverCanvas.gameObject.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
