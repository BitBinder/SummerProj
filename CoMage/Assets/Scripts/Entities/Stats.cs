using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stats : IStats {
	public enum STATS {
		STR,
		MND,
		VIT,
		STAM,
		WILL
	};
	private Dictionary<string,int> entityStats;

	public Stats()
	{
		entityStats = new Dictionary<string, int>();
		entityStats.Add(STATS.STR,0);
		entityStats.Add(STATS.MND,0);
		entityStats.Add(STATS.VIT,0);
		entityStats.Add(STATS.STAM,0);
		entityStats.Add(STATS.WILL,0);

	}

	#region IStats implementation


	public Dictionary<string, int> GetStats ()
	{
		return this.entityStats;
	}


	public void SetStats (string stat, int val)
	{
		entityStats[stat] += val;
	}


	#endregion

}
