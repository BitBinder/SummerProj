using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface IStats {

	Dictionary<string,int> GetStats();
	void SetStats(string stat, int val);
}
