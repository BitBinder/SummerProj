using UnityEngine;
using System.Collections;
using Helpers;

public interface IEntity {
	void GetTag();
	void SetTag();

	void SetPriority();
	void GetPriority();
	void SetGamePrefab();
	void SetRigidBody();
	Rigidbody2D GetRigidBody();
	void SetInput(Input input);
	Tuple<float,float> GetInput();
	void Update();
	void CalculateItems(); //used for getting equipped bonuses. Will be a class in future.
	IHealth GetEntityHealth();
	IHealth SetEntityHealth();
}
    
