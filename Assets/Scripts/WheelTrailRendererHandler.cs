using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelTrailRendererHandler : MonoBehaviour
{
    // Components
    CarController carController;
    TrailRenderer trailRenderer;

    // Awake is called when the script instance is being loaded
    private void Awake()
    {
        // get the car controller
        carController = GetComponentInParent<CarController>();

        // get the tril renderer components
        trailRenderer = GetComponent<TrailRenderer>();

        // set the trail renderer to not emit in the start
        trailRenderer.emitting = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        trailRenderer.emitting = carController.IsTireScreeching(out float lateralVelocity, out bool isBraking);
    }
}
