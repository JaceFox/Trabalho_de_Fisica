using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamCtrl : MonoBehaviour
{
    [SerializeField] GameObject TruckA;
    [SerializeField] GameObject TruckB;

    float PosX;
    float PosZ;
    float DistAB;

    void Update()
    {
        PosX = (TruckA.transform.position.x + TruckB.transform.position.x) / 2;
        PosZ = (TruckA.transform.position.x - TruckB.transform.position.x) * .5f + 10;

        gameObject.transform.position = new Vector3(PosX, 0, -PosZ);
    }
}