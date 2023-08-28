using System.Collections;
using System.Collections.Generic;
using Unity_DesignPatterns.Abstracts;
using Unity_DesignPatterns.Concretes;
using UnityEngine;

public class CubeFactory : BaseFactory
{
    [SerializeField] List<GameObject> _cubePrefabs = new List<GameObject>();

    public const int CUBE_TYPE_1 = 0;
    public const int CUBE_TYPE_2 = 1;
    public const int CUBE_TYPE_3 = 2;

    public override int Count => _cubePrefabs.Count;

    public override IProduct GetProduct(int productType, Vector3 position)
    {
        switch (productType)
        {
            case CUBE_TYPE_1:
                var cube1 = GameObject.Instantiate(_cubePrefabs[CUBE_TYPE_1], transform);
                cube1.transform.position = position;
                return new Cube1Product(cube1);
            case CUBE_TYPE_2:
                var cube2 = GameObject.Instantiate(_cubePrefabs[CUBE_TYPE_2], transform);
                cube2.transform.position = position;
                return new Cube2Product(cube2);
            case CUBE_TYPE_3:
                var cube3 = GameObject.Instantiate(_cubePrefabs[CUBE_TYPE_3], transform);
                cube3.transform.position = position;
                return new Cube3Product(cube3);
        }

        return null;
    }



}
