using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MatrixBlender))]
public class BlendMeDaddy : MonoBehaviour
{
    private Camera cam;
    private Matrix4x4 ortho,
                        perspective;
    public float fov = 60f,
                        near = .3f,
                        far = 1000f,
                        orthographicSize = 50f;
    private float aspect;
    private MatrixBlender blender;
    private bool orthoOn;

    void Start()
    {
        cam = GetComponent<Camera>();
        aspect = (float)Screen.width / (float)Screen.height;
        ortho = Matrix4x4.Ortho(-orthographicSize * aspect, orthographicSize * aspect, -orthographicSize, orthographicSize, near, far);
        perspective = Matrix4x4.Perspective(fov, aspect, near, far);
        cam.projectionMatrix = perspective;
        orthoOn = false;
        blender = (MatrixBlender)GetComponent(typeof(MatrixBlender));
    }

    void Update()
    {

    }

    public void PerspectiveSwitch()
    {
        orthoOn = !orthoOn;
        if (orthoOn)
            blender.BlendToMatrix(ortho, 1f);
        else
            blender.BlendToMatrix(perspective, 1f);
    }
}
