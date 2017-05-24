using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// As this is a 'helper' class, it will not be directly attached to an object,
// therefore we don't need to inherit from MonoBehaviour.
public class HexMetrics {

    public const float outerRadius = 10f; // Create a reference to the outer radius for our hexagons, we will assign the value 10 to this. We will make this a float for precision.
    public const float innerRadius = outerRadius * 0.866025404f; // Create a reference to the inner radius of the hexagons. We will apply some pythagoras math to this to calculate the inner radius.

    // Create a static Vector3 array to help us store and position
    // the six corners relative to the cell's centre. We'll position
    // the hexagons with the corner at the top.
    public static Vector3[] corners =
    {
        // We add the points clockwise starting with the top corner
        new Vector3(0f, 0f, outerRadius),
        new Vector3(innerRadius, 0f, 0.5f * outerRadius),
        new Vector3(innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(0f, 0f, -outerRadius),
        new Vector3(-innerRadius, 0f, -0.5f * outerRadius),
        new Vector3(-innerRadius, 0f, 0.5f * outerRadius)
    };
}
