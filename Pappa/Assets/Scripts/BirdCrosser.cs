using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCrosser : MonoBehaviour {

#pragma warning disable
	[SerializeField]
	private Transform playerTransform;
	[SerializeField]
	private Transform[] crosses;
#pragma warning restore

	void Update() {
        foreach (Transform cross in crosses) {
			if (playerTransform.position.x > cross.position.x) cross.gameObject.SetActive(true);
			else cross.gameObject.SetActive(false);
		}
    }
}
