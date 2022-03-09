using System;
using System.Collections.Generic;

public class Container<T>{
    private List<T> _objects;
    public List<T> objects{
        get{
            return _objects;
        }
    }

    private bool _letRepeats = false;
    public bool letRepeats{
        get{
            return _letRepeats;
        }
    }

    public Container(){
        _objects = new List<T>();
    }

    public void Add(T obj){
        if (_letRepeats == false && _objects.Contains(obj)) return;

        _objects.Add(obj);
    }

    public void Remove(T obj, bool removeRepeats = false){
        if (!_objects.Contains(obj)) return;

        if (removeRepeats == true){
            _objects.RemoveAll(obj);
        }

        _objects.Remove();
    }
}