using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;
    private bool isWalking = false;
    private bool isFacingRight = true; // Add a flag to track the character's facing direction

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        if (horizontalInput > 0)
        {
           
            SetWalking(true);
            FlipCharacter(true);
        }
        else if (horizontalInput < 0)
        {
       
            SetWalking(true);
            FlipCharacter(false);
        }
        else
        {
            
            SetWalking(false);
        }
    }

    void SetWalking(bool walking)
    {
        isWalking = walking;
        anim.SetBool("IsWalking", isWalking); 
    }

    void FlipCharacter(bool faceRight)
    {
        if ((faceRight && !isFacingRight) || (!faceRight && isFacingRight))
        {
            Vector3 theScale = transform.localScale;
            theScale.z *= -1;
            transform.localScale = theScale;
            isFacingRight = faceRight;
        }
    }
}
