using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class SkellyController : MonoBehaviour
{
    // Singleton instance
    private static SkellyController instance;

    // Reference to the player
    private Transform player;

    // Distance to trigger attack
    public float attackTriggerDistance = 2f, distanceToPlayer;

    // Movement speed
    public float moveSpeed = 2f, SkellyDamage = 10f;

    // Animator component reference
    private Animator animator;

    // Reference to the NavMeshAgent
    private NavMeshAgent navMeshAgent;

    // State variables
    private bool isAttacking = false;
    public bool SkellyInterrupted;
    private Coroutine attackCoroutine;

    public float SkellyHp, PlayerDamage;

    // Animator parameter names
    private static readonly int SkellyMovingHash = Animator.StringToHash("SkellyMoving");
    private static readonly int EnemyAttackHash = Animator.StringToHash("EnemyAttack");

    private void Awake()
    {
        // Ensure there's only one instance of the SkellyController
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
    }

    private void Start()
    {
        // Set the player reference
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Get the Animator component
        animator = GetComponent<Animator>();

        // Get the NavMeshAgent component
        navMeshAgent = GetComponent<NavMeshAgent>();

        // Set the NavMeshAgent speed to the desired moveSpeed
        navMeshAgent.speed = moveSpeed;
    }

    private void Update()
    {
        SkellyInterrupted = movement_Player.Instance.SkellyInterruptor;

        if (!isAttacking)
        {
            if (player != null)
            {
                // Calculate the distance to the player
                distanceToPlayer = Vector3.Distance(transform.position, player.position);

                if (distanceToPlayer < attackTriggerDistance)
                {
                    // Stop moving and attack
                    StopMoving();
                    if (!SkellyInterrupted)
                    {
                        attackCoroutine = StartCoroutine(SkellyAttack());
                    }
                }
                else
                {
                    navMeshAgent.SetDestination(player.position);
                    // Skelly is moving, set SkellyMoving to true
                    animator.SetBool(SkellyMovingHash, true);
                }

            }
        }

        if (SkellyHp == 0)
        {
            SkellyHp++;
            StartCoroutine(HpFiller.Instance.TogglePauseWin());
        }
    }

    private void StopMoving()
    {
        // Stop the enemy from moving by clearing the NavMeshAgent destination
        navMeshAgent.isStopped = true;
        // Skelly is not moving, set SkellyMoving to false
        animator.SetBool(SkellyMovingHash, false);
    }

    private IEnumerator SkellyAttack()
    {
        isAttacking = true;
        animator.SetBool(EnemyAttackHash, true);

        // Stop NavMeshAgent movement while attacking
        navMeshAgent.isStopped = true;

        yield return new WaitForSeconds(1.0f);

        if(SkellyInterrupted)
        {
            SkellyHp = SkellyHp - PlayerDamage;
            animator.SetBool(EnemyAttackHash, false);
            yield return new WaitForSeconds(2.0f);
            isAttacking = false;
            navMeshAgent.isStopped = false;
            yield break;
        }

        yield return new WaitForSeconds(1.0f);
            
        if(SkellyInterrupted)
        {
            SkellyHp = SkellyHp - PlayerDamage;
            animator.SetBool(EnemyAttackHash, false);
            yield return new WaitForSeconds(2.0f);
            isAttacking = false;
            navMeshAgent.isStopped = false;
            yield break;
        }

        animator.SetBool(EnemyAttackHash, false);

        HpFiller.Instance.TakeDamage();

        isAttacking = false;

        // Resume NavMeshAgent movement after attacking
        navMeshAgent.isStopped = false;
        yield break;
    }
}