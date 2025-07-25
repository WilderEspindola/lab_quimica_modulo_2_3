using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [Tooltip("Cantidad que baja el cubo en Y (por clic).")]
    public float descentAmount = 0.1f; // Ajustable en el Inspector

    [Tooltip("Altura m�nima permitida (Y no puede ser menor a esto).")]
    public float minYPosition = 0.1f; // L�mite inferior en Y

    private Vector3 originalPosition; // Guarda la posici�n inicial

    void Start()
    {
        originalPosition = transform.position; // Posici�n exacta inicial
    }

    // M�todo para bajar el cubo (llamado por el bot�n UI)
    public void MoveCubeDown()
    {
        Vector3 currentPosition = transform.position;

        // Calcula la nueva posici�n Y (restando descentAmount, pero no menos de minYPosition)
        float newY = Mathf.Max(currentPosition.y - descentAmount, minYPosition);

        // Aplica el movimiento SOLO en Y (mantiene X y Z originales)
        transform.position = new Vector3(currentPosition.x, newY, currentPosition.z);
    }

    // (Opcional) Resetear a la posici�n inicial
    public void ResetPosition()
    {
        transform.position = originalPosition;
    }
}