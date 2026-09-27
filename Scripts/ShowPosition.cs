using UnityEngine;

public class ShowPosition : MonoBehaviour
{
    private Transform sphereTransform;
    public int framesEspera = 1000;
    private int contadorFrames = 0;

    void Start()
    {
        sphereTransform = GetComponent<Transform>();
    }

    void Update()
    {   
        contadorFrames++;
        if (contadorFrames >= framesEspera)
        {
            Debug.Log("Posición de la esfera: " + sphereTransform.position);
            contadorFrames = 0;
        }
    }
}