using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D a;
    private BoxCollider2D coll;
    public bool isJumping=false;
    public LayerMask jumpableGround;
    // Start is called before the first frame update
    void Start()
    {
        a=GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x =Input.GetAxis("Horizontal");
        a.velocity=new Vector2(x * 7f,a.velocity.y);
        if(Input.GetKeyDown("space") && IsGrounded()){
            a.velocity=new Vector2(a.velocity.x,10);
            isJumping=true;
        }
     }
    private bool IsGrounded(){
        return Physics2D.BoxCast(coll.bounds.center,coll.bounds.size,0f, Vector2.down,.1f,jumpableGround);
    }
}

