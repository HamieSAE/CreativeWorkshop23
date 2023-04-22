using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public float spinSpeed = 100f; // Controls how fast the coin spins

    // Update is called once per frame
    void Update()
    {
        // Rotate the coin around the Y axis by spinSpeed degrees per second
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f);
    }
}
