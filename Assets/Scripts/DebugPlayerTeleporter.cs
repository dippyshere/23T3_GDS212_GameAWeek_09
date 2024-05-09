using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugPlayerTeleporter : MonoBehaviour
{
    public GameObject playerObject;
    public List<Transform> locations = new List<Transform>();

    private void OnEnable()
    {
        Keyboard.current.onTextInput += OnTextInput;
    }

    private void OnDisable()
    {
        Keyboard.current.onTextInput -= OnTextInput;
    }

    private void OnTextInput(char character)
    {
        playerObject.GetComponent<ThirdPersonController>()._controller.enabled = false;
        switch (character)
        {
            case '1':

                playerObject.transform.localPosition = locations[0].position;
                playerObject.transform.rotation = locations[0].rotation;
                break;
            case '2':
                playerObject.transform.localPosition = locations[1].position;
                playerObject.transform.rotation = locations[1].rotation;
                break;
            case '3':
                playerObject.transform.localPosition = locations[2].position;
                playerObject.transform.rotation = locations[2].rotation;
                break;
            case '4':
                playerObject.transform.localPosition = locations[3].position;
                playerObject.transform.rotation = locations[3].rotation;
                break;
            case '5':
                playerObject.transform.localPosition = locations[4].position;
                playerObject.transform.rotation = locations[4].rotation;
                break;
            case '6':
                playerObject.transform.localPosition = locations[5].position;
                playerObject.transform.rotation = locations[5].rotation;
                break;
            case '7':
                playerObject.transform.localPosition = locations[6].position;
                playerObject.transform.rotation = locations[6].rotation;
                break;
            case '8':
                playerObject.transform.localPosition = locations[7].position;
                playerObject.transform.rotation = locations[7].rotation;
                break;
            case '9':
                playerObject.transform.localPosition = locations[8].position;
                playerObject.transform.rotation = locations[8].rotation;
                break;
            case '0':
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
        if (other.gameObject.CompareTag("Player"))
        {
            playerObject.transform.localPosition = locations[0].position;
            playerObject.transform.rotation = locations[0].rotation;
        }
    }
}
