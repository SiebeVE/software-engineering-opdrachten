using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YathzeeTeerling
{
  public partial class YahtzeeView : UserControl
  {
    private YahtzeeController _controller;

    public YahtzeeView(YahtzeeController controller)
    {
      _controller = controller;
      InitializeComponent();
    }


    private void gooiAlleTeerlingen_Click(object sender, EventArgs e)
    {
      _controller.getModel().AantalWorpen++;
      if (_controller.getModel().AantalWorpen <= _controller.getModel().MaxAantalWorpen)
      {
        _controller.werpAlleTeerlingen(); //controller teerling laten werpen
        if(_controller.getModel().AantalWorpen+1 > _controller.getModel().MaxAantalWorpen)
        {
          startOpnieuw.Visible = true;
        }
      }
    }

    private void YahtzeeView_Load(object sender, EventArgs e)
    {

      List<TeerlingView> teerlingen = _controller.getTeerlingenView(); //Lijst met alle views
      int teerlingWidth = teerlingen[0].Width; //breedte van 1 teerling voor correct naast elkaar

      foreach (TeerlingView teerling in teerlingen)
      {
        TeerlingView huidigeTeerling = teerling;

        int xPos = teerlingen.IndexOf(teerling) * teerlingWidth; //x positie zetten afhankelijk van index en width
        huidigeTeerling.Location = new Point(xPos, 0);

        Controls.Add(huidigeTeerling); //huidige teerling toevoegen aan view

        huidigeTeerling.updateViewTeerling();
      }
      gooiAlleTeerlingen.Location = new Point(20, teerlingen[0].Height); //Smijt alle teerlingen onder de teerling zetten
      startOpnieuw.Location = new Point((25 + gooiAlleTeerlingen.Width), teerlingen[0].Height);
      huidig.Location = new Point(20, teerlingen[0].Height + gooiAlleTeerlingen.Height + 5);
      highscore.Location = new Point(20, teerlingen[0].Height + gooiAlleTeerlingen.Height + huidig.Height + 5);
      highscore.Text = "Highscore: 0";
      huidig.Text = "Huidige worp: 0";
      startOpnieuw.Visible = !(_controller.getModel().AantalWorpen <= _controller.getModel().MaxAantalWorpen);

    }

    private void startOpnieuw_Click(object sender, EventArgs e)
    {
      //spel reseten
      _controller.getModel().AantalWorpen = 0;

      startOpnieuw.Visible = false;
      List<TeerlingView> teerlingen = _controller.getTeerlingenView(); //Lijst met alle views
      foreach (var teerling in teerlingen)
      {
        teerling.getController().resetTeerling();
      }
    }

    public void updateScores()
    {
      huidig.Text = "Huidige worp: " + _controller.getModel().Huidig;
      highscore.Text = "Highscore: " + _controller.getModel().Highscore;
    }
  }
}