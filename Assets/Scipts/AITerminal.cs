using UnityEngine;

public class AITerminal : MonoBehaviour
{
    public string[] dialogue = new string[]
    {
        "STATION AI: Systems critical. Life support failing.",
        "AI: Power cells located throughout facility. Collect 5 to restore main power.",
        "AI: Warning: Security robots hostile. Recommend stealth approach.",
        "AI: Repair bot available in Engineering Bay. May assist.",
        "AI: Good luck, survivor."
    };
    
    private bool playerInRange = false;
    private bool hasInteracted = false;
    
    public GameObject promptText;
    
    void Start()
    {
        if (promptText != null)
            promptText.SetActive(false);
    }
    
    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E) && !hasInteracted)
        {
            DialogueManager.instance.StartDialogue(dialogue);
            hasInteracted = true;
            if (promptText != null)
                promptText.SetActive(false);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (!hasInteracted && promptText != null)
                promptText.SetActive(true);
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            if (promptText != null)
                promptText.SetActive(false);
        }
    }
}