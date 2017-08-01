using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Ticket
    {

    }

    class Caja
    {

        public Caja() {
            this.tickets = new List<Ticket>();
        }

        public int Id { get; set; }
        public List<Ticket> tickets { get; private set; }
        
    }

    public delegate void TotalEventHandler(object o, TotalEventArgs e);

    public class TotalEventArgs:EventArgs
    {
        public TotalEventArgs(int id, decimal total) {

            Id = id;
            Total = total;
        }

        public int Id { get; private set; }
        public decimal Total { get; private set; }
    }
}
