using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public float planeSpeed = 3;

    private Rigidbody2D myBody;

    [SerializeField]
    private GameObject bullet;

    private bool canShoot = true;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //PlaneMovementByKeyboard();
        PlaneMovementByMouse();
    }

    void Update()
    {
        if((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)) && canShoot)
        {
            StartCoroutine(Shoot());
        }
    }
    void PlaneMovementByKeyboard()
    {
        float xAxis = Input.GetAxisRaw("Horizontal") * planeSpeed;
        float yAxis = Input.GetAxisRaw("Vertical") * planeSpeed;

        myBody.velocity = new Vector2(xAxis, yAxis);
    }

    void PlaneMovementByMouse()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
    }
    IEnumerator Shoot() //delay
    {
        canShoot = false;

        Vector3 temp = transform.position;
        temp.y += 0.6f;
        Instantiate(bullet, temp, Quaternion.identity);

        yield return new WaitForSeconds(0.3f);
        canShoot = true;
    }
}
