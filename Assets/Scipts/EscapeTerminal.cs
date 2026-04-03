using UnityEngine;
using TMPro;

public class EscapeTerminal : MonoBehaviour
{
    public GameObject winPanel;
    public TextMeshProUGUI winText;
    private bool gameWon = false;
    private float winTimer = 0f;
    
    void Start()
    {
        if (winPanel != null)
        {
            winPanel.SetActive(false);
        }
    }
    
    void Update()
    {
        if (gameWon)
        {
            winTimer += Time.deltaTime;
            if (winTimer >= 10f)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(
                    UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
                );
            }
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !gameWon)
        {
            gameWon = true;
            
            if (winPanel != null)
            {
                winPanel.SetActive(true);
            }
            
            if (winText != null)
            {
                winText.text = "Power Restored Successfully!\nYOU WON THE GAME!";
            }
            
            Debug.Log("Player won!");
        }
    }
}