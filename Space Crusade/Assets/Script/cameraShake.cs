using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
	public float shakeStrenth = 0.3f;
	public IEnumerator shake(float duration, float strength)
	{
		Vector3 orignPos = transform.localPosition;

		float time = 0.0f;

		while (time < duration)
		{
			float x = Random.Range(-shakeStrenth, shakeStrenth) * strength;
			float y = Random.Range(-shakeStrenth, shakeStrenth) * strength;

			transform.localPosition = new Vector3(x, y, orignPos.z);

			time += Time.deltaTime;

			yield return null;
		}
		transform.localPosition = orignPos;
	}
}
