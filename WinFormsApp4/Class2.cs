public class CargoDeclaration
{
    public int ID;
    public string SelfID;
    public bool Declaration;
    public decimal[] AD;
    public static List<CargoDeclaration> GetDeclarationList()
    {
        List<CargoDeclaration> Declar = new List<CargoDeclaration>();

        Declar.Add(new CargoDeclaration { ID = 1, SelfID = "1", Declaration = true, AD = new decimal[] { 1.23m, 456.789m } });
        Declar.Add(new CargoDeclaration { ID = 2, SelfID = "1", Declaration = false, AD = new decimal[] { 10.23m, 31.29m } });
        Declar.Add(new CargoDeclaration { ID = 3, SelfID = "122", Declaration = false, AD = new decimal[] { 10.23m, 31.29m } });
        return (Declar);
    }
    //public static CargoDeclaration[] GetDeclarationArray()
    //{
      //  return (GetDeclarationList().ToArray());
    //}
}