using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ChestController : MonoBehaviour
{

    public GameObject closedChest;
    public GameObject openChest;
    public GameObject emptyChest;
    public GameObject uiPressQ;
    public GameObject endGoal;

    public int chestHP = 3;
    public int swordDamage = 1;

    public Text score;

    private bool isChestOpen = false;

    
        // This function is called every frame
        void Update()
        {
            // Check if the Q key has been pressed and the chest is open
            if (Input.GetKeyDown(KeyCode.Q) && isChestOpen)
            {
                // Update the score text to show that the treasure has been obtained
                score.text = "Treasure Obtained!";
                // Activate the empty chest object and deactivate the open chest object
                emptyChest.SetActive(true);
                openChest.SetActive(false);
                // Deactivate the UI prompt to press Q and activate the end goal object
                uiPressQ.SetActive(false);
                endGoal.SetActive(true);
            }
        }

        // This function is called when the chest collides with another object
        void OnCollisionEnter(Collision collision)
        {
            // Check if the colliding object has the "Sword" tag
            if (collision.gameObject.tag == "Sword")
            {
                // Reduce the chest's hit points by the amount of damage the sword deals
                chestHP -= swordDamage;
                // Check if the chest has run out of hit points
                if (chestHP <= 0)
                {
                    // Deactivate the closed chest object and activate the open chest object
                    closedChest.SetActive(false);
                    openChest.SetActive(true);
                    // Activate the UI prompt to press Q and set the chest as open
                    uiPressQ.SetActive(true);
                    isChestOpen = true;
                }
            }
        }
    /*I need to move this to another script and put it on End Goal*/
    /*
        // This function is called when another object enters the chest's trigger zone
        void OnTriggerEnter(Collider other )
        {
            // Check if the entering object has the "Player" tag
            if (other.gameObject.tag == "Player")
            {
                // Load the end game scene
                SceneManager.LoadScene("EndGame");
            }
        }
    */
    
}
