using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    
    public GameObject dialoguePanel;
    public TextMeshProUGUI dialogueText;
    public GameObject continueButton;
    
    private string[] currentDialogue;
    private int dialogueIndex = 0;
    
    void Awake()
    {
        if (instance == null)
            instance = this;
            
        if (dialoguePanel != null)
            dialoguePanel.SetActive(false);
    }
    
    public void StartDialogue(string[] dialogue)
    {
        currentDialogue = dialogue;
        dialogueIndex = 0;
        dialoguePanel.SetActive(true);
        DisplayCurrentLine();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
       
        Time.timeScale = 0f; 
    }
    
    void DisplayCurrentLine()
    {
        if (dialogueIndex < currentDialogue.Length)
        {
            dialogueText.text = currentDialogue[dialogueIndex];
        }
        else
        {
            EndDialogue();
        }
    }
    
    public void NextLine()
    {
        Debug.Log("Next Line Button hit");
        dialogueIndex++;
        DisplayCurrentLine();
    }
    
    void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        Time.timeScale = 1f; 

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}