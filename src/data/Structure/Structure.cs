using System;

public abstract class Structure{
	public string Name;
	
	private List<Field> _fields;
	public List<Field> Fields{
		get{
			return _fields;	
		}
	}
	
	public Structure(StructureArguments arguments){
		_fields = new List<Field>();	
	}
	
	protected void AddField(string name, string type, object val){
		switch(type){
			case "int":
				_fields.Add(new IntField(name,(int)val));
				return;
			case "string":
				_fields.Add(new StringField(name,(string)val));
				return;
			case "object":
				_fields.Add(new ObjectField(name,val));
				return;
		}
	}
	
	protected void AddField(Field field){
		_fields.Add(field);
	}
}
