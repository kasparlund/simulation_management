namespace VSM.Client.Datamodel;
// This interface is an example and is intended to be used for many DTOs
internal interface ICountryDto
{
    string Country { get; }
}
public class UserDto : ICountryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = "n/a";
    public string Country { get; set; } = "n/a";
    public int Age { get; set; }
}