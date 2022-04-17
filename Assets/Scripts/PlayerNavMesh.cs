using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour {
    public NavMeshAgent agent;
    public Camera camera;

    private void Update() {
        // _navMeshAgent.destination = movePositionTransform.position;
        if (!Input.GetMouseButtonDown (0)) return;
            var ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out var hit)) {
                agent.SetDestination(hit.point);
            };
    }
}
