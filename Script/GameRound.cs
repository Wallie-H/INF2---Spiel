using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;   //acces to list
using System.Linq;
using UnityEngine.SceneManagement;

public class GameRound {

    public int stage = 0;
    public int score = 0;
    public string name = "";
   
    public string Print()
    {
        return "Name: " + name + "  Stage: " + stage + "  Score: " + score;
    }

    public string ToStringScore()
    {
        return "" + score;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
