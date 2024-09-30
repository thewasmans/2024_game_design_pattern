using System.Collections.Generic;
using System.Linq;

public interface PooledObject
{
    public void SetAtive();
    public void Initialize();
}

public class PooledObjectTest : PooledObject
{
    public void Initialize()
    {
        throw new System.NotImplementedException();
    }

    public void SetAtive()
    {
        throw new System.NotImplementedException();
    }
}

public class Pool
{
    public List<PooledObject> available = new List<PooledObject>();

    public PooledObject GetObject()
    {
        if(available.Count > 0)
        {
            PooledObject pooledObject = available.ElementAt(0);
            available.RemoveAt(0);
            return pooledObject;
        }
        else
        {
            PooledObject pooledObject = new PooledObjectTest();
            return pooledObject;
        }
    }
}