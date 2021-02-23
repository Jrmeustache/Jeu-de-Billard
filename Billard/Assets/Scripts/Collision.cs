using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private Rigidbody rb;
    private float posX;
    private float posY;
    private bool isCollision;
    private GameObject sourceObject;
    private GameObject targetObject;

    public Collision(GameObject sourceObject, GameObject targetObject)
    {
        this.rb = sourceObject.GetComponent<Rigidbody>();
        rb.isKinematic = false;
        this.sourceObject = sourceObject;
        this.targetObject = targetObject;
    }

    public Vector3 getAfterCollisionVector()
    {
        Vector3 finalVector = new Vector3();

        finalVector.Set(sourceObject.GetComponent<Rigidbody>().velocity.x, sourceObject.GetComponent<Rigidbody>().velocity.y, sourceObject.GetComponent<Rigidbody>().velocity.z);

        return finalVector;
    }
    public float getPosX()
    {
        return this.posX;
    }

    public void setPosX(float posX)
    {
        this.posX = posX;
    }

    public float getPosY()
    {
        return this.posY;
    }

    public void setPosY(float posY)
    {
        this.posY = posY;
    }

    public GameObject getTarget1()
    {
        return this.sourceObject;
    }

    public GameObject getTarget2()
    {
        return this.targetObject;
    }

    private float computeTheta(Vector3 vector)
    {

        return 0f;
    }

    private Vector3 computefinalSpeed(float m1, float m2, float v1, GameObject source)
    {
        Vector3 finalSpeed = new Vector3(-rb.velocity.x, -rb.velocity.y, -rb.velocity.z);
        /*Vector3 finalSpeed;
        if (ReferenceEquals(source, sourceObject))
        {
            finalSpeed = ((m1 - m2) / (m1 + m2)) * v1;
        }
        else if (ReferenceEquals(source, targetObject))
        {
            finalSpeed = ((2 * m1) / (m1 + m2)) * v1;
        }
        else
        {
            finalSpeed = 0f;
        }*/

        return finalSpeed;
    }

}
