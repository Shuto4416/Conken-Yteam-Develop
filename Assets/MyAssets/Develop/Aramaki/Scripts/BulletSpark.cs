using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aramaki.Script.Bullet.Spark {
    public class BulletSpark : MonoBehaviour
    {
        struct PlanetProperties {
            public string Name;
            public Vector3 origin;
            public Vector3 position;
            public float _time;
            public float period;
            public float radius;
            public float startingPoint;
        }
        PlanetProperties[] _planetProperties = new PlanetProperties[8] {
            new PlanetProperties() { 
                Name = "Sun",
                origin = new Vector3(0,0,0),
                position = new Vector3(-4.5f,0,0),
                period = 10,
                radius = 1.5f,
                startingPoint = 0
                },
            new PlanetProperties() { 
                Name = "Mercury",
                origin = new Vector3(0,0,0),
                position = new Vector3(-3f,0,0),
                period = 0.241f,
                radius = 0.5f,
                startingPoint = 180
                },
            new PlanetProperties() { 
                Name = "Venus",
                origin = new Vector3(0,0,0),
                position = new Vector3(-1.5f,0,0),
                period = 10,
                radius = 1.5f,
                startingPoint = 0
                },
            new PlanetProperties() { 
                Name = "Sun",
                origin = new Vector3(0,0,0),
                position = new Vector3(-1.5f,0,0),
                period = 10,
                radius = 1.5f,
                startingPoint = 0
                },
            new PlanetProperties() { 
                Name = "Sun",
                origin = new Vector3(0,0,0),
                position = new Vector3(-1.5f,0,0),
                period = 10,
                radius = 1.5f,
                startingPoint = 0
                },
            new PlanetProperties() { 
                Name = "Sun",
                origin = new Vector3(0,0,0),
                position = new Vector3(-1.5f,0,0),
                period = 10,
                radius = 1.5f,
                startingPoint = 0
                },
            new PlanetProperties() { 
                Name = "Sun",
                origin = new Vector3(0,0,0),
                position = new Vector3(-1.5f,0,0),
                period = 10,
                radius = 1.5f,
                startingPoint = 0
                },
            new PlanetProperties() { 
                Name = "Sun",
                origin = new Vector3(0,0,0),
                position = new Vector3(-1.5f,0,0),
                period = 10,
                radius = 1.5f,
                startingPoint = 0
                }
        };
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
