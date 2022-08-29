using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float worldHeight = Camera.main.orthographicSize * 2f;
        //Debug.Log(worldHeight);
        float worldWidth = worldHeight * Screen.width / Screen.height; // divide to the resolution
        transform.localScale = new Vector3(worldWidth, worldHeight, 0f);
    }
}
