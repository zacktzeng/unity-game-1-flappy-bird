using UnityEngine;

public class PipeUpdateScore : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Player"))
        {
            Score.Instance.UpdateScore();
            Debug.Log("Score Updated");
        }
    }
}
