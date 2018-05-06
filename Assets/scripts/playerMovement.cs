using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float Speed;

    public float LaserBeamCoolDown = 1;
    public float NextFire;
    public AudioSource audioSource;

    // Use this for initialization
	void Start ()
	{
	    audioSource = GetComponent<AudioSource>();
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
}
