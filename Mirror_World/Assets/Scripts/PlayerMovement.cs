using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform player;
    // bool isJumping;
    float move;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        move=Input.GetAxis("Horizontal")*5;
        // player.position+=new Vector3 (move,0,0);
        rb.velocity = new Vector3(move,0,0);
        if(Input.GetButtonDown("Jump") && isInAir())
        {
            // isJumping=true;

            rb.velocity = new Vector3(move, 1, 0) * 5;
        }
    }
    bool isInAir(){
        RaycastHit2D  hit = Physics2D.Raycast(transform.position, Vector3.down, 10f);

        int layerMask=LayerMask.GetMask("Ground");
        if(Physics2D.Raycast(transform.position, Vector3.down, .5f,layerMask)){
            return true;
        }
        else return false;
    }
}
