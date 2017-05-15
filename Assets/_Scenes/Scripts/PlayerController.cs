using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;
	private int count;
	public Text countText;
	
	public float alpha = 1f;
	private Shader fadeShader = null;
	private Material fadeMaterial = null;
	
	void Start()
	{

		count = 0;
		rb = GetComponent<Rigidbody>();
		SetCountText();
	}
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		Vector3 movement = new Vector3(moveHorizontal,0.0f,moveVertical);
		
		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if(other.gameObject.CompareTag("Pick Up"))
		{
			Application.LoadLevel("gameOver");
			//other.gameObject.SetActive(false);
			//count++;
			//SetCountText();
			
		}
    }
	
	void SetCountText()
	{
		countText.text = "Count:" + count.ToString();
	}

}