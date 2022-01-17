using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;

public class CommandAllies : MonoBehaviour
{
    public LayerMask allyLayer, groundLayer;
    public GameObject debugObject;
    public Camera cam;

    InputManager inputManager;

    [SerializeField] private float commandRadius = 10f;
    [SerializeField] private bool commanding;

    Collider[] allies;

    private void Start()
    {
        inputManager = InputManager.Instance;

        if (allies == null) { Debug.Log("array is null"); }
    }


    private void Update()
    {
        //Enable and Disable Command State Variable

        if (inputManager.EnableCommandControls())
        {
            if (!GameManager.isPlayerInCommandState)
            {
                StartCommandState();
                Debug.Log("Command State True: " + GameManager.isPlayerInCommandState);
            }
            else
            {
                EndCommandState();
                Debug.Log("Command State False: " + GameManager.isPlayerInCommandState);
            }
        }

        if (inputManager.Command())
        {
            if (GameManager.isPlayerInCommandState)
            {
                Ray ray = cam.ScreenPointToRay(inputManager.GetMouseDelta());
                RaycastHit hit;
                //Debug.DrawRay()

                if (Physics.Raycast(ray, out hit, 100f, groundLayer))
                {
                    //Fill Ally Array
                    if (allies == null || allies.Length <= 0)
                    {
                        allies = Physics.OverlapSphere(hit.point, commandRadius, allyLayer);
                        //Debug.Log("Filled Array");
                        Debug.Log(allies.Length);
                    }

                    if (!commanding)
                    {
                        if (allies.Length > 0)
                        {
                            commanding = true;
                        }

                        for (int i = 0; i < allies.Length; i++) 
                        {
                            Debug.Log(allies[i]);
                            allies[i].GetComponent<AllyController>().StartListeningToCommand();
                        }
                    }
                    else
                    {
                        for (int i = 0; i < allies.Length; i++)
                        {
                            allies[i].gameObject.GetComponent<AllyController>().SetCommandDestination(hit.point);
                            allies[i].gameObject.GetComponent<AllyController>().StopListeningToCommand();
                        }
                        Debug.Log(hit.point);
                        Instantiate(debugObject, hit.point, Quaternion.identity);
                        allies = null;
                        commanding = false;
                    }
                }
            }
        }
    }

    private void StartCommandState()
    {
        GameManager.isPlayerInCommandState = true;
    }

    private void EndCommandState()
    {
        commanding = false;
        allies = null;
        GameManager.isPlayerInCommandState = false;
    }
}
