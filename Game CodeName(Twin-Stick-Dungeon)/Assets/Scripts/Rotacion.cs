using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    public float offSetRotacion;

    // Update is called once per frame
    void Update()
    {
        Vector3 diferencial = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotacionZ = Mathf.Atan2(diferencial.y, diferencial.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotacionZ + offSetRotacion);
    }
}
