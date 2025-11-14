using System;
using UnityEngine;
using UnityEngine.Events;

public class DisableOnTrigger : MonoBehaviour
{
	public UnityEvent<Single> OnEnter;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
			OnEnter.Invoke(new Single());
	}
}
