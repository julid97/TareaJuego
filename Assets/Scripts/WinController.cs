using UnityEngine;
using TMPro;
public class WinController : MonoBehaviour
{
    public TextMeshProUGUI winText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))   // El Player toca la plataforma
        {
            if (winText != null)
            {
                winText.gameObject.SetActive(true);
            }
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (winText != null) {
            winText.gameObject.SetActive(false);
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
