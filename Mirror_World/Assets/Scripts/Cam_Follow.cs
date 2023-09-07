using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam_Follow : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    public Vector3 offset;
    public Transform Player;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.position=Player.position + offset;
    }
}
