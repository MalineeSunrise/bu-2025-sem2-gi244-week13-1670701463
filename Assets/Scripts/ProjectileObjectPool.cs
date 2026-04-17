using System.Collections.Generic;
using UnityEngine;

public class ProjectileObjectPool : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private int initialPoolSize = 10;

    private readonly List<GameObject> projectilePool = new();

    private void Awake()
    {

    }

    private void Start()
    {
        for (int i = 0; i < initialPoolSize; i++)
        {
            CreateNewProjectile();
        }
    }

    private void CreateNewProjectile()
    {
        var go = Instantiate(projectilePrefab);
        go.SetActive(false);
        projectilePool.Add(go);
    }

    public GameObject Acquire()
    {
        return null;
    }

    public void Return(GameObject projectile)
    {

    }
}
