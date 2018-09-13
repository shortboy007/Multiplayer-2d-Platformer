﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter(Collision coll)
	{
		GameObject collidedWith = coll.gameObject;
		if (collidedWith.tag == "Ball")
		{
			Destroy(collidedWith);
}
	}
}