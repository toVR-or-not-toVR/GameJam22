using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemThrower : MonoBehaviour
{
    [SerializeField] private List<GameObject> items = new List<GameObject>();
    [SerializeField] private Transform finishPoint;
    [SerializeField] private float rangeX;
    [SerializeField] private float rangeZ;
    [SerializeField] private float cooldown;


    IEnumerator Start()
    {
        while (true)
        {
            ThrowItem();
            yield return new WaitForSeconds(cooldown);
        }
    }

    private void ThrowItem()
    {
        GameObject obj = CreateRandomItem(items, transform.position);
        Vector3 finishPosition = RandomFinishPosition(finishPoint, rangeX, rangeZ);

        obj.GetComponent<Rigidbody>().velocity = BallisticVel(finishPosition, 45f);
    }


    private GameObject CreateRandomItem(List<GameObject> items, Vector3 spawnPosition)
    {
        GameObject item = items[Random.Range(0, items.Count)];
        return GameObject.Instantiate(item, spawnPosition, Quaternion.identity);
    }
    private Vector3 RandomFinishPosition(Transform finishPoint, float rangeX, float rangeZ)
    {
        Vector3 newFinishPosition = finishPoint.position;

        float offsetX = Random.Range(-rangeX, rangeX);
        float offsetZ = Random.Range(-rangeZ, rangeZ);

        newFinishPosition.x += offsetX;
        newFinishPosition.z += offsetZ;

        return newFinishPosition;
    }
    private Vector3 BallisticVel(Vector3 target, float angle)
    {
        Vector3 dir = target - transform.position;
        float h = dir.y;
        dir.y = 0;
        float dist = dir.magnitude;
        float a = angle * Mathf.Deg2Rad;
        dir.y = dist * Mathf.Tan(a);
        dist += h / Mathf.Tan(a);

        float vel = Mathf.Sqrt(dist * Physics.gravity.magnitude / Mathf.Sin(2 * a));
        return vel * dir.normalized;
    }
}
