[Serializable]
public class Animal
{
    public string? name;
    public int age { get; set; }

    //[NonSerialized]
    public string? category;
    public Animal() { }

    public Animal(string? name, int age, string? category)
    {
        this.name = name;
        this.age = age;
        this.category = category;
    }
}
