using UnityEngine;

public enum State
{
    MENU,
    LOOKING,
    PATHFINDING,
}

public class StateMachine : MonoBehaviour
{
    public static StateMachine instance;
    public State currentState;

    public GameObject uiMenu;
    public GameObject uiLooking;
    public GameObject uiPathfinding;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        if (instance == null)
        {
            instance = this;
        } 
        else
        {
            Destroy(gameObject);
		}

        currentState = State.MENU;
	}

    void Update()
    {
        uiMenu.SetActive(currentState == State.MENU);
        uiLooking.SetActive(currentState == State.LOOKING);
        uiPathfinding.SetActive(currentState == State.PATHFINDING);
	}
}
