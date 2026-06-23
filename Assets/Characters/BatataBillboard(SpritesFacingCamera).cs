using UnityEngine;

public class BatataBillboard : MonoBehaviour
{
    private Transform cameraPrincipal;

    void Start()
    {
        // Acha a câmera automaticamente usando a Tag "MainCamera"
        if (Camera.main != null)
        {
            cameraPrincipal = Camera.main.transform;
        }
    }

    // Usamos LateUpdate para que o sprite só gire DEPOIS que a câmera já tiver se movido no frame
    void LateUpdate()
    {
        if (cameraPrincipal != null)
        {
            // Força o sprite a ter exatamente a mesma rotação da lente da câmera
            transform.rotation = cameraPrincipal.rotation;
        }
    }
}