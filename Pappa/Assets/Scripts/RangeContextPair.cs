using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RangeContextPair {

	[SerializeField]
	private int _lowerBound;
	public int lowerBound { get => _lowerBound; private set => _lowerBound = value; }

	[SerializeField]
	private int _upperBound;
	public int upperBound { get => _upperBound; private set => _upperBound = value; }

	[SerializeField]
	private string _contextName;
	public string contextName { get => _contextName; private set => _contextName = value; }

	public bool Contains(int candidate) {
		return lowerBound <= candidate && candidate < upperBound;
	}
}
