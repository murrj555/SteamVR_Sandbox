using UnityEngine;

public class DrawGizmos : MonoBehaviour
{
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(
            GetComponent<Renderer>().bounds.center, GetComponent<Renderer>().bounds.size);
    }
}