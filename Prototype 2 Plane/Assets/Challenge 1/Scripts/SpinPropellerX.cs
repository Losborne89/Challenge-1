using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    [SerializeField]
    private float anglesPerSecond = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = transform.localEulerAngles;
        rotation.z += Time.deltaTime * anglesPerSecond;
        transform.localEulerAngles = rotation;
    }
}
