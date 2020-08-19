using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderRobot : MonoBehaviour
{
    public CameraBehavior cameraBehavior;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed);
    }

    public void LegImpact()
    {
        StartCoroutine(cameraBehavior.Shake(1.0f, 1000000f, transform.position));
    }
}
