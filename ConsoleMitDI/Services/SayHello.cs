using System.Windows.Forms;

namespace ConsoleMitDI.Services
{
    public interface ISayHello
    {
        void Execute(string message);
    }

    public class SayHello : ISayHello
    {
        public void Execute(string message)
        {
            MessageBox.Show(message);
        }
    }
}