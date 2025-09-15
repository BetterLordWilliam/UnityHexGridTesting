using UnityEditor;
using UnityEngine;

public class HexGrid : MonoBehaviour
{
    [SerializeField]
    public int Width, Height;

    [SerializeField]
    public float HexSize;

    [SerializeField]
    public HexOrientation HexOrientation;

    void OnDrawGizmos()
    {
        for (int z = 0; z < Height; z++)
        {
            for (int x = 0; x < Width; x++)
            {
                Vector3 hexCenter = HexMath.GetHexCenter(HexSize, x, z, HexOrientation) + transform.position;
                Vector3[] hexCorners = HexMath.GetHexCorners(HexSize, HexOrientation);
                for (int s = 0; s < hexCorners.Length; s++)
                {
                    Gizmos.DrawLine(
                        hexCenter + hexCorners[s % 6],
                        hexCenter + hexCorners[(s + 1) % 6]
                    );
                }
            }
        }
    }

    void Awake()
    {

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
