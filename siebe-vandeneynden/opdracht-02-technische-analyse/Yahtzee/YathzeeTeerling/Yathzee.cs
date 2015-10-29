using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YathzeeTeerling
{
  public partial class Yathzee : Form
  {
    public Yathzee()
    {
      InitializeComponent();
    }

    private void Yathzee_Load(object sender, EventArgs e)
    {
      //toevoegen scorebord

      //toevoegen yathzee
      YahtzeeController yahtzee = new YahtzeeController();
      YahtzeeView yahtzeeView = yahtzee.getView();
      yahtzeeView.Location = new Point(0, 0);
      yahtzee.initialize();
      Controls.Add(yahtzeeView);
    }
  }
}