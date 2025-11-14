using System;
using UnityEngine;
using UnityEngine.Events;

public class OnScannedEvent : MonoBehaviour
{
	public UnityEvent<bool> onScanned;
	float timer = 0f;

	private void OnEnable()
	{
		onScanned.Invoke(true);
		timer = 0f;
	}

	private void Update()
	{
		timer += Time.deltaTime;
	}

	public void DisableGameObjectAfter5s(GameObject obj)
	{
		if (timer >= 5f)
			obj.SetActive(false);
	}
}
