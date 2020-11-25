using UnityEngine;
using System;


namespace Assets.MyScripts 
{
    public sealed class CreateWayPoint : MonoBehaviour
    {
		[SerializeField] private GameObject _prefab;
		private PathBot _rootWayPoint;

		public GameObject InstantiateObj(Vector3 pos)
		{
			if (!_rootWayPoint)
			{
				_rootWayPoint = new GameObject("WayPoint").AddComponent<PathBot>();
			}

			if (_prefab != null)
			{
				return Instantiate(_prefab, pos, Quaternion.identity, _rootWayPoint.transform);
			}

			throw new Exception($"Нет префаба на компоненте {typeof(CreateWayPoint)} {gameObject.name}");
		}
	}
}
