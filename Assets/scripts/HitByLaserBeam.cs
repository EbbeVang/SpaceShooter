using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitByLaserBeam : MonoBehaviour
{
    private GameObject Player;
    public int KillScore = 1000;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void hitByLaserBeam()
    {
        Player.SendMessage("IncreaseScore", KillScore);
        Destroy(this.gameObject);
    }
}
