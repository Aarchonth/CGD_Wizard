using UnityEngine;

public class Target_Script : MonoBehaviour
{
    public GameObject targetPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnTarget(targetPrefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTarget(GameObject target)
    {
        Instantiate(target, Vector3.zero, Quaternion.identity);
    }
}
