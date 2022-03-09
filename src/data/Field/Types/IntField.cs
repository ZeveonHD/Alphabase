using System;

public class IntField : Field{
	private int val;
	
	public IntField(string n, int v) : base(n){
		val = v;	
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
