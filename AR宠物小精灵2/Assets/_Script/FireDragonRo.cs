using UnityEngine;
using System.Collections;

public class FireDragonRo : MonoBehaviour {
    public float speed = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Transform>().Rotate(Vector3.down*Time.deltaTime*speed);
	}
}
