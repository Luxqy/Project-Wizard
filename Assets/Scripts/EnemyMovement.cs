using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyMove : MonoBehaviour
{
    public float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.down * moveSpeed * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            Physics2D.IgnoreCollision(collision.collider, GetComponent<Collider2D>());
        }
        else
        {
            moveSpeed = 0;

        }
    }


}