using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabDestoroy : MonoBehaviour {

	public GameObject unitychan;

	// Use this for initialization
	void Start () {
		unitychan = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		if (unitychan.transform.position.z > this.transform.position.z+10){
			GameObject.Destroy(this.gameObject);
		}
		
	}
}
