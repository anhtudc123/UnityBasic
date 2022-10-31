using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Animator cubeAnimator = GameObject.Find("Cube").GetComponent<Animator>();
        cubeAnimator.speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
