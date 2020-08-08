using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCrosser : MonoBehaviour {

	[SerializeField]
	private Transform playerTransform;
	[SerializeField]
	private Transform[] crosses;

    void Update() {
        foreach (Transform cross in crosses) {
			if (playerTransform.position.x > cross.position.x) cross.gameObject.SetActive(true);
			else cross.gameObject.SetActive(false);
		}
    }
}
