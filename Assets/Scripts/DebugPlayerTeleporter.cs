using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugPlayerTeleporter : MonoBehaviour
{
    public GameObject playerObject;
    public List<Transform> locations = new List<Transform>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        playerObject.GetComponent<ThirdPersonController>()._controller.enabled = false;
        switch (Input.inputString)
        {
            case "1":
                playerObject.transform.localPosition = locations[0].position;
                playerObject.transform.rotation = locations[0].rotation;
                break;
            case "2":
                playerObject.transform.localPosition = locations[1].position;
                playerObject.transform.rotation = locations[1].rotation;
                break;
            case "3":
                playerObject.transform.localPosition = locations[2].position;
                playerObject.transform.rotation = locations[2].rotation;
                break;
            case "4":
                playerObject.transform.localPosition = locations[3].position;
                playerObject.transform.rotation = locations[3].rotation;
                break;
            case "5":
                playerObject.transform.localPosition = locations[4].position;
                playerObject.transform.rotation = locations[4].rotation;
                break;
            case "6":
                playerObject.transform.localPosition = locations[5].position;
                playerObject.transform.rotation = locations[5].rotation;
                break;
            case "7":
                playerObject.transform.localPosition = locations[6].position;
                playerObject.transform.rotation = locations[6].rotation;
                break;
            case "8":
                playerObject.transform.localPosition = locations[7].position;
                playerObject.transform.rotation = locations[7].rotation;
                break;
            case "9":
                playerObject.transform.localPosition = locations[8].position;
                playerObject.transform.rotation = locations[8].rotation;
                break;
            case "0":
                playerObject.transform.localPosition = locations[9].position;
                playerObject.transform.rotation = locations[9].rotation;
                break;
            default:
                break;
        }
        playerObject.GetComponent<ThirdPersonController>()._controller.enabled = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerObject.transform.localPosition = locations[0].position;
            playerObject.transform.rotation = locations[0].rotation;
        }
    }
}
