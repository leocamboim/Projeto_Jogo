using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsWalk : MonoBehaviour
{
    Vector3 playerAxis;
    Vector3 playerRotAxis;
    Vector3 headRotAxis;
    public CharacterController charac;
    public GameObject prefabProjectile;
    public GameObject prefabProjectile1;
    public GameObject prefabProjectile2;
    public GameObject prefabProjectile3;
    public GameObject prefabProjectile4;
    public GameObject prefabProjectile5;
    public GameObject prefabProjectile6;
    public GameObject prefabProjectile7;
    public GameObject prefabProjectile8;
    public GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        playerAxis = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 globalmove = transform.TransformDirection(playerAxis);//local pra global 
        charac.SimpleMove(globalmove * 5);
        playerRotAxis = new Vector3(0, Input.GetAxis("Mouse X"), 0);
        headRotAxis = new Vector3(-Input.GetAxis("Mouse Y"), 0, 0);

        transform.Rotate(playerRotAxis);//gira o corpo
        head.transform.Rotate(headRotAxis);//gira cabeca

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ball = Instantiate(prefabProjectile, transform.position+head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000+ Vector3.up*200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right*500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameObject ball = Instantiate(prefabProjectile1, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameObject ball = Instantiate(prefabProjectile2, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameObject ball = Instantiate(prefabProjectile3, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameObject ball = Instantiate(prefabProjectile4, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            GameObject ball = Instantiate(prefabProjectile5, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            GameObject ball = Instantiate(prefabProjectile6, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            GameObject ball = Instantiate(prefabProjectile7, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            GameObject ball = Instantiate(prefabProjectile8, transform.position + head.transform.forward, transform.rotation);
            ball.GetComponent<Rigidbody>().AddForce(head.transform.forward * 1000 + Vector3.up * 200);
            ball.GetComponent<Rigidbody>().AddRelativeTorque(Vector3.right * 500, ForceMode.Impulse);
            Destroy(ball, 3);
        }
    }
}
