using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float MoveSpeed = 15f;
    public Animator Anim;
    public CharacterController2D charactController;
    private bool BoolJump;

    //attack
    public Transform attackPoint;
    public float attackRange;
    public LayerMask enemyLayer; 

    float vertical;
    float horizontal;




    private void Start()
    {
        BoolJump = false;
    }

    void Update()
    {







        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            FnAttack();

        }
        else
        {
            horizontal = Input.GetAxisRaw("Horizontal");
            vertical = Input.GetAxisRaw("Vertical");

            //Animation
            Anim.SetFloat("FloatWalking", Mathf.Abs(MoveSpeed * horizontal * MoveSpeed));
            //Jump
            if (Input.GetButtonDown("Jump"))
            {
                BoolJump = true;
                Anim.SetBool("BoolJump", true);
            }

            charactController.Move(horizontal * MoveSpeed, false, BoolJump);
            BoolJump = false;
        }



    }
    void FixedUpdate()
    {
        //rb.velocity = new Vector2(horizontal * MoveSpeed, vertical * MoveSpeed);
 
    }
    public void OnLanding()
    {
        Anim.SetBool("BoolJump", false);

       
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
    private void FnAttack()
    {
        Anim.SetTrigger("TrgAttack");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);

        foreach (Collider2D enmy in hitEnemies)
        {
            //Debug.Log("WE HIT " + enmy.name);
            enmy.GetComponent<EnemyController>().FnEnemyDie();
        }
    }

}