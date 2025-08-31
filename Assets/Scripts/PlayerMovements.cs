using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    private Rigidbody2D _Rb;
    private float _horizontalDirection;

    void Start()
    {
        _Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");

        _Rb.linearVelocityX = _horizontalDirection * speed;
    }
}
