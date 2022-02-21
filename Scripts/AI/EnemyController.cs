using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public Transform finalDestination;

    public LayerMask playerLayer, allyLayer, groundLayer;

    public GameObject itemDrop;

    [SerializeField] private int health = 50;
    [SerializeField] private int damage = 10;



    //Attacking
    [SerializeField] private float timeBetweenAttacks = 2f;
    bool alreadyAttacked;
    public GameObject attacking;

    //States
    public float sightRange, attackRange;
    public bool isInSightRange, isInAttackRange;


    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();

        if (FindObjectOfType<EnemyDestination>() != null)
        {
            finalDestination = FindObjectOfType<EnemyDestination>().transform;
        }
    }


    private void Update()
    {
        //Check for allies in Attack Range
        isInSightRange = Physics.CheckSphere(transform.position, sightRange, allyLayer);
        isInAttackRange = Physics.CheckSphere(transform.position, attackRange, allyLayer);

        if (isInSightRange)
        {
            StartAttack();
        }
        else if (!isInSightRange)
        {
            if (finalDestination != null)
            {
                SetDestination(finalDestination);
            }
        }


    }


    private void StartAttack()
    {
        if (attacking == null)
        {
            Collider[] target = Physics.OverlapSphere(transform.position, sightRange, allyLayer);

            if (target != null && target.Length > 0)
            {
                attacking = target[0].gameObject;
                if (!isInAttackRange)
                {
                    agent.SetDestination(attacking.transform.position);
                }
            }
        }

        if (attacking != null)
        {
            AllyController ally = attacking.GetComponent<AllyController>();

            if (isInAttackRange)
            {
                agent.SetDestination(transform.position);
                transform.LookAt(attacking.transform);

                if (!alreadyAttacked)
                {
                    ally.TakeDamage(damage);
                    alreadyAttacked = true;
                    Invoke(nameof(ResetAttack), timeBetweenAttacks);
                }
            }
            //else
            //{
            //    SetDestination(ally.transform);
            //}
        }
    }


    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void SetDestination(Transform transform)
    {
        agent.SetDestination(transform.position);
    }


    public void TakeDamage (int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }


    private void DropItem()
    {
        Instantiate(itemDrop, transform.position, Quaternion.identity);
    }


    private void Die()
    {
        DropItem();
        Destroy(gameObject);
    }
}
