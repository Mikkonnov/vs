using System.Diagnostics;

public class CustomsSelfInfo
{
    public string ID;
    public string Name;
    public string Surname;
    public int Age;
    public int Cargo;
    public static List<CustomsSelfInfo> GetInfoList()
    {
        //var declar1 = new CustomsSelfInfo { ID = "1", Name = "Mikhail", Surname = "Konnov", Age = 19, Cargo = 2 };
        List<CustomsSelfInfo> SelfInfo = new List<CustomsSelfInfo>();

        SelfInfo.Add(new CustomsSelfInfo { ID = "1", Name = "Mikhail", Surname = "Konnov", Age = 20, Cargo = 2 });

        return (SelfInfo);
    }
  

}