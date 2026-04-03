using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public int powerCellsCollected = 0;
    public int powerCellsNeeded = 5;
    
    public TextMeshProUGUI powerCellText;
    
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
    
    void Start()
    {
        UpdateUI();
    }
    
    public void AddPowerCell()
    {
        powerCellsCollected++;
        UpdateUI();
        
        if (powerCellsCollected >= powerCellsNeeded)
        {
            Debug.Log("All power cells collected! You can escape!");
           
        }
    }
    
    void UpdateUI()
    {
        if (powerCellText != null)
        {
            powerCellText.text = "Power Cells: " + powerCellsCollected + "/" + powerCellsNeeded;
        }
    }
}