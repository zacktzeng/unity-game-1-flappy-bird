using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    [SerializeField] private float _width = 3.36f;

    private SpriteRenderer _spriteRenderer;
    private Vector2 _startSize;

    private void Start() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);
    }

private void Update() {
    _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _speed * Time.deltaTime, _spriteRenderer.size.y);

    if (_spriteRenderer.size.x > _width)
    {
        _spriteRenderer.size = _startSize;
    }
}
}
