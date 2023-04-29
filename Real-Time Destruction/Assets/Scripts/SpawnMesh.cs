using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMesh : MonoBehaviour
{
    [SerializeField] private DestroyWithTag destroyWithTag;
    [SerializeField] private ValueCalc valueCalc;
    [SerializeField] private Destruction destruction;

    [SerializeField] private GameObject _meshFull;
    [SerializeField] private GameObject _meshHalf;
    [SerializeField] private GameObject _meshQuarter;
    [SerializeField] private GameObject _meshTenth;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private Transform[] _spawnPoints;
    private int counter = 0;

    public bool setSpawn = false;

    public void SetSpawn()
    {
        setSpawn = !setSpawn;
    }
   public void CreateMeshFull()
    {
        destroyWithTag.DestroyTag("Half");
        destroyWithTag.DestroyTag("Quarter");
        destroyWithTag.DestroyTag("Tenth");

        if (!setSpawn)
        {
            destroyWithTag.DestroyTag("Projectile");
            _rb.mass = valueCalc.sliderMassValue;
            Instantiate(_meshFull, new Vector3(0, 2, 0), Quaternion.identity);
        }
        else if (setSpawn)
        {
            if (counter <= 8)
            {
                _rb.mass = valueCalc.sliderMassValue;
                Instantiate(_meshFull, _spawnPoints[counter].position, Quaternion.identity);
                counter++;
            }  
        }
    }

    public void CreateMeshHalf()
    {
        destroyWithTag.DestroyTag("Full");
        destroyWithTag.DestroyTag("Quarter");
        destroyWithTag.DestroyTag("Tenth");

        if (!setSpawn)
        {
            destroyWithTag.DestroyTag("Projectile");
            _rb.mass = valueCalc.sliderMassValue;
            Instantiate(_meshHalf, new Vector3(0, 2, 0), Quaternion.identity);
        }
        else if (setSpawn)
        {
            if (counter <= 8)
            {
                _rb.mass = valueCalc.sliderMassValue;
                Instantiate(_meshHalf, _spawnPoints[counter].position, Quaternion.identity);
                counter++;
            }
        }
    }

    public void CreateMeshQuarter()
    {
        destroyWithTag.DestroyTag("Full");
        destroyWithTag.DestroyTag("Half");
        destroyWithTag.DestroyTag("Tenth");

        if (!setSpawn)
        {
            destroyWithTag.DestroyTag("Projectile");
            _rb.mass = valueCalc.sliderMassValue;
            Instantiate(_meshQuarter, new Vector3(0, 2, 0), Quaternion.identity);
        }
        else if (setSpawn)
        {
            if (counter <= 8)
            {
                _rb.mass = valueCalc.sliderMassValue;
                Instantiate(_meshQuarter, _spawnPoints[counter].position, Quaternion.identity); 
                 counter++;
            }
        }
    }

    public void CreateMeshTenth()
    {
        destroyWithTag.DestroyTag("Full");
        destroyWithTag.DestroyTag("Half");
        destroyWithTag.DestroyTag("Quarter");

        if (!setSpawn)
        {
            destroyWithTag.DestroyTag("Projectile");
            _rb.mass = valueCalc.sliderMassValue;
            Instantiate(_meshTenth, new Vector3(0, 2, 0), Quaternion.identity);
        }
        else if (setSpawn)
        {
            if (counter <= 8)
            {
                _rb.mass = valueCalc.sliderMassValue;
                Instantiate(_meshTenth, _spawnPoints[counter].position, Quaternion.identity);
                counter++;
            }
        }
    }



    public void ClearSceneOfCubes()
    {
        counter = 0;
        destroyWithTag.DestroyTag("Box");
        destroyWithTag.DestroyTag("Full");
        destroyWithTag.DestroyTag("Half");
        destroyWithTag.DestroyTag("Quarter");
        destroyWithTag.DestroyTag("Tenth");
    }
}
