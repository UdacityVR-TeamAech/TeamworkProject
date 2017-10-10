using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CameraMovement : MonoBehaviour {

    public GameObject viewPoint;
    
    public void MoveCamera(){

        GameObject camera = GameObject.FindGameObjectWithTag("Player");
        Vector3 newPosition = new Vector3(viewPoint.transform.position.x, viewPoint.transform.position.y, viewPoint.transform.position.z);
        iTween.MoveTo(camera, newPosition, 2.0f);
    }


}
