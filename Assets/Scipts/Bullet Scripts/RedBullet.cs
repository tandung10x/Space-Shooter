using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBullet : MonoBehaviour
{
    public float speed = 3;

    private Rigidbody2D myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myBody.velocity = new Vector2(0f, -speed);
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(target.tag == "Player") {
            Destroy(target.gameObject);
        }
    }
}
