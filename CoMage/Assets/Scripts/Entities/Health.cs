using UnityEngine;
using System.Collections;

public class Health : IHealth {
	private float _health;

	#region IHealth implementation

	public Health(){
		_health = 100f;
	}

	public Health(float starting){
		_health = starting;
	}

	public void HealEntity (float amount)
	{
		this._health += amount;
	}

	public void DamageEntity (float amount)
	{
		this._health -= amount;
	}

	public void GetHealth ()
	{

		return this._health;
	}

	#endregion



}
