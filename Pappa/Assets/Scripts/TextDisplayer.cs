using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextDisplayer : MonoBehaviour {

#pragma warning disable
	[SerializeField]
	private SpriteRenderer renderer;
	[SerializeField]
	private Transform playerTransform;
#pragma warning restore

	void Update() {
		if (playerTransform.position.x + 0.4f >= transform.position.x) renderer.enabled = true;
    }
}
