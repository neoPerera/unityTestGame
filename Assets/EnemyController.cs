using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform PlayerTransform;
    public Transform EnemyTransform;
    public GameObject enemyObj;
    public CharacterController2D enemyCharacterController;
    public float MoveSpeed = 15f;
    public Animator animEnemy;

    void Start()
    {
        animEnemy = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyCharacterController.Move((PlayerTransform.position - EnemyTransform.position).normalized.x * MoveSpeed, false, false);
        Debug.Log("DISTANCE = " + Vector2.Distance(PlayerTransform.position, EnemyTransform.position ) + " SIDE = " + (PlayerTransform.position - EnemyTransform.position).normalized.x);
    }

    public void FnEnemyDie()
    {
        Debug.Log("ENEMY DIED");
        animEnemy.SetTrigger("TrgEnemyDie");
       //
        this.enabled = false;
        GetComponent<Rigidbody2D>().simulated = false;
        GetComponent<Collider2D>().enabled = false;

    }



}
