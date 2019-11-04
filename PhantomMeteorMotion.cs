using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PhantomTroupe
{
    public class PhantomMeteorMotion : MonoBehaviour
    {
        private float radius = 3.5f;
        private Vector3 center;
        private float angle;
        private float RotateSpeed = 5.0f;
        private float lifeSpan;
        private float timeAlive = 0.0f;

        void Start()
        {
            this.center = new Vector3(0.0f,7.0f,0.0f);
            this.lifeSpan = Random.Range(10.0f,40.0f);
        }

        void Update()
        {
            this.angle += this.RotateSpeed * Time.deltaTime;
            var offset = new Vector3(Mathf.Cos(this.angle), 0.0f, Mathf.Sin(this.angle)) * this.radius;
            this.gameObject.transform.position = this.center + offset;

            // Destroying the meteor after a certain amount of time.
            if(this.timeAlive >= this.lifeSpan)
            {
                Destroy(this.gameObject);
                this.timeAlive = 0.0f;
            }
            else
            {
                this.timeAlive += Time.deltaTime;
            }
        }
    }
}