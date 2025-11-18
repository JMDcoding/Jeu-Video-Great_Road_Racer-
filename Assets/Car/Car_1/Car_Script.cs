using UnityEngine;

public class Car_Script : MonoBehaviour
{
    public float acceleration = 20f;      // accélération en avant
    public float maxSpeed = 20f;          // vitesse max
    public float turnSpeed = 80f;         // vitesse de rotation
    public float deceleration = 10f;      // frein naturel

    private float currentSpeed = 0f;

    void Update()
    {
        // --- ACCÉLÉRATION AVANT/ARRIÈRE ---
        float input = Input.GetAxis("Vertical");

        if (input != 0)
        {
            // accélère
            currentSpeed += input * acceleration * Time.deltaTime;
        }
        else
        {
            // ralentit naturellement
            currentSpeed = Mathf.MoveTowards(currentSpeed, 0, deceleration * Time.deltaTime);
        }

        // limite la vitesse
        currentSpeed = Mathf.Clamp(currentSpeed, -maxSpeed, maxSpeed);

        // --- DÉPLACEMENT ---
        transform.Translate(Vector3.forward * currentSpeed * Time.deltaTime);

        // --- ROTATION (uniquement si on avance un peu) ---
        float horizontal = Input.GetAxis("Horizontal");

        if (Mathf.Abs(currentSpeed) > 0.5f)
        {
            transform.Rotate(Vector3.up * horizontal * turnSpeed * Time.deltaTime);
        }
    }
}
