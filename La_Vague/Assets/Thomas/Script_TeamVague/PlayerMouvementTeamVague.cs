using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvementTeamVague : MonoBehaviour
{
    GamePlayerManagerTeamVague GameManager;

    [Header("Ground Checker")]

    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    [Header("Wall Checker")]

    public bool isStoped;
    public Transform wallCheck;
    //public float wallCheckRaduis;
    public Vector2 wallCheckRadius;
    public LayerMask whatIsStoped;

    void Start()
    {
        GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
        GameManager = gameController.GetComponent<GamePlayerManagerTeamVague>();

        isGrounded = false;
        isStoped = false;
    }

    void Update()
    {
        if(isGrounded == true && isStoped == false)
        {
            transform.Translate(GameManager.moveVector * GameManager.moveSpeed * Time.deltaTime);
        }
        
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        isStoped = Physics2D.OverlapBox(wallCheck.position, wallCheckRadius, 0.0f, whatIsStoped);

    }
}
