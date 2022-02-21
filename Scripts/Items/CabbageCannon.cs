using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabbageCannon : MonoBehaviour
{

    public GameObject projectile;

    [SerializeField] private int maxAmmo = 10;  
    [SerializeField] private int currentAmmo;
    [SerializeField] private float fireRate = 0.2f;
    [SerializeField] private float projSpeed = 30f;

    [SerializeField] private Transform shootPoint;

    private InputManager inputManager;



    private void Start()
    {
        inputManager = InputManager.Instance;

        currentAmmo = maxAmmo;
    }

    private void Update()
    {
        if (inputManager.Fire())
        {
            if (currentAmmo > 0)
            {
                StartCoroutine(Shoot());
            }
            else
            {
                Debug.Log("Buy More Ammo");
            }
        }
    }

    IEnumerator Shoot()
    {
        //currentAmmo--;

        //Instantiate Projectile Here
        GameObject proj = Instantiate(projectile, shootPoint.position, Quaternion.identity);
        proj.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * projSpeed, ForceMode.Impulse);

        Debug.Log("Projectile Shot");
        yield return new WaitForSeconds(fireRate);
    }

    public void AddAmmo(int amount)
    {
        currentAmmo += amount;
    }

}
