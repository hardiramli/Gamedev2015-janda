using UnityEngine;
using System.Collections;

public class CheckPlayer : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
	// nambahin animasi fadein and fadeout
	void OnTriggerEnter2D(Collider2D col){
		if (col.CompareTag("Player")) {
			// cara naif heheheheh
			this.GetComponent<SpriteRenderer>().enabled = false;
			//this.gameObject.SetActive(false);
		}
	}
	void OnTriggerExit2D(Collider2D col){
		if (col.CompareTag("Player")) {
			//this.gameObject.SetActive(true);
			this.GetComponent<SpriteRenderer>().enabled = true;
		}
	} 
}
