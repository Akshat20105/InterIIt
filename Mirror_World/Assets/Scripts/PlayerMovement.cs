using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D a;
    private BoxCollider2D coll;
    // public bool iswalking=false;
    private Animator anime;
    public LayerMask jumpableGround;
    private SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        a=GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        anime = GetComponent<Animator>();
        sp=GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float x =Input.GetAxis("Horizontal");
        a.velocity=new Vector2(x * 5f,a.velocity.y);
        if(x!=0f) anime.SetBool("iswalking",true);
        else anime.SetBool("iswalking",false);
        if(Input.GetKeyDown("space") && IsGrounded()){
            a.velocity=new Vector2(0,4);
        }
        
        if(x>0f) sp.flipX=true;
        else if(x<0f) sp.flipX=false;
     }
    private bool IsGrounded(){
        return Physics2D.BoxCast(coll.bounds.center,coll.bounds.size,0f, Vector2.down,.1f,jumpableGround);
    }
}

