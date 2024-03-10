using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;

public class AgentRotate : MonoBehaviour
{
    public Vector2 PointerPosition { get; set; }

    private void Update()
    {;
        transform.up = (PointerPosition - (Vector2)transform.position).normalized;
    }
}
