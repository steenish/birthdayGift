using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NumberRange<T> where T : IComparable {

	[SerializeField]
	private T _lowerBound;
	public T lowerBound { get => _lowerBound; set => _lowerBound = value; }

	[SerializeField]
	private T _upperBound;
	public T upperBound { get => _upperBound; set => _upperBound = value; }

	public bool Within(T candidate) {
		return candidate.CompareTo(lowerBound) >= 0 && candidate.CompareTo(upperBound) <= 0;
	}
}
