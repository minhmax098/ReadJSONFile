using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONReader : MonoBehaviour
{
    public TextAsset textJSON; 
    
    [System.Serializable]
    public class Player 
    {
        public string name;  
        public int health; 
        public int mana; 

    }

    // [System.Serializable]
    // public class Scheduler
    // {
    //     public string action; 
    //     public int score; 
    //     public string boole; 
    // }

    [System.Serializable]
    public class PlayerList
    {
        public Player[] player; 

    }

    // public class SchedulerList
    // {
    //     public Scheduler[] scheduler; 
    // }

    public PlayerList myPlayerList = new PlayerList(); 

    // public SchedulerList mySchedulerList = new SchedulerList();
    // Start is called before the first frame update
    void Start()
    {
        myPlayerList = JsonUtility.FromJson<PlayerList>(textJSON.text);

        // mySchedulerList = JsonUtility.FromJson<SchedulerList>(textJSON.text); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
