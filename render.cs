using System.Collections;

System.Collections.Generic;

Using UnityEngine;

public class Rotate: MonoBehaviour
{
public Vector3 rot;

void Update()
{
transform.Rotate(rot Time.deltaTime);
}
}