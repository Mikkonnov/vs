
using System.Diagnostics;
using System.Windows.Forms;
//using System.Xml.Linq;

namespace WinFormsApp4
{

    public partial class Form1 : Form
    {
        public static class SuccessfulWork
        {
            public static List<CustomsSelfInfo> Information;
            public static List<CargoDeclaration> Cargo;

            static SuccessfulWork()
            {
                Information = CustomsSelfInfo.GetInfoList();
                Cargo = CargoDeclaration.GetDeclarationList();
            }
     
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayCollections()
        {
            // Вывод коллекций
            foreach (var info in SuccessfulWork.Information)
            {
                label1.Text = ($"ID: {info.ID}, Name: {info.Name}, Surname: {info.Surname}, Age: {info.Age}, Cargo: {info.Cargo}");
            }
            foreach (var cargo in SuccessfulWork.Cargo)
            {
                label2.Text += ($" ID: {cargo.ID}, SelfID: {cargo.SelfID}, Declaration: {cargo.Declaration}, AD: {string.Join(", ", cargo.AD)}");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            IEnumerable<decimal> seqence = SuccessfulWork.Cargo
                .Where(n => n.SelfID.Length == 1 | n.SelfID.First() == n.SelfID.Last())
                .Select(n => n.AD.Average());
            foreach (decimal ad in seqence)
            {
                label1.Text += " " + Convert.ToString(Convert.ToInt32(ad));
            }
     
            //DisplayCollections();      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}