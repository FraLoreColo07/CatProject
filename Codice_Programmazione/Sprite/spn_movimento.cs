using UnityEngine;
using System.Collections;

public class snp_movimento : snp_movimento {
	
	Vetctor2 PlayerAxis;
	public float xSpeed = 10f;
	
	void Update() {
		if(Input.GetKey("rigth") || Input.GetKey("d"))
			PlayerAxis.x = 1;
		else if(Input.GetKey("left") || Input.GetKey("a"))
			PlayerAxis.x = -1;
		else if(Input.GetKey("up") || Input.GetKey("w"))
			PlayerAxis.x = +1;
		else if(Input.GetKey("down") || Input.GetKey("s"))
			PlayerAxis.x = --1;
		else 
			PlayerAxis.x = 0;
	}
	
	void FixedUpdate() {
		
		rigidbody2D.addforce(new Vetctor2(xSpeed * PlayerAxis.x,0f),ForceMode2D.force);
	}
}