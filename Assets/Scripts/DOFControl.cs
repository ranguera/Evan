using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class DOFControl : MonoBehaviour
{
    public PostProcessVolume volume;
    public Camera vrcam;

    private DepthOfField dof;
    private FloatParameter fDistance;

    // Start is called before the first frame update
    void Start()
    {
        volume.profile.TryGetSettings<DepthOfField>(out dof);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
            dof.focusDistance.value += Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
            dof.focusDistance.value -= Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
            dof.aperture.value += Time.deltaTime;
        if (Input.GetKey(KeyCode.S))
            dof.aperture.value -= Time.deltaTime;

        if (Input.GetKey(KeyCode.E))
            dof.focalLength.value += Time.deltaTime;
        if (Input.GetKey(KeyCode.D))
            dof.focalLength.value -= Time.deltaTime;

        if (Input.GetKey(KeyCode.R))
            vrcam.focalLength += Time.deltaTime;
        if (Input.GetKey(KeyCode.F))
            vrcam.focalLength -= Time.deltaTime;
    }
}
