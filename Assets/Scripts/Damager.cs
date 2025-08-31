using UnityEngine;

public class Damager : MonoBehaviour
{
    public int damage;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerHealth playerhealth = collision.gameObject.GetComponent<PlayerHealth>();

        if (playerhealth != null)
        {
            playerhealth.DamagePlayer(damage);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
