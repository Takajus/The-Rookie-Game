using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public List<Transform> tpplayer;
    public int nbr;
    public int nbrmax;
    public KeyCode up;
    public KeyCode down;
   
    void Start()
    {
        Move(nbr);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(up))
        {
            nbr += 1;
            Move(nbr);
        }
        else if (Input.GetKeyDown(up))
        {
            nbr -= 1;
            Move(nbr);
        }
    }


    public void Move(int count)
    {
        if(count<0)
        {
            nbr += 1;
        }else if(count>nbrmax)
        {
            nbr -= 1;
        }
        transform.position = tpplayer[nbr].position;
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("DeathTrigger"))
        {
            Debug.Log("trop nul la honte");
        }
    }

}
