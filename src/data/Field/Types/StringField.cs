using System;

public class StringField : Field{
	private string val;
	
	public StringField(string n, string s) : base(n){
		val = s;	
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
