using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapKill : MonoBehaviour {
    

    void OnCollisionEnter(Collision col)
    {
        StageFail.Failure();
    }


}
