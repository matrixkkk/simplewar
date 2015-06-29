using UnityEngine;
using System.Collections;

public class Vehicle_Apc : MonoBehaviour {

    public Transform turretRotation;        //터렛 로테이션
    public Transform barrelRotation;                    //터렛

    public Transform[] wheels;                  //바퀴 들

    public float barrelDegree;                  //총열 각도
    public float turretDegree;                  //

    private float currentTurretDegree = 0f;     //현재 각도

    Quaternion preRot;

    void Start()
    {
        preRot = turretRotation.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        
        //특정 각도가 될떄까지 회전
        //if(currentTurretDegree != turretDegree)
        //{
        //    float fRotValue = 15f;
        //    //현재가 더 큼 
        //    if(currentTurretDegree > turretDegree)
        //    {
        //        if(currentTurretDegree - turretDegree < 1f)
        //        {
        //            currentTurretDegree = turretDegree;
        //        }

        //        fRotValue = -15f * Time.deltaTime;
        //    }
        //    else
        //    {
        //        if(turretDegree - currentTurretDegree < 1f)
        //        {
        //            currentTurretDegree = turretDegree;
        //        }

        //        fRotValue = 15f * Time.deltaTime;
        //    }

        //    currentTurretDegree += fRotValue;

        //    turretRotation.Rotate(Vector3.up, fRotValue);
        //}

        Quaternion dest = Quaternion.AngleAxis(turretDegree,Vector3.up);

        turretRotation.rotation =
          Quaternion.Lerp(turretRotation.rotation, dest, Time.deltaTime * 2f);

        //barrelRotation.Rotate(-Vector3.right, barrelDegree);

        for(int i=0;i<wheels.Length;i++)
        {
            //x 축회전
            wheels[i].Rotate(-Vector3.right, 100f * Time.deltaTime);
        }
	}
}
