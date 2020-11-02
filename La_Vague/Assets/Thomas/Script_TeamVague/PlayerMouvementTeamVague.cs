using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouvementTeamVague : MonoBehaviour
{
    GamePlayerManagerTeamVague GameManager;

    public bool isGrounded;
    public Transform groundCheck;
    public float checkRaduis;
    public LayerMask whatIsGround;

    [SerializeField]

    public bool isStoped;
    public Transform wallCheck;
    public float wallCheckRaduis;
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
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRaduis, whatIsGround);
        isStoped = Physics2D.OverlapCircle(wallCheck.position, wallCheckRaduis, whatIsStoped);

    }
}
