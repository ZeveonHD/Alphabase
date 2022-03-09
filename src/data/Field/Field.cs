using System;

public abstract class Field{
	private string _name;
	public string Name{
		get{
			return _name;	
		}
	}
	
	public Field(string n){
		_name = n;	
	}
	
	public abstract dynamic Resolve();
	
	public abstract T Cast<T>();
}
