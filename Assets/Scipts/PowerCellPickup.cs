using UnityEngine;

public class PowerCellPickup : MonoBehaviour
{
    public AudioClip pickupSound;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GameManager.instance.AddPowerCell();
            
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }
            
            Destroy(gameObject);
        }
    }
}