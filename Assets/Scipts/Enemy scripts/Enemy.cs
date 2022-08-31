using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float enemySpeed = 2;

    private Rigidbody2D myBody;

    [SerializeField]
    private GameObject bullet;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        StartCoroutine(EnemyShoot());
    }

    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, -enemySpeed);
    }

    IEnumerator EnemyShoot()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));

        Vector3 temp = transform.position;
        temp.y -= 0.6f;
        Instantiate(bullet, temp, Quaternion.identity);

        StartCoroutine(EnemyShoot());
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.CompareTag("Player")) {
            Destroy(target.gameObject);
            GamePlayController.instance.PlaneDiedShowPanel();
        }

        if(target.CompareTag("Borders")) {
            Destroy(gameObject);
        }
    }
}
