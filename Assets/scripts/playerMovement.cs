using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float Speed;

	// Use this for initialization
	void Start ()
	{
	    
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

	    if (Input.GetKeyDown(KeyCode.Space))
	    {
            // shoot / spawn bullet
	        GameObject bullet = Instantiate(Resources.Load("laserbeam", typeof(GameObject))) as GameObject;
	        bullet.transform.position = transform.position;
        }
	}
}
