using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 10f;
    public float chaseSpeed = 3.5f;
    public float patrolSpeed = 2f;
    
    public Transform[] patrolPoints;
    private int currentPatrolIndex = 0;
    
    private NavMeshAgent agent;
    private bool isChasing = false;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = patrolSpeed;
        
       
        if (player == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
                Debug.Log("Player found!");
            }
            else
            {
                Debug.LogError("NO PLAYER FOUND! Make sure your player has the 'Player' tag!");
            }
        }
        
        
        if (patrolPoints.Length > 0)
        {
            GoToNextPatrolPoint();
        }
    }
    
    void Update()
    {
        
        if (player == null)
        {
            Debug.LogWarning("Player is null in Update!");
            return;
        }
        
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer <= detectionRange)
        {
            isChasing = true;
            agent.speed = chaseSpeed;
            agent.SetDestination(player.position);
        }
        else if (isChasing)
        {
            isChasing = false;
            agent.speed = patrolSpeed;
            GoToNextPatrolPoint();
        }
       
        if (!isChasing && patrolPoints.Length > 0)
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                GoToNextPatrolPoint();
            }
        }
    }
    
    void GoToNextPatrolPoint()
    {
        if (patrolPoints.Length == 0) return;
        
        agent.SetDestination(patrolPoints[currentPatrolIndex].position);
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player caught by enemy!");
        }
    }
}