using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    private Animator animator; 

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
  
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");

    
        animator.SetFloat("Move", Mathf.Abs(horizontalMovement) + Mathf.Abs(verticalMovement));

        bool isJumping = Input.GetKeyDown(KeyCode.Space);
        animator.SetBool("Jump", isJumping);
    }
}
 