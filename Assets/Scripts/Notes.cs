using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -20 * Time.deltaTime, 0);
    }
}
