using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatPlayer : MonoBehaviour {
    public float speed = 10;
    public float jumpVel = 10;
    public LayerMask playerMask;
    Transform myTrans;
    Transform tagGround;
    private Rigidbody2D myBody;
    bool isGrounded = false;
    private Animator myAnimator;
   

	void Start () {
        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        tagGround = GameObject.Find(this.name+"/tag_ground").transform;
        myAnimator = this.GetComponent<Animator>();
	}

    private void Update()
    {
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);

        myBody.velocity = new Vector2(speed, myBody.velocity.y);

        if (Input.GetButtonDown("Jump")){
            Jump();
        }

        //for animation
        myAnimator.SetFloat("Speed", myBody.velocity.x);
        myAnimator.SetBool("Grounded", isGrounded);

    }

    //=========================================================================//
    //      These functions are for when player controls the move:             //
    //-------------------------------------------------------------------------//

    //void FixedUpdate () {
    //       isGrounded = Physics2D.Linecast(catTrans.position, tagGround.position, playerMask);
    //       Move(Input.GetAxisRaw("Horizontal"));
    //       if(Input.GetButtonDown("Jump")){
    //           Jump();
    //       }
    //}

    //public void Move(float horizontalInput)
    //{
    //    Vector2 moveVel = catBody.velocity;
    //    moveVel.x = horizontalInput * speed;
    //    catBody.velocity = moveVel;
    //}

    //============================================================================//

    public void Jump(){
        if(isGrounded){
            myBody.velocity += jumpVel * Vector2.up;
        } 
    }

   
}
