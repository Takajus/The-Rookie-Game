using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingMovementTeamVague : MonoBehaviour
{
    public float speed;
    [Header("moveUp")]
    public Vector2 moveUp;
    public Transform transmax;
    [Header("moveDown")]
    public Vector2 moveDown;
    public Transform transmin;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(moveUp * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(moveDown * speed * Time.deltaTime);
        }

        if(transform.position.y == transmax.position.y)
        {
            
        }
        else if(transform.position.y == transmin.position.y)
        {
            
        }
    }
}
