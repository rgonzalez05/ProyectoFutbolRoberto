using AdminitracionDeTorneosP.Database;
using AdminitracionDeTorneosP.Model;
using System;
using System.Windows.Forms;

namespace AdminitracionDeTorneosP.View
{
    public partial class listadoArbitros : Form
    {
        refereeDB refereeDB = new refereeDB();

        public listadoArbitros()
        {
            InitializeComponent();
            ListArbitros.DataSource = refereeDB.getRefereee();
        }
    }
}
