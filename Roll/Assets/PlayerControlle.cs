using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerControlle : MonoBehaviour {
	public float speed;
	public float count;
	public Text countText;
	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		GetComponent<Rigidbody> ().AddForce (movement * speed * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Pick Up") {
			other.gameObject.SetActive (false);
			count++;
			setCountText ();
		}
	}
	void setCountText(){
		countText.text = "Count:" + count;
	}

}
