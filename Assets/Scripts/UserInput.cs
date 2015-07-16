using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	public float speed = 4.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// This code is framerate dependent (behavior will be different base on framerate)
		// transform.position += new Vector3(0, 0, 1f);

		// This code is framerate independent (Time.deltaTime == time between frame)
		// 60 FPS >> Time.deltaTime = ~16 ms
		// 10 FPS >> Time.deltaTime = ~100 ms
		if (Input.GetKey(KeyCode.W))
		{
			transform.position += new Vector3(0, 0, 1f) * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position += new Vector3(-1f, 0, 0) * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position += new Vector3(0, 0, -1f) * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += new Vector3(1f, 0, 0) * Time.deltaTime * speed;
		}
		
		// Could also do this by creating shift speeed variable and setting it 
		// equal on GetKey a la:
		//	 if (Input.GetKey (KeyCode.LeftShift)){
		//		actualSpeed = shiftSpeed;
		//	 } else {
		//		actualSpeed = speed;
		//	 } 
		// you would then change speed above to actualSpeed
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			speed *= 2;
		}
		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			speed = speed/2;
		}
	}
}
