using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public float speed;
    public Animator animator;

    private Rigidbody2D _Rb;
    private float _horizontalDirection;
    private SpriteRenderer _sprite;

    void Start()
    {
        _Rb = GetComponent<Rigidbody2D>();
        _sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _horizontalDirection = Input.GetAxisRaw("Horizontal");

        _Rb.linearVelocityX = _horizontalDirection * speed;

        animator.SetFloat("movement", _Rb.linearVelocity.x);

        if (_horizontalDirection != 0)
        {
            if (_horizontalDirection < 0)
            {
                _sprite.flipX = true; 
            }
            else if (_horizontalDirection > 0)
            {
                _sprite.flipX = false; 
            }
        }
    }
}
