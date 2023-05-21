//
// Copyright (c) Brian Hernandez. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for details.
//

using UnityEngine;
using System.Collections.Generic;

public class GearVisuals : MonoBehaviour
{
    public WheelCollider[] wheels;
    public Transform wheelVisualizerPrefab;

    private Dictionary<Transform, WheelCollider> visualToWheelMap;

    private void Awake()
    {
        visualToWheelMap = new Dictionary<Transform, WheelCollider>();
    }

    private void Update()
    {
        if (visualToWheelMap.Count > 0)
        {
            Vector3 pos;
            Quaternion rot;

            foreach (var visualWheel in visualToWheelMap)
            {
                visualWheel.Value.GetWorldPose(out pos, out rot);
                visualWheel.Key.position = pos;
                visualWheel.Key.rotation = rot;
                // Apply brakes when Fire2 axis is pressed
                if (Input.GetButton("Fire2"))
                {
                    visualWheel.Value.brakeTorque = 100f; // Adjust the brake torque as needed
                }
                else
                {
                    visualWheel.Value.brakeTorque = 0f;
                }
            }
        }
    }
}

