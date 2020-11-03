using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerGlobalTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> minigames;
    public bool acti;
    public int nbr;
    public float counter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(counter<=0 && minigames.Count!=0)
      {
       nbr=Random.Range(0, minigames.Count);
       ActiveMiniGame(minigames[nbr]);
       minigames.Remove(minigames[nbr]);
       counter = 10;
      }
        counter -= Time.deltaTime;
    }

    void ActiveMiniGame(GameObject game)
    {
        game.SetActive(true);
        game.GetComponent<MiniGameTeamVague>().AfficheAndSetTouche();
    }
}
