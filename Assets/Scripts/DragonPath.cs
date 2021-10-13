using UnityEngine;
using Shapes;
using System.Collections;

public class DragonPath : MonoBehaviour {

	public Color lineColor;
	Polyline line;

	char[] path = { 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'r', 'r', 'r', 'l', 'l', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'r', 'r', 'l', 'l', 'l', 'r', 'r', 'l', 'l', 'r', 'l', 'l' };
	Vector2 point;
	Vector2 direction = Vector2.up;
	Vector2[] currentLine;
	int total;
	int current = 0;

	void Awake(){
		Application.targetFrameRate = 60;
		line = GetComponent<Polyline>();
		currentLine = new Vector2[path.Length + 1];
		Color[] c = new Color[path.Length+1];
		currentLine[0] = Vector2.down *0.5f;
		currentLine[1] = Vector2.zero;
		c[0] = Color.black;
		c[1] = Color.black;
		point = Vector2.zero;
		for (int i = 2; i< path.Length + 1; i++) {
			SetDirection(path[i - 2]);
			point += direction * 0.5f;
			currentLine[i] = point;
			c[i] = Color.black;
		}
		line.SetPoints(currentLine, c);
		total = line.points.Count ;
		int half = total / 2;
		/*for(int i = 0; i < half; i++) {
			//float t = (float)i / half;
			//Color c = Color.Lerp(Color.black, lineColor, t);
			line.SetPointColor(i, lineColor);
		}*/
		for(int i = half; i < total; i++) {
			line.SetPointColor(i, Color.black);
		}
	}

	void Update() {
		if(current < currentLine.Length) {
			line.SetPointColor(current, lineColor);
			current++;
		}
		/*if(current < total) {
			SetDirection(path[current]);
			for(int i =0; i < total; i++) {
				PolylinePoint p = line.points[i];
				if(i == total -1) {
					point += direction * 0.5f;
					currentLine[i] = point;
					p.point = point;
				}
				else {
					currentLine[i] = currentLine[i + 1];
					p.point = currentLine[i];
				}

				line.points[i] = p;
			}

			line.meshOutOfDate = true;
			current++;
		}
		*//*if (current > path.Length -1){
			for(int i = 0; i<currentLine.Length;i++) currentLine[i] = Vector2.zero;

			current = 0;
		}*//*
		if(current == total) {
			SetFullColor();
			current++;
		}
		if(current > total) {

		
		}*/
		/*if (current)
			for*/
	}

	void SetFullColor() { 
		for(int i = 0; i < total; i++) {
			line.SetPointColor(i, lineColor);
		}
	}


	void SetDirection(char next) { 
		if(direction == Vector2.up) {
			if (next == 'r') direction = Vector2.right;
			else if (next == 'l') direction = Vector2.left;
		} else if (direction == Vector2.left) {
			if (next == 'r') direction = Vector2.up;
			else if(next == 'l') direction = Vector2.down;
		} else if (direction == Vector2.right) {
			if (next == 'r') direction = Vector2.down;
			else if (next == 'l') direction = Vector2.up;
		} else if (direction == Vector2.down) {
			if (next == 'r') direction = Vector2.left;
			else if (next == 'l') direction = Vector2.right;
		}
	}

	void SetDirection120(char next) {
		int rotation = 30;
		if (next == 'r') rotation *= -1;

		float sin = Mathf.Sin(rotation * Mathf.Deg2Rad);
		float cos = Mathf.Cos(rotation * Mathf.Deg2Rad);

		float tx = direction.x;
		float ty = direction.y;

		direction.x = (cos * tx) - (sin * ty);
		direction.y = (sin * tx) + (cos * ty);
	}
}
