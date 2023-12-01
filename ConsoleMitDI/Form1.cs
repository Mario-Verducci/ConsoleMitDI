using ConsoleMitDI.Services;
using System.Windows.Forms;

namespace ConsoleMitDI
{
    public partial class Form1 : Form
    {
        private readonly IDatabase _database;
        private readonly ISayHello _sayHello;

        public Form1(IDatabase database, ISayHello sayHello)
        {
            _database = database;
            _sayHello = sayHello;

            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            _sayHello.Execute("Hallo aus Form1 wofür niemand = new Form1() aufgerufen hat und alle Parameter des Konstruktor gefüllt hat.");
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            string irgendwas = _database.GetIrgendwas();
            label1.Text = $@"Der Text aus der Datenbank: {irgendwas}";
        }
    }
}
