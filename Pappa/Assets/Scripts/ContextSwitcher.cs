using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContextSwitcher : MonoBehaviour {

#pragma warning disable
	[SerializeField]
	private Animator playerAnimator;
	[SerializeField]
	private RangeContextPair[] ranges;
#pragma warning restore

	public int position {
		set {
			foreach (RangeContextPair range in ranges) {
				if (range.Contains(value)) {
					playerAnimator.SetTrigger(range.contextName);
					break;
				}
			}
		}
	}
}
