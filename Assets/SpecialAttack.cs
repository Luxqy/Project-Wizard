using UnityEngine;

public class SpecialAttack : MonoBehaviour
{
    float manaInterval = 2f;
    float nextManaTime;

   public int damage = 100;
    public int powerMana = 0;


    private void Start()
    {
        powerMana = 0;
        nextManaTime = Time.time + manaInterval;
    }
    void Update()
    {
        if(Time.time > nextManaTime)
        {
            powerMana += 20;
            nextManaTime = Time.time + manaInterval;
        }

        if (Input.GetKeyDown(KeyCode.Space) && powerMana >= 100)
        {
            Debug.Log("Hello world");
            // Perform your action here

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

            // Loop through each game object
            foreach (GameObject enemy in enemies)
            {
                EnemyHealth enemyHealth = enemy.GetComponent<EnemyHealth>();

                if (enemyHealth != null && powerMana == 100)
                {
                    enemyHealth.TakeDamage(damage);
                }
               
            }
            
        }
    }
}