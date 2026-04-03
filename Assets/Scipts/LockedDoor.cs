using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    public int powerCellsRequired = 5;
    public AudioClip unlockSound;
    
    private bool isUnlocked = false;
    
    void Update()
    {
        if (!isUnlocked && GameManager.instance.powerCellsCollected >= powerCellsRequired)
        {
            UnlockDoor();
        }
    }
    
    void UnlockDoor()
    {
        isUnlocked = true;
        
        if (unlockSound != null)
        {
            AudioSource.PlayClipAtPoint(unlockSound, transform.position);
        }
        
        Destroy(gameObject); 
        Debug.Log("Control room unlocked!");
    }
}