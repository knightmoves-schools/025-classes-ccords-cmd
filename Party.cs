namespace knightmoves;
public class Party
{
public Person[] Guests = new Person[]{
 new Person("sdliubg", "sogb"),
 new Person("sdliubg", "sogb"),
 new Person("sdliubg", "sogb")
};
}

public class Person
{
 public string FirstName = { get; }
 public string LastName = { get; }
 
 public Person(string firstName, string lastName)
 {
 FirstName = firstName;
 LastName = lastName;
 }
}
