using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTextureSetup : MonoBehaviour
{
    /*
    public Camera camera2;
    public Camera camera1;
    public Camera cameraTest;

    public Material cameraMat1;

    public Material cameraMat2;

    public Material cameraMatTest;
*/
    public Camera[] cameras;
    public Material[] materials;
    

    private void Start() {
        for (int i = 0; i < cameras.Length && i < materials.Length; i++)
        {
            Camera camera = cameras[i];
            Material material = materials[i];
            if (camera.targetTexture != null)
            {
                camera.targetTexture.Release();
            }
            camera.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
            material.mainTexture = camera.targetTexture;

        }
    }
}
