using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerGlobalTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Jeu1;
    public bool acti;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(acti)
        {
            ActiveMiniGame(Jeu1);
            acti = false;
        }
    }

    void ActiveMiniGame(GameObject game)
    {
        game.SetActive(true);
        game.GetComponent<MiniGameTeamVague>().AfficheAndSetTouche();
    }
}
