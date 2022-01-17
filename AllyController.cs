using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AllyController : MonoBehaviour
{
    public NavMeshAgent agent;

    public LayerMask playerLayer, enemyLayer, groundLayer;

    [SerializeField] private int health = 50;
    [SerializeField] private int damage = 10;



    //Attacking
    [SerializeField] private float timeBetweenAttacks = 2f;
    bool alreadyAttacked;
    public GameObject attacking;

    //States
    [SerializeField] bool listeningToCommand;
    public float sightRange, attackRange;
    public bool isInSightRange, isInAttackRange;




    private void Awake()
    {
        agent = this.GetComponent<NavMeshAgent>();
    }


    private void Update()
    {
        isInSightRange = Physics.CheckSphere(transform.position, sightRange, enemyLayer);
        isInAttackRange = Physics.CheckSphere(transform.position, attackRange, enemyLayer);

        if (isInSightRange)
        {
            Attack();
        }
    }


    private void Attack()
    {
        if (!listeningToCommand)
        {
            if (attacking == null)
            {
                Collider[] target = Physics.OverlapSphere(transform.position, sightRange, enemyLayer);

                if (target != null && target.Length > 0)
                {
                    attacking = target[0].gameObject;
                    if (!isInAttackRange)
                    {
                        agent.SetDestination(attacking.transform.position);
                        Debug.Log("Ally Moving Towards Target");
                    }
                }
            }

            if (attacking != null)
            {
                EnemyController enemy = attacking.GetComponent<EnemyController>();

                if (isInAttackRange)
                {
                    agent.SetDestination(transform.position);

                    if (!alreadyAttacked)
                    {
                        enemy.TakeDamage(damage);
                        Debug.Log("Enemy: " + enemy + " took this much Damage: " + damage);
                        alreadyAttacked = true;
                        Invoke(nameof(ResetAttack), timeBetweenAttacks);
                    }
                }
                //else
                //{
                //    agent.SetDestination(enemy.transform.position);
                //}
                
            }
        }
        else if (listeningToCommand)
        {
            attacking = null;
        }
    }



    public void StartListeningToCommand()
    {
        listeningToCommand = true;
    }

    public void StopListeningToCommand()
    {
        listeningToCommand = false;
    }

    public void SetCommandDestination(Vector3 target)
    {
        agent.SetDestination(target);
        attacking = null;
    }


    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}
