using UnityEngine;
using System.Collections;

public class GameTest : MonoBehaviour {
	BaseEntity test;
	// Use this for initialization
	void Start () {
		test = new Test();
	}
	
	// Update is called once per frame
	void Update () {
		test.Update();
	}
}
