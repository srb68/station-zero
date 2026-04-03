using UnityEngine;

public class PetFollow : MonoBehaviour
{
    public Transform player;
    public float followDistance = 3f;
    public float followSpeed = 5f;
    public float rotationSpeed = 5f;
    
    public bool isActive = false;
    
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }
    
    void Update()
    {
        if (!isActive) return;
        
        float distance = Vector3.Distance(transform.position, player.position);
        
        if (distance > followDistance)
        {
          
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * followSpeed * Time.deltaTime;
            
          
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
    
    public void Activate()
    {
        isActive = true;
        Debug.Log("Repair Bot activated!");
    }
}