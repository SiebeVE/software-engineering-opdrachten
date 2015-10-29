using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YathzeeTeerling
{
  public class TeerlingController
  {
    private TeerlingView _view;
    private YahtzeeController _controllerYahtzee;
    public TeerlingModel _model;

    static int seeder = 0; //nodig omdat anders random getal altijd hetzelfde is
    Random random = new Random(++seeder); //random getal genereren

    public TeerlingController(YahtzeeController controller ) //constructor
    {
      _view = new TeerlingView(this); //view aanmaken +
                                      //injecteer controller in view
                                      //(communiceren met elkaar)
      _model = new TeerlingModel(); //model aanmaken
      _controllerYahtzee = controller;
    }

    public TeerlingView getView()
    {
      return _view;
    }

    public void werpTeerling()
    {
      YahtzeeModel _modelYahtzee = _controllerYahtzee.getModel();
      if (!_model.Vast && _modelYahtzee.AantalWorpen <= _modelYahtzee.MaxAantalWorpen)
      {
        int teerlingGetal = random.Next(1, 7); //random tussen 1 en 6
        _model.Aantalogen = teerlingGetal; //random getal doorsturen naar model
      }
    }

    public void toggleVast()
    {
      _model.Vast = !_model.Vast;
    }

    public void resetTeerling()
    {
      _model.Aantalogen = 0;
      _model.Vast = false;
      _view.updateViewTeerling();
    }
  }
}
