using UnityEngine;

public class BreakingPot : MonoBehaviour
{
	public GameObject Pot, BrokenPot;

	void OnClick()
	{
		Pot.SetActive(false);
		BrokenPot.SetActive(true);
	}

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		Pot.SetActive(true);
	}

	// Update is called once per frame
	void Update()
	{
		for (int i = 0; i < Input.touchCount; ++i) {
			Touch touch = Input.GetTouch(i);
			if (Input.GetTouch(i).phase == TouchPhase.Began)
			{
				Debug.Log("Clicked !");
				// Construct a ray from the current touch coordinates
				Ray ray = Camera.main.ScreenPointToRay(touch.position);
				// Create a particle if hit
				if (Physics.Raycast(ray, 3f)) {
					OnClick();
				}
			}
		}
	}
}
