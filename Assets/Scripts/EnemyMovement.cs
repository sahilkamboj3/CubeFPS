using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float minDist = 2f;
    public float speed = 10f;
    public float attackDamage = 1f;
    public GameObject enemyDeathEffect;
    public float enemyHealth = 100f;

    public NavMeshAgent agent;


    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        transform.LookAt(player);

        float dist = Vector3.Distance(player.position, transform.position);
        if (dist > minDist)
        {
            agent.SetDestination(player.position);
            //transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (dist <= minDist)
        {
            PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
            playerHealth.TakeDamage(attackDamage);
        }
    }

    public void TakeDamage(float damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
            Scorer scorer = FindObjectOfType<Scorer>();
            scorer.Increment();
            RunEffect();
            Destroy(gameObject);
        }
    }

    void RunEffect()
    {
        Vector3 pos = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        var animation = Instantiate(enemyDeathEffect, pos, Quaternion.identity);
        Destroy(animation, 1);
    }
}
