using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWithTag : MonoBehaviour
{
    public void DestroyTag(string destroyTag)
    {
        GameObject[] meshObjects;
        meshObjects = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject meshObject in meshObjects)
        {
            Destroy(meshObject);
        }
    }
}
