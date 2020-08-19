using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude, Vector3 sourcePosition)
    {
        Vector3 originalPos = transform.localPosition;
        float distance = Vector3.Distance(sourcePosition, transform.position);
        float multiplier = 1 / (distance * distance) * magnitude;

        float time = 0.0f;

        while (time < duration)
        {
            float x = Random.Range(-1f, 1f) * multiplier;
            float y = Random.Range(-1f, 1f) * multiplier;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            time += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }
}
