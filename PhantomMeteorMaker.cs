using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomTroupe
{
    public class PhantomMeteorMaker : MonoBehaviour, IFactorySpell
    {
        [SerializeField] private GameObject prefab;

        public GameObject Make()
        {
            var newGameObject = Instantiate(prefab);
            return newGameObject;
        }
    }
}
