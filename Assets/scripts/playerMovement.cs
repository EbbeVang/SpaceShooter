using System.Collections;
using System.Collections.Generic;
using System.Security.Policy;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class playerMovement : MonoBehaviour
{
    public float Speed;
    public int Score = 0;
    public float LaserBeamCoolDown = 1;
    public float NextFire;
    private AudioSource audioSource;
    private GameObject HUD_Score;
    

    // Use this for initialization
	void Start ()
	{
	    audioSource = GetComponent<AudioSource>();
	    HUD_Score = GameObject.FindGameObjectWithTag("Score");
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.DownArrow))
	    {
            //Debug.Log("make sure this is happening");
            transform.Translate(Vector3.down * Speed * Time.deltaTime);
        }

	    if (Input.GetKey(KeyCode.UpArrow))
	    {
	        transform.Translate(Vector3.up * Speed * Time.deltaTime);
        }

	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
	        transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }

	    if (Input.GetKey(KeyCode.RightArrow))
	    {
	        transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }

	    if (Input.GetKey(KeyCode.Space))
	    {
	        // shoot / spawn bullet
	        if (Time.time > NextFire)
	        {
	            GameObject bullet = Instantiate(Resources.Load("laserbeam", typeof(GameObject))) as GameObject;
	            bullet.transform.position = transform.position;
                audioSource.Play();
                NextFire = Time.time + LaserBeamCoolDown;

            }
        }
	}

    public void IncreaseScore(int score)
    {
        Debug.Log("recieves score");
        this.Score += score;
        HUD_Score.SendMessage("UpdateScore", score);
    }

}
