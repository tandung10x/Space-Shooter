using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    private BoxCollider2D box;
    // Start is called before the first frame update
    void Awake()
    {
        box = GetComponent<BoxCollider2D>();    
    }

    void Start()
    {
        StartCoroutine(SpawnerEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnerEnemy()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));

        float minX = -box.bounds.size.x / 2f;
        float maxX = box.bounds.size.x / 2f;

        Vector3 temp = transform.position;
        temp.x = Random.Range(minX, maxX);
        Instantiate(enemy, temp, Quaternion.identity);

        StartCoroutine(SpawnerEnemy());
    }
}
