using UnityEngine;

public class script : MonoBehaviour
{
  bool isAwakeCalled = false;
  bool isOnEnableCalled = false;
  bool isStartCalled = false;
  bool isUpdateCalled = false;
  bool isLateUpdateCalled = false;
  bool isFixedUpdateCalled = false;
  bool isOnDisableCalled = false;
  bool isOnDestroyCalled = false;

  void Awake()
  {
    if (!isAwakeCalled)
    {
      Debug.Log("Awake");
      isAwakeCalled = true;
    }
  }

  void OnEnable()
  {
    if (!isOnEnableCalled)
    {
      Debug.Log("OnEnable");
      isOnEnableCalled = true;
    }
  }

  void Start()
  {
    if (!isStartCalled)
    {
      Debug.Log("Start");
      isStartCalled = true;
    }
  }

  void Update()
  {
    if (!isUpdateCalled)
    {
      Debug.Log("Update");
      isUpdateCalled = true;
    }
  }

  void LateUpdate()
  {
    if (!isLateUpdateCalled)
    {
      Debug.Log("LateUpdate");
      isLateUpdateCalled = true;
    }
  }

  void FixedUpdate()
  {
    if (!isFixedUpdateCalled)
    {
      Debug.Log("FixedUpdate");
      isFixedUpdateCalled = true;
    }
  }

  void OnDisable()
  {
    if (!isOnDisableCalled)
    {
      Debug.Log("OnDisable");
      isOnDisableCalled = true;
    }
  }

  void OnDestroy()
  {
    if (!isOnDestroyCalled)
    {
      Debug.Log("OnDestroy");
      isOnDestroyCalled = true;
    }
  }
}