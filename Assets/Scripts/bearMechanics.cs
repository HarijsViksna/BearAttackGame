using UnityEngine;
using UnityEngine.SceneManagement;

public class bearMechanics : MonoBehaviour
{
    bool seePlayer = false;
    public GameObject player;
    public Transform playerTransform;
    UnityEngine.AI.NavMeshAgent agent;
    Animator animator;
    public float lerpSpeed = 5f;
    public float attackDistance = 2.5f;

    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (bearDetection.detectsPlayer)
        {
            seePlayer = true;
        }

        if (seePlayer)
        {
            transform.LookAt(player.transform);

            Vector3 targetPosition = playerTransform.position;
            Vector3 currentPosition = transform.position;
            Vector3 newPosition = Vector3.Lerp(currentPosition, targetPosition, lerpSpeed * Time.deltaTime);

            agent.destination = newPosition;
            animator.SetFloat("Speed", agent.velocity.magnitude);

            // Calculate the distance between the bear and the player
            float distance = Vector3.Distance(transform.position, playerTransform.position);

            if (distance < attackDistance)
            {
                animator.SetBool("isAttacking", true);
                SceneManager.LoadScene("DeathScreen"); // Load DeathScreen scene
            }
            else
            {
                animator.SetBool("isAttacking", false);
            }
        }
    }
}
