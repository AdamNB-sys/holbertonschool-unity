using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class RaycastScript : MonoBehaviour
{
    public GameObject spawn_prefab;
    ARRaycastManager arRayMan;
    ARPlaneManager arPlaneMan;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        arRayMan = GetComponent<ARRaycastManager>();
        arPlaneMan = GetComponent<ARPlaneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the screen is touched, a ray is cast from the touch position. The plane that is hit is saved, while other planes are discarded.
        if (Input.touchCount > 0)
        {
            Debug.Log("Touch Found");

            if (arRayMan.Raycast(Input.GetTouch(0).position, hits, TrackableType.PlaneWithinPolygon))
            {
                Debug.Log("Raycast Hit");
                var savedPlane = hits[0].trackable as ARPlane;
                
                foreach (var plane in arRayMan.trackables)
                {
                    if (plane != savedPlane)
                    {
                        plane.gameObject.SetActive(false);
                    }
                }
                // Disable the ARRaycastManager and the ARPlaneManager to prevent further planes from being detected.
                var planeSubsystem = arPlaneMan.subsystem;

                if (planeSubsystem != null)
                {
                    planeSubsystem.Stop();
                }

                arRayMan.enabled = false;
                arPlaneMan.enabled = false;
            }
        }
    }
}
