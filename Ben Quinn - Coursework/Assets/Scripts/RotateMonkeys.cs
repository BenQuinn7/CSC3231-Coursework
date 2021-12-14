// Credit: Ketra Games on YouTube
// Tutorial: https://www.youtube.com/watch?v=7fdSYc8WElo

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMonkeys : MonoBehaviour
{

    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, rotationSpeed) * Time.deltaTime);
    }
}