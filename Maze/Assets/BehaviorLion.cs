using UnityEngine;
using System.Collections;

public class BehaviorLion : MonoBehaviour {

	public float speed = 0.05f;
	public float speedSprint = 0.1f;
	public float stamina = 100f;
	public float totalStamina = 100f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//update yg fix
	void FixedUpdate(){
		float directionX = Input.GetAxisRaw("Horizontal");
		float directionY = Input.GetAxisRaw("Vertical");
		Vector3 posisi = transform.position;
		if (Input.GetButton("Fire1") && stamina > 0f) {
			posisi.y += speedSprint * directionY;
			posisi.x += speedSprint * directionX;
			stamina -= 4f;
		} else {
			posisi.y += speed * directionY;
			posisi.x += speed * directionX;
			if(stamina <= totalStamina && !Input.GetButton("Fire1")){
				stamina += 2f;
			}
		}
		transform.position = posisi;
	}
}
