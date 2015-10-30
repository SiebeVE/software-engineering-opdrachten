using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzeeTeerling
{
  public class YahtzeeController
  {
    private YahtzeeView _view;
    private YahtzeeModel _model;

    public YahtzeeController() //constructor
    {
      _view = new YahtzeeView(this);
      _model = new YahtzeeModel();
    }

    public YahtzeeView getView()
    {
      return _view;
    }
    public YahtzeeModel getModel()
    {
      return _model;
    }

    public List<TeerlingView> getTeerlingenView()
    {
      // Maak een lijst die de views zal opvangen
      List<TeerlingView> teerlingenView = new List<TeerlingView>();

      // Loop over het huidig aantal teerlingen uit het model
      foreach (TeerlingController teerling in getModel().Teerlingen)
      {
        // Haal de view op voor iedere teerling
        TeerlingView teerlingView = teerling.getView();

        // Voeg de teerling toe aan de lijst die de views opvangt
        teerlingenView.Add(teerlingView);
      }

      // Return de lijst met teerlingViews
      return teerlingenView;
    }

    public void initialize()
    {
      maakTeerlingen();
    }

    private void maakTeerlingen()
    {
      for (int teerlingNummer = 0; teerlingNummer < _model.AantalTeerlingen; teerlingNummer++)
      {
        // Maak een nieuwe teerling aan
        TeerlingController teerling = new TeerlingController(this);
        teerling._model.Vast = false;
        // Voeg de teerling toe aan het model
        _model.addTeerling(teerling);
        teerling.getView().updateViewTeerling();
      }
    }

    public void werpAlleTeerlingen()
    {
      List<TeerlingController> teerlingen = _model.Teerlingen; //krijg model voor alle teerlingen

      foreach (TeerlingController teerling in teerlingen)
      {
        teerling.werpTeerling();
        teerling.getView().updateViewTeerling();
      }
      veranderScore();
    }

    public void veranderScore()
    {
      List<TeerlingController> teerlingen = _model.Teerlingen;
      int alleOgen = 0;
      foreach (TeerlingController teerling in teerlingen)
      {
        alleOgen += teerling._model.Aantalogen;
      }
      _model.Huidig = alleOgen;
      if (alleOgen > _model.Highscore)
      {
        _model.Highscore = alleOgen;
      }
      _view.updateScores();
    }
  }
}