using Unity.VisualScripting;
using UnityEngine;

public class BreakingPot : MonoBehaviour
{
    public GameObject Pot, BrokenPot;

    void OnClick()
    {
        BrokenPot.SetActive(true);
        Pot.SetActive(false);
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
                Input.simulateMouseWithTouches = true;
                //Input.GetMouseButtonDown(0);
                if (Input.GetTouch(i).phase == TouchPhase.Began) {
                    // Construct a ray from the current touch coordinates
                    Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);

                    // Create a particle if hit
                    if (Physics.Raycast(ray)) {
                        OnClick();
                        Debug.Log("Clicked !");
                    }
                }
        }
    }
}
