using UnityEngine;
using UnityEngine.AI;

public class DisplayPathfinding : MonoBehaviour
{
    public Transform target;
	public LineRenderer lineRenderer;
	NavMeshPath path;
	NavMeshAgent agent;

	private void Start()
	{
		agent = GetComponent<NavMeshAgent>();
		agent.destination = target.position;
	}

	private void Update()
	{
		path = agent.path;
		lineRenderer.positionCount = path.corners.Length;
		lineRenderer.SetPositions(path.corners);
	}

	public void SetTarget(Transform newTarget)
	{
		target = newTarget;
		agent.destination = target.position;
	}
}
