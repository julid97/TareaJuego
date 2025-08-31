using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{   public int lives;

    public void DamagePlayer(int damage)
    {
        lives -= damage;

        if (lives <= 0)
        {
            SceneManager.LoadScene("SampleScene");
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
