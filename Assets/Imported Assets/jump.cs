using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {
	public float speed; //declare the player move speed in Unity inspector
	public int jumpHeight; //this is set in the Unity Inspector
	int jumpHash = Animator.StringToHash ("jump");
	Animator anim;                         // Reference to the Animator component on this gameobject.
	// Use this for initialization
	void Start () {
		anim = GetComponent <Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200f);
			anim.SetTrigger(jumpHash);
			anim.enabled = true;
}
}
}