using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public KartClassic_Player player;

    var c = GetComponent<RayPerceptionSensorComponent3D>();
    RayPerceptionInput spec = c.GetRayPerceptionInput();
    RayPerceptionOutput obs = RayPerceptionSensor.Perceive(spec);
}
