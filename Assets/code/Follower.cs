using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    public Transform Origin;
    // Update is called once per frame
    void Update()
    {
        if (Origin == null) return;
        var position = Origin.position + new Vector3(0, 0, -10f);
        transform.position = Vector3.Lerp(transform.position, position, Time.deltaTime*speed);
    }
}
