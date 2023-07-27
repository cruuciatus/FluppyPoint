using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D MyRigidbody;
    private LogicManager Logic;
    [SerializeField] private float flapStreight;
    public bool BirdIsAlive = true;
    public static readonly int JumpKey = Animator.StringToHash("jump");
    public static readonly int DeadKye = Animator.StringToHash("isdead");
    public Animator Animator;

    void Awake()
    {

        Animator = GetComponent<Animator>();
        Logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManager>();
    }


    void Update()
    {
        BirdJump();

        if (transform.position.y <= -4 )
        {
            BirdIsAlive = false;
            Logic.GameOver();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Logic.GameOver();
        BirdIsAlive = false;
        Animator.SetTrigger(DeadKye);
        MyRigidbody.isKinematic = true;
    }


    public void BirdJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            Animator.SetTrigger(JumpKey);
            MyRigidbody.velocity = Vector2.up * flapStreight;
        }

    }
}
