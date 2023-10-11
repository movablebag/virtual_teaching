using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.localPosition;
        pos.x += 0.01f;
        this.transform.localPosition = pos;


    }
}
