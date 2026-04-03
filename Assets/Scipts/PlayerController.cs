using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int lives = 3;
    public Vector3 respawnPosition;
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI caughtText;
    
    private CharacterController controller;
    private bool isGameOver = false;
    private float gameOverTimer = 0f;
    private float caughtMessageTimer = 0f;
    private bool showingCaughtMessage = false;
    private float lastCaughtTime = -999f;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
        respawnPosition = transform.position;
        livesText.text = "Lives: " + lives;
        caughtText.text = "";
    }

    void Update()
    {
        if (showingCaughtMessage)
        {
            caughtMessageTimer += Time.deltaTime;
            if (caughtMessageTimer >= 2f)
            {
                caughtText.text = "";
                showingCaughtMessage = false;
            }
        }
        
        if (isGameOver)
        {
            gameOverTimer += Time.deltaTime;
            if (gameOverTimer >= 2f)
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(
                    UnityEngine.SceneManagement.SceneManager.GetActiveScene().name
                );
            }
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy") && Time.time - lastCaughtTime > 1f)
        {
            lastCaughtTime = Time.time;
            lives--;
            livesText.text = "Lives: " + lives;
            
            caughtText.text = "Got Caught By The Robot..\nTRY AGAIN!!!";
            showingCaughtMessage = true;
            caughtMessageTimer = 0f;
            
            Debug.Log("Caught! Message shown!");
            
            if (lives > 0)
            {
                controller.enabled = false;
                transform.position = respawnPosition;
                controller.enabled = true;
            }
            else
            {
                livesText.text = "GAME OVER!";
                caughtText.text = "";
                isGameOver = true;
            }
        }
    }
}