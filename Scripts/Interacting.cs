using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacting : MonoBehaviour
{
    [SerializeField] float interactRange = 3f;

    private InputManager inputManager;

    Camera mainCamera;

    void Start()
    {
        inputManager = InputManager.Instance;
        mainCamera = Camera.main;
    }

    public static GameObject lookingAtObj;

    void Update()
    {
        lookingAtObj = GetObjectPlayerIsLookingAt();
        Debug.DrawRay(mainCamera.transform.position, mainCamera.transform.forward * interactRange, Color.red);

        if (inputManager.PlayerPressedInteract())
        {
            if (CheckIfObjectIsInteractable(lookingAtObj))
            {
                lookingAtObj.GetComponent<Interactable>().Interact();
                Debug.Log("Interacted With: " + lookingAtObj);
            }
        }
    }

    public GameObject GetObjectPlayerIsLookingAt()
    {
        GameObject obj;
        if (gameObject.activeInHierarchy)
        {
            RaycastHit hit;
            if (Physics.Raycast(mainCamera.transform.position, mainCamera.transform.forward, out hit, interactRange))
            {
                obj = hit.transform.gameObject;
                //Debug.Log(obj);
                return obj;
            }
        }
        return null;
    }

    private bool CheckIfObjectIsInteractable(GameObject obj = null)
    {
        if (obj != null)
        {
            if (obj.GetComponent<Interactable>() != null)
            {
                return true;
            }
        }
        return false;
    }
}
