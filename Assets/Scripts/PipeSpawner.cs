using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 0.4f;
    [SerializeField] private float _heightTopLimit = 0.7f;
    [SerializeField] private float _heightBottomLimit = 0f;
    [SerializeField] private GameObject _pipePrefab;
    private float _timer;
    
    private void Start() {
        SpawnPipe();
    }

    private void Update() {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

    private void SpawnPipe() 
    {
        Vector3 spawnPosition = new Vector3(1, Random.Range(_heightBottomLimit, _heightTopLimit), 0);
        GameObject pipe = Instantiate(_pipePrefab, spawnPosition, Quaternion.identity);
        Destroy(pipe, 10f);
    }
}
