using UnityEngine;
using UnityEngine.InputSystem;

public class FlyBehaviour : MonoBehaviour
{
    [SerializeField] private float _velocity = 2f;
    [SerializeField] private float _rotationSpeed = 10f;
    private Rigidbody2D _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

private void Update()
{
    if (Mouse.current.leftButton.wasPressedThisFrame)
    {
        _rb.linearVelocity = Vector2.up * _velocity;
    }
}

    private void FixedUpdate() {
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        GameManager.Instance.GameOver();
    }
}
