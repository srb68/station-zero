using UnityEngine;

public class PetActivator : MonoBehaviour
{
    public GameObject interactionPrompt;
    private PetFollow petFollow;
    private bool playerInRange = false;
    private bool isActivated = false;
    
    void Start()
    {
        petFollow = GetComponent<PetFollow>();
        if (interactionPrompt != null)
            interactionPrompt.SetActive(false);
    }
    
    void Update()
    {
        if (playerInRange && !isActivated && Input.GetKeyDown(KeyCode.E))
        {
            petFollow.Activate();
            isActivated = true;
            if (interactionPrompt != null)
                interactionPrompt.SetActive(false);
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (!isActivated && interactionPrompt != null)
                interactionPrompt.SetActive(true);
        }
    }
    
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            if (interactionPrompt != null)
                interactionPrompt.SetActive(false);
        }
    }
}