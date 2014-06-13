using UnityEngine;
using System.Collections;

public class Test : BaseEntity {

	public Test(){
		input = new PlayerInput(this);
	}

	public override void Update ()
	{

		Debug.Log(string.Format("x:{0},y{0}",input.GetKeyBoardMovement().Item1,input.GetKeyBoardMovement().Item2));

	}

}
