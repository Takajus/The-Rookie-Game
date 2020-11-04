using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerGlobalTeamVague : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> minigames;
    public List<GameObject> minigamesobso;
    public bool acti;
    public int nbr;
    public float counter;
    public float CounterBetween;
    public List<Transform> listTransform;
    public List<Transform> listTransformObso;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(counter<=0 && minigames.Count!=0 && acti==false)
      {
       nbr=Random.Range(0, minigames.Count);
       ActiveMiniGame(minigames[nbr],listTransform[0]);
       minigamesobso.Add(minigames[nbr]);
            
       minigames.Remove(minigames[nbr]);
       listTransformObso.Add(listTransform[0]);
      listTransform.Remove(listTransform[0]);
      counter = CounterBetween;
      }
        counter -= Time.deltaTime;
    }

    void ActiveMiniGame(GameObject game,Transform list)
    {
        GameObject mini = Instantiate(game, list.position, transform.rotation);
        mini.GetComponent<MiniGameTeamVague>().GameManage = this.gameObject;
        mini.GetComponent<MiniGameTeamVague>().AfficheAndSetTouche();
    }

    public void ObsoToMini()
    {
        minigames.Add(minigamesobso[0]);
        minigamesobso.Remove(minigamesobso[0]);
        listTransform.Add(listTransformObso[0]);
        listTransformObso.Remove(listTransformObso[0]);
    }
}
