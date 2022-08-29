using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowBullet : MonoBehaviour
{
    public float speed = 4;

    private Rigidbody2D myBody;

    private void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        myBody.velocity = new Vector2(0f, speed);
    }
}
