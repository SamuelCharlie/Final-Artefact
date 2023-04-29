using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruction : MonoBehaviour
{
	[SerializeField] GameObject prefabMesh;
	[SerializeField] private MeshScale _meshScale;

	private float _meshWidth;
	private float _meshHeight;
	private float _meshDepth;

	[SerializeField] private float meshScale = 0.5f;

	void Start()
	{
		_meshWidth = transform.localScale.x;
		_meshHeight = transform.localScale.y;
		_meshDepth = transform.localScale.z;

		prefabMesh.gameObject.GetComponent<Transform>().localScale = new Vector3(meshScale, meshScale, meshScale);

	}

	private void OnCollisionEnter(UnityEngine.Collision collision)
	{
		if (collision.gameObject.tag == "Projectile")
		{
			CreateCube();
		}
	}

	void CreateCube()
	{

		if (gameObject.CompareTag("Full"))
		{
			for (float x = 0; x < _meshWidth; x += meshScale)
			{
				for (float y = 0; y < _meshHeight; y += meshScale)
				{
					for (float z = 0; z < _meshDepth; z += meshScale)
					{
						GameObject cubes = Instantiate(prefabMesh, transform.position + new Vector3(x, y, z), Quaternion.identity);
						cubes.gameObject.GetComponent<MeshRenderer>().material = gameObject.GetComponent<MeshRenderer>().material;
					}
				}
			}
		}
		else if (gameObject.CompareTag("Half"))
		{
			for (float x = 0; x < _meshWidth; x += meshScale)
			{
				for (float y = 0; y < _meshHeight; y += meshScale)
				{
					for (float z = 0; z < _meshDepth; z += meshScale)
					{
						GameObject cubes = Instantiate(prefabMesh, transform.position + new Vector3(x, y, z), Quaternion.identity);
						cubes.gameObject.GetComponent<MeshRenderer>().material = gameObject.GetComponent<MeshRenderer>().material;
					}
				}
			}
		}
		else if (gameObject.CompareTag("Quarter"))
		{
			for (float x = 0; x < _meshWidth; x += meshScale)
			{
				for (float y = 0; y < _meshHeight; y += meshScale)
				{
					for (float z = 0; z < _meshDepth; z += meshScale)
					{
						GameObject cubes = Instantiate(prefabMesh, transform.position + new Vector3(x, y, z), Quaternion.identity);
						cubes.gameObject.GetComponent<MeshRenderer>().material = gameObject.GetComponent<MeshRenderer>().material;
					}
				}
			}
		}
		else if (gameObject.CompareTag("Tenth"))
		{
			for (float x = 0; x < _meshWidth; x += meshScale)
			{
				for (float y = 0; y < _meshHeight; y += meshScale)
				{
					for (float z = 0; z < _meshDepth; z += meshScale)
					{
						GameObject cubes = Instantiate(prefabMesh, transform.position + new Vector3(x, y, z), Quaternion.identity);
						cubes.gameObject.GetComponent<MeshRenderer>().material = gameObject.GetComponent<MeshRenderer>().material;
					}
				}
			}
		}

		Destroy(this.gameObject);
	}

}
