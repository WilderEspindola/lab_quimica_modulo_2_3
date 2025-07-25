using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [Tooltip("Cantidad que baja el cubo en Y (por clic).")]
    public float descentAmount = 0.1f; // Ajustable en el Inspector

    [Tooltip("Altura mínima permitida (Y no puede ser menor a esto).")]
    public float minYPosition = 0.1f; // Límite inferior en Y

    private Vector3 originalPosition; // Guarda la posición inicial

    void Start()
    {
        originalPosition = transform.position; // Posición exacta inicial
    }

    // Método para bajar el cubo (llamado por el botón UI)
    public void MoveCubeDown()
    {
        Vector3 currentPosition = transform.position;

        // Calcula la nueva posición Y (restando descentAmount, pero no menos de minYPosition)
        float newY = Mathf.Max(currentPosition.y - descentAmount, minYPosition);

        // Aplica el movimiento SOLO en Y (mantiene X y Z originales)
        transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);
    }

    // (Opcional) Resetear a la posición inicial
    public void ResetPosition()
    {
        transform.position = originalPosition;
    }
}