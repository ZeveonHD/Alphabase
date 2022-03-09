using System;

public class ObjectField : Field{
	private object val;
	
	public ObjectField(string n, object o) : base(n){
		val = o;
	}	
	
	public override dynamic Resolve(){
		return val;	
	}
	
	public override T Cast<T>(){
		try{
			return (T)((object)val);	
		}
		catch{
			return default(T);	
		}
	}
}